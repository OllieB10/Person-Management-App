using System;
using System.Windows.Forms;
using DataAccess;
using PersonModel;

namespace PersonUI
{
    public partial class HomePage : Form
    {      
        private readonly INewPerson _newPerson;
        private readonly IExitApplication _exitApplication;
        private readonly IDataManager _dataManager;
        private readonly IPeopleLoader _peopleLoader;
        private readonly IViewPersonPage _viewPersonPage;

        public HomePage(IExitApplication exitApplication, IDataManager dataManager, INewPerson newPerson, IPeopleLoader peopleLoader, IViewPersonPage viewPersonPage)
        {
            InitializeComponent();

            _dataManager = dataManager;

            _newPerson = newPerson;

            _viewPersonPage = viewPersonPage;

            _peopleLoader = peopleLoader;

            this.Load += HomePage_Loaded;

            _exitApplication = exitApplication;
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            _newPerson.Show();
        }
    
        private void ExitButton_Click(object sender, EventArgs e)
        {
            _exitApplication.ExitTheApp();
        }

        private void ViewPersonButton_Click(object sender, EventArgs e)
        {
            // Get the selected row from the DataGridView
            DataGridViewRow selectedRow = PersonGridView.SelectedRows[0];

            // Extract data from the selected row
            string name = selectedRow.Cells["FullName"].Value.ToString();
            int personId = (int)selectedRow.Cells["PersonId"].Value;
            string[] nameSplit = name.Split();
            string firstName = nameSplit[0];
            string lastName = nameSplit[1];
            string emailAddress = selectedRow.Cells["EmailAddressColumn"].Value.ToString();
            DateTime dateOfBirth = (DateTime)selectedRow.Cells["DateOfBirthColumn"].Value;
            string dob = dateOfBirth.ToShortDateString();
            string gender = selectedRow.Cells["GenderColumn"].Value.ToString();

            _viewPersonPage.DisplayPerson(personId, firstName, lastName, emailAddress, dateOfBirth, gender, true);

            _viewPersonPage.Show();
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            if (PersonGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can only delete one person at a time.");

                PersonGridView.ClearSelection();
            }
            else if (PersonGridView.SelectedRows.Count == 0)
            {
                var result = MessageBox.Show("You must select a single row from the list of people.");
            }
            else if (PersonGridView.SelectedRows.Count == 1)
            {
                var answer = MessageBox.Show("Are you sure you want to delete this record from the database?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                var selectedRow = PersonGridView.SelectedRows[0];

                IPerson selectedPerson = (IPerson)selectedRow.DataBoundItem;

                if (answer == DialogResult.Yes)
                {
                    _dataManager.DeletePerson(selectedPerson);
                }
                else
                {
                    // Do nothing
                }
               
            }

            _peopleLoader.LoadPeople(PersonGridView);
        }

        private void EditPersonButton_Click(object sender, EventArgs e)
        {
            // Get the selected row from the DataGridView
            DataGridViewRow selectedRow = PersonGridView.SelectedRows[0];

            // Extract data from the selected row
            int personId = (int)selectedRow.Cells["PersonId"].Value;
            string name = selectedRow.Cells["FullName"].Value.ToString();
            string[] nameSplit = name.Split();
            string firstName = nameSplit[0];
            string lastName = nameSplit[1];
            string emailAddress = selectedRow.Cells["EmailAddressColumn"].Value.ToString();
            DateTime dateOfBirth = (DateTime)selectedRow.Cells["DateOfBirthColumn"].Value;
            string gender = selectedRow.Cells["GenderColumn"].Value.ToString();

            _viewPersonPage.DisplayPerson(personId, firstName, lastName, emailAddress, dateOfBirth, gender, false);

            _viewPersonPage.Show();
        }
      
        private void HomePage_Loaded(object sender, EventArgs e)
        {
            LoadHomePage();
        }

        #region Helper Functions
        public void LoadHomePage()
        {
            _peopleLoader.LoadPeople(PersonGridView);
        }

        #endregion
    }
}
