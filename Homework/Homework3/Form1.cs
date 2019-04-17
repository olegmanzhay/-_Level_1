/*Задача 3
 а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных).
б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog). 
(БАЗА ДАННЫХ МОЖЕТ СОХРАНЯТЬСЯ В 2 ВАРИАНТАХ xml и CSV)
Задача 5 
**Написать программу-преобразователь из CSV в XML-файл с информацией о выражениях верю-не верю . (OpenCSV -> LoadCSV)
 */
using System;
using System.Windows.Forms;
using BelieveOrNotBelieve;

namespace Homework3
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };

        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxTrue.Text = string.Empty;
            tboxFalse.Text = string.Empty;
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            if (cboxTrue.Checked == true)
                tboxTrue.Text = "Это правда";
            else
                tboxFalse.Text = "Это Ложь";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            if (cboxTrue.Checked)
            {
                database.Add((tboxQuestion.Text), true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }
            else
            {
                database.Add((tboxQuestion.Text), false);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;

        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");

        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;

            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Манжай Олег\nВерсия 1.0");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveAs = new SaveFileDialog();
            SaveAs.Filter = "csv|*.csv| XML Files |*.xml";
           
            if (SaveAs.ShowDialog() == DialogResult.OK)
            {
                string filename = SaveAs.FileName;
                if (database != null && SaveAs.FilterIndex == 2)
                    database.Save();
                else if (database != null && SaveAs.FilterIndex == 1)
                    database.SaveASCSV(filename);
                else MessageBox.Show("База данных не создана");
            }
            /*if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, tboxQuestion.Text);
            MessageBox.Show("Файл сохранен");*/

        }

        private void tboxQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dudNumber_SelectedItemChanged(object sender, EventArgs e)
        {
            tboxTrue.Text = string.Empty;
            tboxFalse.Text = string.Empty;
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            if (cboxTrue.Checked == true)
                tboxTrue.Text = "Это правда";
            else
                tboxFalse.Text = "Это Ложь";


        }

        private void openCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    database = new TrueFalse(ofd.FileName);
                    database.LoadCSV();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;

                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
