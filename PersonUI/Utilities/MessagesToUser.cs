using System.Windows.Forms;

namespace PersonUI
{
    public class MessagesToUser : IMessagesToUser
    {
        public DialogResult DisplayMessageBox(string message)
        {
            return MessageBox.Show(message);
        }

        public DialogResult DisplayMessageBoxYesNo(string message, MessageBoxButtons yesNo)
        {
            return MessageBox.Show(message, string.Empty, yesNo);
        }
    }
}
