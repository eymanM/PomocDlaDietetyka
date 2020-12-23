
namespace PomocDlaDietetyka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.AddPatientTab = new System.Windows.Forms.TabPage();
            this.Diseases = new System.Windows.Forms.RichTextBox();
            this.dataOfPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet = new PomocDlaDietetyka.AppDataSet();
            this.EditEntriesBTN = new System.Windows.Forms.Button();
            this.SaveEntriesBTN = new System.Windows.Forms.Button();
            this.NewEntriesBTN = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addDiseaseBTN = new System.Windows.Forms.Button();
            this.describeOfPersonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diseasesComboBox = new System.Windows.Forms.ComboBox();
            this.SurnameOfPersonTXT = new System.Windows.Forms.TextBox();
            this.dateOfBirthTXT = new System.Windows.Forms.TextBox();
            this.heighOfPersonTXT = new System.Windows.Forms.TextBox();
            this.WeightOfPersonTXT = new System.Windows.Forms.TextBox();
            this.NameOfPersonTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateBMITab = new System.Windows.Forms.TabPage();
            this.PPMLBL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BMILBL = new System.Windows.Forms.Label();
            this.recomendedDietLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.TabPage();
            this.amountOfCaloriesLBL = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.deleteFromBracketBTN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addFoodToBrackedBTN = new System.Windows.Forms.Button();
            this.WeighOfFoodTXT = new System.Windows.Forms.TextBox();
            this.bracketComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.notAllowedFoodRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.allowedFoodRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ExampleDishes = new System.Windows.Forms.TabPage();
            this.dataOfPersonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describesOfPersonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage.SuspendLayout();
            this.AddPatientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.CalculateBMITab.SuspendLayout();
            this.Food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfPersonsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabPage.Controls.Add(this.AddPatientTab);
            this.tabPage.Controls.Add(this.CalculateBMITab);
            this.tabPage.Controls.Add(this.Food);
            this.tabPage.Controls.Add(this.ExampleDishes);
            this.tabPage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.ItemSize = new System.Drawing.Size(140, 36);
            this.tabPage.Location = new System.Drawing.Point(12, 1);
            this.tabPage.Multiline = true;
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(574, 476);
            this.tabPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPage.TabIndex = 0;
            // 
            // AddPatientTab
            // 
            this.AddPatientTab.Controls.Add(this.Diseases);
            this.AddPatientTab.Controls.Add(this.EditEntriesBTN);
            this.AddPatientTab.Controls.Add(this.SaveEntriesBTN);
            this.AddPatientTab.Controls.Add(this.NewEntriesBTN);
            this.AddPatientTab.Controls.Add(this.dataGridView);
            this.AddPatientTab.Controls.Add(this.addDiseaseBTN);
            this.AddPatientTab.Controls.Add(this.describeOfPersonRichTextBox);
            this.AddPatientTab.Controls.Add(this.label7);
            this.AddPatientTab.Controls.Add(this.diseasesComboBox);
            this.AddPatientTab.Controls.Add(this.SurnameOfPersonTXT);
            this.AddPatientTab.Controls.Add(this.dateOfBirthTXT);
            this.AddPatientTab.Controls.Add(this.heighOfPersonTXT);
            this.AddPatientTab.Controls.Add(this.WeightOfPersonTXT);
            this.AddPatientTab.Controls.Add(this.NameOfPersonTXT);
            this.AddPatientTab.Controls.Add(this.label6);
            this.AddPatientTab.Controls.Add(this.label5);
            this.AddPatientTab.Controls.Add(this.label4);
            this.AddPatientTab.Controls.Add(this.label3);
            this.AddPatientTab.Controls.Add(this.label2);
            this.AddPatientTab.Controls.Add(this.label1);
            this.AddPatientTab.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientTab.Location = new System.Drawing.Point(4, 40);
            this.AddPatientTab.Name = "AddPatientTab";
            this.AddPatientTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddPatientTab.Size = new System.Drawing.Size(566, 432);
            this.AddPatientTab.TabIndex = 0;
            this.AddPatientTab.Text = "Dodaj Pacjenta";
            this.AddPatientTab.UseVisualStyleBackColor = true;
            this.AddPatientTab.Click += new System.EventHandler(this.AddPatientTab_Click);
            // 
            // Diseases
            // 
            this.Diseases.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "Diseases", true));
            this.Diseases.Location = new System.Drawing.Point(6, 224);
            this.Diseases.Name = "Diseases";
            this.Diseases.Size = new System.Drawing.Size(198, 164);
            this.Diseases.TabIndex = 26;
            this.Diseases.Text = "";
            // 
            // dataOfPersonsBindingSource
            // 
            this.dataOfPersonsBindingSource.DataMember = "DataOfPersons";
            this.dataOfPersonsBindingSource.DataSource = this.appDataSet;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "AppDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditEntriesBTN
            // 
            this.EditEntriesBTN.Location = new System.Drawing.Point(356, 394);
            this.EditEntriesBTN.Name = "EditEntriesBTN";
            this.EditEntriesBTN.Size = new System.Drawing.Size(75, 32);
            this.EditEntriesBTN.TabIndex = 25;
            this.EditEntriesBTN.Text = "Edytuj";
            this.EditEntriesBTN.UseVisualStyleBackColor = true;
            this.EditEntriesBTN.Click += new System.EventHandler(this.EditEntriesBTN_Click);
            // 
            // SaveEntriesBTN
            // 
            this.SaveEntriesBTN.Location = new System.Drawing.Point(482, 394);
            this.SaveEntriesBTN.Name = "SaveEntriesBTN";
            this.SaveEntriesBTN.Size = new System.Drawing.Size(75, 32);
            this.SaveEntriesBTN.TabIndex = 23;
            this.SaveEntriesBTN.Text = "Zapisz";
            this.SaveEntriesBTN.UseVisualStyleBackColor = true;
            this.SaveEntriesBTN.Click += new System.EventHandler(this.SaveEntriesBTN_Click);
            // 
            // NewEntriesBTN
            // 
            this.NewEntriesBTN.Location = new System.Drawing.Point(216, 394);
            this.NewEntriesBTN.Name = "NewEntriesBTN";
            this.NewEntriesBTN.Size = new System.Drawing.Size(75, 32);
            this.NewEntriesBTN.TabIndex = 22;
            this.NewEntriesBTN.Text = "Nowy";
            this.NewEntriesBTN.UseVisualStyleBackColor = true;
            this.NewEntriesBTN.Click += new System.EventHandler(this.NewEntriesBTN_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.surnameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.diseasesDataGridViewTextBoxColumn,
            this.describesOfPersonsDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dataOfPersonsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(216, 224);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(344, 164);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // addDiseaseBTN
            // 
            this.addDiseaseBTN.Location = new System.Drawing.Point(171, 169);
            this.addDiseaseBTN.Name = "addDiseaseBTN";
            this.addDiseaseBTN.Size = new System.Drawing.Size(123, 29);
            this.addDiseaseBTN.TabIndex = 18;
            this.addDiseaseBTN.Text = "Dodaj Chorobę";
            this.addDiseaseBTN.UseVisualStyleBackColor = true;
            // 
            // describeOfPersonRichTextBox
            // 
            this.describeOfPersonRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "DescribesOfPersons", true));
            this.describeOfPersonRichTextBox.Location = new System.Drawing.Point(330, 52);
            this.describeOfPersonRichTextBox.Name = "describeOfPersonRichTextBox";
            this.describeOfPersonRichTextBox.Size = new System.Drawing.Size(227, 146);
            this.describeOfPersonRichTextBox.TabIndex = 15;
            this.describeOfPersonRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Opis Pacjenta i jego Chorób";
            // 
            // diseasesComboBox
            // 
            this.diseasesComboBox.FormattingEnabled = true;
            this.diseasesComboBox.Location = new System.Drawing.Point(0, 169);
            this.diseasesComboBox.Name = "diseasesComboBox";
            this.diseasesComboBox.Size = new System.Drawing.Size(165, 28);
            this.diseasesComboBox.TabIndex = 13;
            // 
            // SurnameOfPersonTXT
            // 
            this.SurnameOfPersonTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "Surname", true));
            this.SurnameOfPersonTXT.Location = new System.Drawing.Point(0, 41);
            this.SurnameOfPersonTXT.Name = "SurnameOfPersonTXT";
            this.SurnameOfPersonTXT.Size = new System.Drawing.Size(106, 27);
            this.SurnameOfPersonTXT.TabIndex = 12;
            // 
            // dateOfBirthTXT
            // 
            this.dateOfBirthTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "DateOfBirth", true));
            this.dateOfBirthTXT.Location = new System.Drawing.Point(0, 72);
            this.dateOfBirthTXT.Name = "dateOfBirthTXT";
            this.dateOfBirthTXT.Size = new System.Drawing.Size(106, 27);
            this.dateOfBirthTXT.TabIndex = 11;
            // 
            // heighOfPersonTXT
            // 
            this.heighOfPersonTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "Height", true));
            this.heighOfPersonTXT.Location = new System.Drawing.Point(0, 103);
            this.heighOfPersonTXT.Name = "heighOfPersonTXT";
            this.heighOfPersonTXT.Size = new System.Drawing.Size(106, 27);
            this.heighOfPersonTXT.TabIndex = 10;
            // 
            // WeightOfPersonTXT
            // 
            this.WeightOfPersonTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "Weight", true));
            this.WeightOfPersonTXT.Location = new System.Drawing.Point(0, 134);
            this.WeightOfPersonTXT.Name = "WeightOfPersonTXT";
            this.WeightOfPersonTXT.Size = new System.Drawing.Size(106, 27);
            this.WeightOfPersonTXT.TabIndex = 9;
            // 
            // NameOfPersonTXT
            // 
            this.NameOfPersonTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataOfPersonsBindingSource, "Name", true));
            this.NameOfPersonTXT.Location = new System.Drawing.Point(0, 10);
            this.NameOfPersonTXT.Name = "NameOfPersonTXT";
            this.NameOfPersonTXT.Size = new System.Drawing.Size(106, 27);
            this.NameOfPersonTXT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Wzrost(cm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Waga(kg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data urodzenia(rrrr-mm-dd)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Pacjentów";
            // 
            // CalculateBMITab
            // 
            this.CalculateBMITab.Controls.Add(this.PPMLBL);
            this.CalculateBMITab.Controls.Add(this.label12);
            this.CalculateBMITab.Controls.Add(this.BMILBL);
            this.CalculateBMITab.Controls.Add(this.recomendedDietLBL);
            this.CalculateBMITab.Controls.Add(this.label8);
            this.CalculateBMITab.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMITab.Location = new System.Drawing.Point(4, 40);
            this.CalculateBMITab.Name = "CalculateBMITab";
            this.CalculateBMITab.Padding = new System.Windows.Forms.Padding(3);
            this.CalculateBMITab.Size = new System.Drawing.Size(566, 432);
            this.CalculateBMITab.TabIndex = 1;
            this.CalculateBMITab.Text = "Oblicz BMI, PPM";
            this.CalculateBMITab.UseVisualStyleBackColor = true;
            // 
            // PPMLBL
            // 
            this.PPMLBL.AutoSize = true;
            this.PPMLBL.Location = new System.Drawing.Point(498, 22);
            this.PPMLBL.Name = "PPMLBL";
            this.PPMLBL.Size = new System.Drawing.Size(46, 20);
            this.PPMLBL.TabIndex = 22;
            this.PPMLBL.Text = "PPM:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(631, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "label12";
            // 
            // BMILBL
            // 
            this.BMILBL.AutoSize = true;
            this.BMILBL.Location = new System.Drawing.Point(6, 22);
            this.BMILBL.Name = "BMILBL";
            this.BMILBL.Size = new System.Drawing.Size(41, 20);
            this.BMILBL.TabIndex = 20;
            this.BMILBL.Text = "BMI:";
            // 
            // recomendedDietLBL
            // 
            this.recomendedDietLBL.AutoSize = true;
            this.recomendedDietLBL.Location = new System.Drawing.Point(251, 263);
            this.recomendedDietLBL.Name = "recomendedDietLBL";
            this.recomendedDietLBL.Size = new System.Drawing.Size(53, 20);
            this.recomendedDietLBL.TabIndex = 19;
            this.recomendedDietLBL.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Zalecana Dieta:";
            // 
            // Food
            // 
            this.Food.Controls.Add(this.amountOfCaloriesLBL);
            this.Food.Controls.Add(this.label15);
            this.Food.Controls.Add(this.deleteFromBracketBTN);
            this.Food.Controls.Add(this.listBox1);
            this.Food.Controls.Add(this.addFoodToBrackedBTN);
            this.Food.Controls.Add(this.WeighOfFoodTXT);
            this.Food.Controls.Add(this.bracketComboBox);
            this.Food.Controls.Add(this.label16);
            this.Food.Controls.Add(this.notAllowedFoodRichTextBox);
            this.Food.Controls.Add(this.label14);
            this.Food.Controls.Add(this.label13);
            this.Food.Controls.Add(this.allowedFoodRichTextBox);
            this.Food.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.Location = new System.Drawing.Point(4, 40);
            this.Food.Name = "Food";
            this.Food.Padding = new System.Windows.Forms.Padding(3);
            this.Food.Size = new System.Drawing.Size(566, 432);
            this.Food.TabIndex = 2;
            this.Food.Text = "Żywność";
            this.Food.UseVisualStyleBackColor = true;
            // 
            // amountOfCaloriesLBL
            // 
            this.amountOfCaloriesLBL.AutoSize = true;
            this.amountOfCaloriesLBL.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOfCaloriesLBL.Location = new System.Drawing.Point(442, 201);
            this.amountOfCaloriesLBL.Name = "amountOfCaloriesLBL";
            this.amountOfCaloriesLBL.Size = new System.Drawing.Size(26, 26);
            this.amountOfCaloriesLBL.TabIndex = 13;
            this.amountOfCaloriesLBL.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(438, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Ilość kalorii:";
            // 
            // deleteFromBracketBTN
            // 
            this.deleteFromBracketBTN.Location = new System.Drawing.Point(439, 108);
            this.deleteFromBracketBTN.Name = "deleteFromBracketBTN";
            this.deleteFromBracketBTN.Size = new System.Drawing.Size(121, 29);
            this.deleteFromBracketBTN.TabIndex = 11;
            this.deleteFromBracketBTN.Text = "Usuń element";
            this.deleteFromBracketBTN.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(312, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 284);
            this.listBox1.TabIndex = 10;
            // 
            // addFoodToBrackedBTN
            // 
            this.addFoodToBrackedBTN.Location = new System.Drawing.Point(439, 65);
            this.addFoodToBrackedBTN.Name = "addFoodToBrackedBTN";
            this.addFoodToBrackedBTN.Size = new System.Drawing.Size(121, 27);
            this.addFoodToBrackedBTN.TabIndex = 8;
            this.addFoodToBrackedBTN.Text = "Dodaj";
            this.addFoodToBrackedBTN.UseVisualStyleBackColor = true;
            // 
            // WeighOfFoodTXT
            // 
            this.WeighOfFoodTXT.Location = new System.Drawing.Point(312, 83);
            this.WeighOfFoodTXT.Name = "WeighOfFoodTXT";
            this.WeighOfFoodTXT.Size = new System.Drawing.Size(120, 27);
            this.WeighOfFoodTXT.TabIndex = 7;
            // 
            // bracketComboBox
            // 
            this.bracketComboBox.FormattingEnabled = true;
            this.bracketComboBox.Location = new System.Drawing.Point(312, 30);
            this.bracketComboBox.Name = "bracketComboBox";
            this.bracketComboBox.Size = new System.Drawing.Size(248, 28);
            this.bracketComboBox.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(355, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Koszyk(dodaj produkty)";
            // 
            // notAllowedFoodRichTextBox
            // 
            this.notAllowedFoodRichTextBox.Location = new System.Drawing.Point(149, 30);
            this.notAllowedFoodRichTextBox.Name = "notAllowedFoodRichTextBox";
            this.notAllowedFoodRichTextBox.Size = new System.Drawing.Size(157, 396);
            this.notAllowedFoodRichTextBox.TabIndex = 3;
            this.notAllowedFoodRichTextBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(149, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Zabroniona żywność";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Zalecana żywność";
            // 
            // allowedFoodRichTextBox
            // 
            this.allowedFoodRichTextBox.Location = new System.Drawing.Point(3, 30);
            this.allowedFoodRichTextBox.Name = "allowedFoodRichTextBox";
            this.allowedFoodRichTextBox.Size = new System.Drawing.Size(140, 396);
            this.allowedFoodRichTextBox.TabIndex = 0;
            this.allowedFoodRichTextBox.Text = "";
            // 
            // ExampleDishes
            // 
            this.ExampleDishes.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleDishes.Location = new System.Drawing.Point(4, 40);
            this.ExampleDishes.Name = "ExampleDishes";
            this.ExampleDishes.Padding = new System.Windows.Forms.Padding(3);
            this.ExampleDishes.Size = new System.Drawing.Size(566, 432);
            this.ExampleDishes.TabIndex = 4;
            this.ExampleDishes.Text = "Przykładowe Dania";
            this.ExampleDishes.UseVisualStyleBackColor = true;
            // 
            // dataOfPersonsBindingSource1
            // 
            this.dataOfPersonsBindingSource1.DataMember = "DataOfPersons";
            this.dataOfPersonsBindingSource1.DataSource = this.appDataSet;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Visible = false;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Visible = false;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Visible = false;
            // 
            // diseasesDataGridViewTextBoxColumn
            // 
            this.diseasesDataGridViewTextBoxColumn.DataPropertyName = "Diseases";
            this.diseasesDataGridViewTextBoxColumn.HeaderText = "Diseases";
            this.diseasesDataGridViewTextBoxColumn.Name = "diseasesDataGridViewTextBoxColumn";
            this.diseasesDataGridViewTextBoxColumn.Visible = false;
            // 
            // describesOfPersonsDataGridViewTextBoxColumn
            // 
            this.describesOfPersonsDataGridViewTextBoxColumn.DataPropertyName = "DescribesOfPersons";
            this.describesOfPersonsDataGridViewTextBoxColumn.HeaderText = "DescribesOfPersons";
            this.describesOfPersonsDataGridViewTextBoxColumn.Name = "describesOfPersonsDataGridViewTextBoxColumn";
            this.describesOfPersonsDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 480);
            this.Controls.Add(this.tabPage);
            this.Name = "Form1";
            this.Text = "                                                                   Pomoc dla Diet" +
    "etyka";
            this.tabPage.ResumeLayout(false);
            this.AddPatientTab.ResumeLayout(false);
            this.AddPatientTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.CalculateBMITab.ResumeLayout(false);
            this.CalculateBMITab.PerformLayout();
            this.Food.ResumeLayout(false);
            this.Food.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfPersonsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage CalculateBMITab;
        private System.Windows.Forms.TabPage ExampleDishes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDiseaseBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label BMILBL;
        private System.Windows.Forms.Label recomendedDietLBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage Food;
        private System.Windows.Forms.Label PPMLBL;
        private System.Windows.Forms.RichTextBox allowedFoodRichTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addFoodToBrackedBTN;
        private System.Windows.Forms.TextBox WeighOfFoodTXT;
        private System.Windows.Forms.ComboBox bracketComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox notAllowedFoodRichTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label amountOfCaloriesLBL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button deleteFromBracketBTN;
        protected System.Windows.Forms.ComboBox diseasesComboBox;
        protected System.Windows.Forms.TabPage AddPatientTab;
        public System.Windows.Forms.TextBox NameOfPersonTXT;
        public System.Windows.Forms.TextBox SurnameOfPersonTXT;
        public System.Windows.Forms.RichTextBox describeOfPersonRichTextBox;
        public System.Windows.Forms.TextBox dateOfBirthTXT;
        public System.Windows.Forms.TextBox heighOfPersonTXT;
        public System.Windows.Forms.TextBox WeightOfPersonTXT;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dataOfPersonsBindingSource;
        private AppDataSet appDataSet;
        private System.Windows.Forms.BindingSource dataOfPersonsBindingSource1;
        private System.Windows.Forms.RichTextBox Diseases;
        private System.Windows.Forms.Button EditEntriesBTN;
        private System.Windows.Forms.Button SaveEntriesBTN;
        private System.Windows.Forms.Button NewEntriesBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn describesOfPersonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

