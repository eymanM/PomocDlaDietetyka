using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PomocDlaDietetyka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }
        static AppDataSet db;
        string[] allowedFood = File.ReadAllLines("ChorobyZalecana.txt");       
        string[] notAllowedFood = File.ReadAllLines("ChorobyNiezalecana.txt");
        protected static AppDataSet App
        {
            get
            {
                if (db == null)
                    db = new AppDataSet();
                return db;
            }
        }
        public void Form1_Load()
        {
            diseasesComboBox.Text = "Dodaj choroby";
            bracketComboBox.Text = "Wybierz żywność";
            WeighOfFoodTXT.Text = "Podaj wagę";
            string filename = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(filename))
                App.DataOfPersons.ReadXml(filename);
            dataOfPersonsBindingSource.DataSource = App.DataOfPersons;
            foreach (var line in allowedFood)
            {
                string[] tokens = line.Split(',');
                diseasesComboBox.Items.Add(tokens[0]);
            }
        }


        private void NewEntriesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                App.DataOfPersons.AddDataOfPersonsRow(App.DataOfPersons.NewDataOfPersonsRow());
                dataOfPersonsBindingSource.MoveLast();
                NameOfPersonTXT.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.DataOfPersons.RejectChanges();
            }
        }

        private void EditEntriesBTN_Click(object sender, EventArgs e)
        {
            NameOfPersonTXT.Focus();
        }

        private void AddPatientTab_Click(object sender, EventArgs e)
        {
            
        }

     

        private void SaveEntriesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                dataOfPersonsBindingSource.EndEdit();
                App.DataOfPersons.AcceptChanges();
                App.DataOfPersons.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.DataOfPersons.RejectChanges();
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Czy napewno chcesz usunąć ten wpis?", "Wiadomość", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    dataOfPersonsBindingSource.RemoveCurrent();
            }
        }

        private void addDiseaseBTN_Click(object sender, EventArgs e)
        {
            if (DiseasesRichTextBox.Text == string.Empty)
                DiseasesRichTextBox.AppendText(diseasesComboBox.SelectedItem.ToString());

            else if (DiseasesRichTextBox.Text != string.Empty)
                DiseasesRichTextBox.AppendText("\n" + diseasesComboBox.SelectedItem.ToString());
                      
            diseasesComboBox.Text = "Dodaj choroby";
        }

        private void CalculateBmiPpmBTN_Click(object sender, EventArgs e)
        {
            string b = dateOfBirthTXT.Text;
            List<char> a = b.Take(4).ToList();
            string concat = String.Join("", a);
            int Age = DateTime.Now.Year - Convert.ToInt32(concat);
            if (MenRadioButton.Checked)
            {
                double PPM = 66.47 + 13.75 * Convert.ToInt32(WeightOfPersonTXT.Text) +
                    (5 * Convert.ToDouble(heighOfPersonTXT.Text) * 100 - (6.75 * Age));
                PPMLBL.Text = "PPM: " + Convert.ToString(Math.Round(PPM, 3));
            }
            else if(WomenRadioButton.Checked)
            {
                double PPM = 665.09 + 9.56 * Convert.ToInt32(WeightOfPersonTXT.Text) +
                    (1.85 * Convert.ToDouble(heighOfPersonTXT.Text) * 100 - (4.67 * Age));
                PPMLBL.Text = "PPM: " + Convert.ToString(Math.Round(PPM, 3));
            }
            else
            {
                MessageBox.Show("Wybierz płeć");
                return;
            }
            double BMI = Convert.ToDouble(WeightOfPersonTXT.Text) / Convert.ToDouble(Math.Pow(Convert.ToDouble(heighOfPersonTXT.Text), 2));
            BMILBL.Text = "BMI: " + Convert.ToString(Math.Round(BMI, 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void heighOfPersonTXT_Validating(object sender, CancelEventArgs e)
        {
            if (!heighOfPersonTXT.Text.Contains(","))
            {
                e.Cancel = true;
                errorProvider1.SetError(heighOfPersonTXT, "Nieodpowiedni format - musi być przecinek");
            }
            else
            {
                errorProvider1.SetError(heighOfPersonTXT, "");
            }
        }

      
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            allowedFoodRichTextBox.Text = String.Empty;
            notAllowedFoodRichTextBox.Text = String.Empty;
            try
            {
                foreach (string line in allowedFood)
                {
                    string[] tokens = line.Split(',');
                    if (DiseasesRichTextBox.Text.Contains(tokens[0]))
                    {
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            if (allowedFoodRichTextBox.Text.Contains(tokens[i]))
                                continue;
                            allowedFoodRichTextBox.AppendText(tokens[i] + "\n");
                        }
                    }
                }

                foreach (string line in notAllowedFood)
                {
                    string[] tokens = line.Split(',');
                    if (DiseasesRichTextBox.Text.Contains(tokens[0]))
                    {
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            if (notAllowedFoodRichTextBox.Text.Contains(tokens[i]))
                                continue;
                            notAllowedFoodRichTextBox.AppendText(tokens[i] + "\n");
                        }
                    }
                }
            }
            catch { }
        }
    }   
}
