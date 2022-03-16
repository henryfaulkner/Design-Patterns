namespace Robot
{
    public class SpeechOffCommand : ICommand
    {
        Voice voice;

        public SpeechOffCommand(Voice voice)
        {
            this.voice = voice;
        }

        public void Execute()
        {
            voice.Off();
        }
    }
}