using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Robot
{
    public class Voice
    {
        string currentAction = string.Empty;
        //This is shit bc it's not a relative path
        //Must run project from repo parent folder or through driver
        //Fix if have time 
        string fortunesJsonPath = "CommandPattern/Robot/Fortunes/Fortunes.json";

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
                    Console.WriteLine(fortune);
                    break;
                case ActionConstants.VocalType.Obsenities:
                    currentAction = ActionConstants.VocalType.Obsenities;
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

        string GetRandomFortune()
        {
            List<FortuneModel> fortunes = GetAllFortunes();
            Random random = new Random();
            int index = random.Next(fortunes.Count);
            return fortunes[index].fortune;
        }
    }
}