using System.IO;
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
            //1. Створюємо об'єкт
            if (tab.SelectedTab.Name == "tabRandom")
            {
                //заповнення випадковими числами
                array = new Ar(
                    (int)numCount.Value,
                    (int)numFrom.Value, 
                    (int)numTo.Value
                );

            }
            else if (tab.SelectedTab.Name == "tabFile")
                //заповнення з файлу
            {
                if (txtFile.Text == "")
                    //якщо файл не існує
                    MessageBox.Show("Не обрано текстовий файл!", "Помилка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    try
                    {
                        array = new Ar(txtFile.Text);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Файл не знайдено!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (FileLoadException)
                    {
                        MessageBox.Show("Помилка читання файлу!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            else
                //такого варіанту не може бути, але все можливо)
                MessageBox.Show("Невідомий варіант заповнення!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            //2. Виводимо результат
            array.Print(lstArray);

            //3. Проводимо аналіз
            txtNegative.Text = array.K.ToString();
            int lastNegative = array.P();
            if (lastNegative == -1)
            {
                txtLast.Text = "";
                txtSum.Text = "";
                MessageBox.Show("Масив не має від'ємних елементів", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                txtLast.Text = lastNegative.ToString();
                txtSum.Text = array.Sum(0, lastNegative).ToString();
            }
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtFile.Text = openFileDialog1.FileName;
        }
    }
}
