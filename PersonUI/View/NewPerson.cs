using System;
using System.Windows.Forms;
using DataAccess;
using PersonModel;

namespace PersonUI
{
    public partial class NewPerson : Form, INewPerson
    {
        private readonly IMessagesToUser _messagesToUser;

        private readonly ITextboxHighlighter _textboxHighlighter;

        private readonly IControlColours _controlColours;

        private readonly IGenderSelectionHandler _genderSelectionHandler;

        private readonly IDataManager _dataManager;

        private readonly IPerson _person;

        public HomePage HomePage { get; set; }

        public NewPerson(IControlColours controlColours, ITextboxHighlighter textboxHighlighter, IMessagesToUser messagesToUser,
                              IGenderSelectionHandler genderSelectionHandler, IDataManager dataManager, IPerson person)
        {
            //initializes all the controls that you've added to your form
            InitializeComponent();

            _dataManager = dataManager;

            _person = person;

            _controlColours = controlColours;

            _textboxHighlighter = textboxHighlighter;

            _messagesToUser = messagesToUser;

            _genderSelectionHandler = genderSelectionHandler;
      
            _controlColours.SetTextboxBackColour(FirstNameEntryTextbox);

            _controlColours.SetTextboxBackColour(LastNameEntryTextbox);

            _controlColours.SetTextboxBackColour(EmailAddressTextbox);

            _controlColours.SetRadioButtonBackColour(MaleRadioButton);

            _controlColours.SetRadioButtonBackColour(FemaleRadioButton);

            _controlColours.SetRadioButtonBackColour(OtherRadioButton);

            _controlColours.SetDateTimePickerBackColour(DateOfBirthPicker);

            //Make sure the form pops up in the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Resets the controls in the NewPerson form
        /// </summary>
        private void ResetNewPersonForm()
        {
            FirstNameEntryTextbox.Clear();
            LastNameEntryTextbox.Clear();
            EmailAddressTextbox.Clear();
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
            OtherRadioButton.Checked = false;
            DateOfBirthPicker.ResetText();
        }

        /// <summary>
        /// Allows the user to exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonEntry_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the NewPerson form

            // Reset the form.
            ResetNewPersonForm();

            // Load the HomePage ensuring the new database is loaded.
            HomePage.LoadHomePage();

            // Display the homepage.
            HomePage.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // This is the last thing to check.
            if (string.IsNullOrWhiteSpace(FirstNameEntryTextbox.Text) || string.IsNullOrWhiteSpace(LastNameEntryTextbox.Text) || (!MaleRadioButton.Checked
                    && !FemaleRadioButton.Checked && !OtherRadioButton.Checked))
            {
                _textboxHighlighter.HighlightTextbox(FirstNameEntryTextbox);
                _textboxHighlighter.HighlightTextbox(LastNameEntryTextbox);

                DialogResult result = _messagesToUser.DisplayMessageBox("Make sure every mandatory field has a value.");

                _controlColours.ResetTextboxColor(result, FirstNameEntryTextbox);
                _controlColours.ResetTextboxColor(result, LastNameEntryTextbox);

                return;
            }
            else
            {
                string selectedGender = string.Empty;

                if (MaleRadioButton.Checked)
                {
                    selectedGender = _genderSelectionHandler.GetGenderSelected(Gender.Male);
                }
                else if (FemaleRadioButton.Checked)
                {
                    selectedGender = _genderSelectionHandler.GetGenderSelected(Gender.Female);
                }
                else if (OtherRadioButton.Checked)
                {
                    selectedGender = _genderSelectionHandler.GetGenderSelected(Gender.Other);
                }

                if (string.IsNullOrEmpty(FirstNameEntryTextbox.Text) || string.IsNullOrEmpty(LastNameEntryTextbox.Text))
                {
                    _messagesToUser.DisplayMessageBox("Make sure mandatory fields are entered.");
                }
                else
                {
                    _person.FirstName = FirstNameEntryTextbox.Text;
                    _person.LastName = LastNameEntryTextbox.Text;
                    _person.EmailAddress = EmailAddressTextbox.Text;
                    _person.Gender = selectedGender;
                    _person.DateOfBirth = DateOfBirthPicker.Value;

                    // Create our new person in the database.
                    _dataManager.CreatePerson(_person);

                    // Hide the NewPerson form.
                    this.Hide();

                    // Reset the form.
                    ResetNewPersonForm();

                    // Load the HomePage ensuring the new database is loaded.
                    HomePage.LoadHomePage();

                    // Display the homepage.
                    HomePage.Show();
                }
            }
        }
    }
}
