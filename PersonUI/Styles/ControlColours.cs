using System.Drawing;

using System.Windows.Forms;

namespace PersonUI
{
    public class ControlColours : IControlColours
    {
        public void SetTextboxBackColour(TextBox textbox)
        {
            textbox.BackColor = Color.Yellow;
        }

        public void SetRadioButtonBackColour(RadioButton radioButton)
        {
            radioButton.BackColor = Color.Yellow;
        }

        public void SetDateTimePickerBackColour(DateTimePicker dateTime)
        {
            dateTime.CalendarMonthBackground = Color.Yellow;
        }

        public void ResetTextboxColor(DialogResult result, TextBox textbox)
        {
            if (result == DialogResult.OK)
            {
                textbox.BackColor = SystemColors.Window;
            }
        }

        public Color SetColourToRed()
        {
            return Color.Red;
        }
    }
}
