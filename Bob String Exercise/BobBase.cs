namespace C__Exercises
{
    public static class BobBase
    {
        public static string Response(string statement)
        {
            // Trim whitespace from the input statement
            string input = statement.Trim();

            // Check if the statement ends with a question mark
            if (input.EndsWith("?"))
            {

                // If it's a yelling question, respond with a specific message
                if (input == input.ToUpper() && input != input.ToLower())
                {
                    return "Calm down, I know what I'm doing!";
                }

                // If it's just a question, return a general response
                return "Sure.";
            }

            // Check if the statement contains any letters and if it's all uppercase (yelling)
            bool isYelling = input.Any(char.IsLetter) && input == input.ToUpper();

            // If it's yelling, return a response indicating to chill out
            if (isYelling)
            {
                return "Whoa, chill out!";
            }

            if (string.IsNullOrEmpty(statement) || string.IsNullOrWhiteSpace(statement))
            {
                return "Fine. Be that way!";
            }

            // For all other cases (neither question nor yelling), return "Whatever."
            return "Whatever.";
        }
    }
}