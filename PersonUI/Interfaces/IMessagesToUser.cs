using System.Windows.Forms;

namespace PersonUI
{
    public interface IMessagesToUser
    {
        DialogResult DisplayMessageBox(string message);
        DialogResult DisplayMessageBoxYesNo(string message, MessageBoxButtons yesNo);
    }
}