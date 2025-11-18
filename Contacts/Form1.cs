namespace Contacts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка Добавить");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка Удалить");
        }
    }
}
