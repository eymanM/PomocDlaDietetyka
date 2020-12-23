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
            diseasesComboBox.Items.Add("dfwsde");
            diseasesComboBox.Items.Add("dfw");
            diseasesComboBox.Items.Add("dfwsdfsdfse");
            string filename = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(filename))
                App.DataOfPersons.ReadXml(filename);
            dataOfPersonsBindingSource.DataSource = App.DataOfPersons;
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
            DiseasesRichTextBox.AppendText(diseasesComboBox.SelectedItem.ToString() + "\n");
        }

        private void CalculateBmiPpmBTN_Click(object sender, EventArgs e)
        {
            if(MenRadioButton.Checked)
            {

            }
            if(WomenRadioButton.Checked)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }   
}
