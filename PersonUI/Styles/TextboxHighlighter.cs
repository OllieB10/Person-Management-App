using System.Drawing;
using System.Windows.Forms;


namespace PersonUI
{
    public class TextboxHighlighter : ITextboxHighlighter
    {
        public void HighlightTextbox(TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                textbox.BackColor = Color.Yellow;
            }
        }
    }
}
