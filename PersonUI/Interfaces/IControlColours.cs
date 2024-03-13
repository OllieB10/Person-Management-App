using System.Drawing;
using System.Windows.Forms;

namespace PersonUI
{
    public interface IControlColours
    {
        void SetTextboxBackColour(TextBox textbox);

        void SetRadioButtonBackColour(RadioButton radioButton);

        void SetDateTimePickerBackColour(DateTimePicker dateTime);

        void ResetTextboxColor(DialogResult result, TextBox textbox);

        Color SetColourToRed();
    }
}
