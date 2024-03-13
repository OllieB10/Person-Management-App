using System.Linq;

namespace PersonUI
{
    public class NewPersonChecks : INewPersonChecks
    {
        /// <summary>
        /// Checks whether the user input is valid or not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool ValidateUserInput(string input)
        {
            if (!string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter))
            {
                return true;
            }

            return false;
        }
    }
}
