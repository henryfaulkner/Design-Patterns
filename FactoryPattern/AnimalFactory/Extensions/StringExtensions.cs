namespace AnimalFactory
{
    public class StringExtensions
    {
        public static string ConvertIntToStringResponse(string number)
        {
            switch (number.Trim())
            {
                case "1":
                    return "human";
                case "2":
                    return "monkey";
                case "3":
                    return "pig";
                case "4":
                    return "exit";
                default:
                    return string.Empty;
            }
        }
    }
}