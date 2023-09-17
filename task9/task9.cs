using System.Windows.Forms;

namespace task9
{
    public partial class task9 : Form
    {
        Ar array;

        public task9()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {
            if (tab.SelectedTab.Name == "tabRandom")
            {
                array = new Ar(10);
            }else if (tab.SelectedTab.Name == "tabFile")
            {
                if (txtFile.Text == "")
                    MessageBox.Show("Не обрано текстовий файл!", "Помилка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    array = new Ar(txtFile.Text);
            }else
                MessageBox.Show("Невідомий варіант заповнення!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtFile.Text = openFileDialog1.FileName;
        }
    }
}
