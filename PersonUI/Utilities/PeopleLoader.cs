using DataAccess;
using PersonModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonUI
{
    public class PeopleLoader : IPeopleLoader
    {
        private readonly IDataManager _dataManager;
        public PeopleLoader(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public void LoadPeople(DataGridView dataGridView)
        {
            List<Person> people = _dataManager.GetPeople();

            dataGridView.AutoGenerateColumns = false;

            dataGridView.DataSource = people;
        }
    }
}
