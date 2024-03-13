using System.Windows.Forms;
using System;
using DataAccess;
using PersonModel;

namespace PersonUI
{
    public partial class ViewPersonPage : Form, IViewPersonPage
    {
        public HomePage HomePage { get; set; }
        private int personId;

        private readonly IExitApplication _exitApplication;
        private readonly IDataManager _dataManager;
        private readonly IPerson _person;

        public ViewPersonPage(IExitApplication exitApplication, IDataManager dataManager, IPerson person)
        {
            InitializeComponent();

            _dataManager = dataManager;

            _person = person;

            _exitApplication = exitApplication;
        }

        /// <summary>
        /// Exits the ViewPersonForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonView_Click(object sender, EventArgs e)
        {
            // Hide this form.
            this.Hide();

            // Reset the values so they dont appear when the form is reloaded.
            ResetPersonView();

            // SHow our homepage.
            HomePage.Show();
        }

        /// <summary>
        /// Dsiplay the person selected on the View Person form.
        /// </summary>
        /// <param name="personId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="dob"></param>
        /// <param name="gender"></param>
        /// <param name="isReadOnly"></param>
        public void DisplayPerson(int personId, string firstName, string lastName, string email, DateTime dob, string gender, bool isReadOnly)
        {
            this.personId = personId;
            FirstNameTextboxView.Text = firstName;
            LastNameTextboxView.Text = lastName;
            EmailAddressTextboxView.Text = email;
            DateOfBirthViewPicker.Value = dob;
            GenderTextboxView.Text = gender;

            if (isReadOnly == true)
            {
                FirstNameTextboxView.ReadOnly = true;
                LastNameTextboxView.ReadOnly = true;
                EmailAddressTextboxView.ReadOnly = true;
                DateOfBirthViewPicker.Enabled = false;
                GenderTextboxView.ReadOnly = true;

                UpdateButton.Enabled = false;
            }
            else
            {
                FirstNameTextboxView.ReadOnly = false;
                LastNameTextboxView.ReadOnly = false;
                EmailAddressTextboxView.ReadOnly = false;
                DateOfBirthViewPicker.Enabled = true;
                GenderTextboxView.ReadOnly = false;

                UpdateButton.Enabled = true;
            }
        }

        /// <summary>
        /// Reset all of the values on the View Person form.
        /// </summary>
        private void ResetPersonView() 
        {
            FirstNameTextboxView.Clear();
            LastNameTextboxView.Clear();
            EmailAddressTextboxView.Clear();
            DateOfBirthViewPicker.Value = DateTime.Now;
            GenderTextboxView.Clear();
        }

        /// <summary>
        /// Updates the People table if the condition is satisfied.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // All fields on the form must have a value.
            if (string.IsNullOrEmpty(FirstNameTextboxView.Text) || string.IsNullOrEmpty(LastNameTextboxView.Text)
                       || string.IsNullOrEmpty(EmailAddressTextboxView.Text) || string.IsNullOrEmpty(GenderTextboxView.Text)
                               || string.IsNullOrEmpty(GenderTextboxView.Text) || DateOfBirthViewPicker.Value == null)
            {
                MessageBox.Show("All fields must be populated correctly to save the record.");
            }
            else
            {
                // Set all of our values.
                _person.PersonId = this.personId;
                _person.FirstName = FirstNameTextboxView.Text;
                _person.LastName = LastNameTextboxView.Text;
                _person.EmailAddress = EmailAddressTextboxView.Text;
                _person.Gender = GenderTextboxView.Text;
                _person.DateOfBirth = DateOfBirthViewPicker.Value;

                _dataManager.UpdatePerson(_person);

                // Hides this form.
                this.Hide();

                // Resets the values
                ResetPersonView();

                // Loads the Homepage pulling the updated data from the data to display in the DataGrid.
                HomePage.LoadHomePage();
            }          
        }     
    }
}
