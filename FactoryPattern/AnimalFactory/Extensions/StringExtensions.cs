namespace AnimalFactory
{
    public class StringExtensions
    {
        public static string ConvertIntToStringResponse(char number)
        {
            switch (number)
            {
                case '1':
                    return "human";
                case '2':
                    return "monkey";
                case '3':
                    return "pig";
                case '4':
                    return "exit";
                default:
                    return string.Empty;
            }
        }
    }
}