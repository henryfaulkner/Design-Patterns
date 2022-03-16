using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Robot
{
    public class Voice
    {
        string currentAction = null;

        // These paths are shit bc they're not relative paths.
        // Must run project from repo parent folder or through driver.
        string fortunesJsonPath = "CommandPattern/Robot/RobotWords/Fortunes.json";
        string swearsJsonPath = "CommandPattern/Robot/RobotWords/Swears.json";

        public void SetCurrentVocalType(string action)
        {
            switch (action)
            {
                case ActionConstants.VocalType.Fortunes:
                    currentAction = ActionConstants.VocalType.Fortunes;
                    break;
                case ActionConstants.VocalType.Obsenities:
                    currentAction = ActionConstants.VocalType.Obsenities;
                    break;
            }
        }

        public void On()
        {
            switch (currentAction)
            {
                case ActionConstants.VocalType.Fortunes:
                    var fortune = GetRandomFortune();
                    Console.Write($"{fortune}\n");
                    break;
                case ActionConstants.VocalType.Obsenities:
                    var swear = GetRandomSwear();
                    Console.Write($"{swear}\n");
                    break;
            }
        }

        public void Off()
        {
            switch (currentAction)
            {
                case ActionConstants.VocalType.Fortunes:
                    Console.Write("Robot stopped telling fortunes.\n\n");
                    currentAction = null;
                    break;
                case ActionConstants.VocalType.Obsenities:
                    Console.Write("Robot stopped shouting swears.\n\n");
                    currentAction = null;
                    break;
            }
        }

        List<FortuneModel> GetAllFortunes()
        {
            using (StreamReader r = new StreamReader(fortunesJsonPath))
            {
                string json = r.ReadToEnd();
                List<FortuneModel> fortunes = JsonConvert.DeserializeObject<List<FortuneModel>>(json);
                return fortunes;
            }
        }

        List<SwearModel> GetAllSwears()
        {
            using (StreamReader r = new StreamReader(swearsJsonPath))
            {
                string json = r.ReadToEnd();
                List<SwearModel> swears = JsonConvert.DeserializeObject<List<SwearModel>>(json);
                return swears;
            }
        }

        string GetRandomFortune()
        {
            List<FortuneModel> fortunes = GetAllFortunes();
            Random random = new Random();
            int index = random.Next(fortunes.Count);
            return fortunes[index].fortune;
        }

        string GetRandomSwear()
        {
            List<SwearModel> swears = GetAllSwears();
            Random random = new Random();
            int index = random.Next(swears.Count);
            return $"{swears[index].swear.ToUpper()}!!";
        }
    }
}