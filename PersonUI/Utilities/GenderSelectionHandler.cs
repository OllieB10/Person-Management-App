using PersonModel;

namespace PersonUI
{
    /// <summary>
    /// Gets both male and female radio buttons and checks which one has been clicked before returning the result, if neither
    /// Have been selected then return an empty string.
    /// </summary>
    public class GenderSelectionHandler : IGenderSelectionHandler
    {
        public string GetGenderSelected(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "Male";
            }
            else if (gender == Gender.Female)
            {
                return "Female";
            }
            else if (gender == Gender.Other)
            {
                return "Other";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
