using System;
using System.Windows.Forms;

namespace PersonUI
{
    public interface IViewPersonPage
    {
        void Show();

        void DisplayPerson(int personId, string firstName, string lastName, string email, DateTime dob, string gender, bool isReadOnly);
    }
}