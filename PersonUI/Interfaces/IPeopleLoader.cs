using System.Windows.Forms;

namespace PersonUI
{
    public interface IPeopleLoader
    {
        void LoadPeople(DataGridView dataGridView);
    }
}