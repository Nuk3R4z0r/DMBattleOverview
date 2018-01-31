namespace DMBattleOverview
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
            this.btnPlayerInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnMonInsert = new System.Windows.Forms.Button();
            this.playerBoxes = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tCharacterBox8 = new System.Windows.Forms.TextBox();
            this.tCharacterBox7 = new System.Windows.Forms.TextBox();
            this.tCharacterBox6 = new System.Windows.Forms.TextBox();
            this.tCharacterBox5 = new System.Windows.Forms.TextBox();
            this.tCharacterBox4 = new System.Windows.Forms.TextBox();
            this.tCharacterBox3 = new System.Windows.Forms.TextBox();
            this.tCharacterBox2 = new System.Windows.Forms.TextBox();
            this.tCharacterBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tCharacterIniBox8 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox7 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox6 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox5 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox4 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox3 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox2 = new System.Windows.Forms.TextBox();
            this.tCharacterIniBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lDataBox = new System.Windows.Forms.ListView();
            this.cInitiative = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHealth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tInsertNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tUpdateNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cUpdateGender = new System.Windows.Forms.ComboBox();
            this.cInsertGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tIniModBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tUpdateIni = new System.Windows.Forms.TextBox();
            this.tUpdateHealth = new System.Windows.Forms.TextBox();
            this.tUpdateName = new System.Windows.Forms.TextBox();
            this.tInsertHealthBox = new System.Windows.Forms.TextBox();
            this.cNameBox = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cNumberBox = new System.Windows.Forms.CheckBox();
            this.cRollBox = new System.Windows.Forms.CheckBox();
            this.playerBoxes.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayerInsert
            // 
            this.btnPlayerInsert.Location = new System.Drawing.Point(234, 326);
            this.btnPlayerInsert.Name = "btnPlayerInsert";
            this.btnPlayerInsert.Size = new System.Drawing.Size(95, 23);
            this.btnPlayerInsert.TabIndex = 0;
            this.btnPlayerInsert.Text = "Insert";
            this.btnPlayerInsert.UseVisualStyleBackColor = true;
            this.btnPlayerInsert.Click += new System.EventHandler(this.btnPlayerInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Green;
            this.btnUpdate.Location = new System.Drawing.Point(410, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnMonInsert
            // 
            this.btnMonInsert.ForeColor = System.Drawing.Color.Green;
            this.btnMonInsert.Location = new System.Drawing.Point(410, 30);
            this.btnMonInsert.Name = "btnMonInsert";
            this.btnMonInsert.Size = new System.Drawing.Size(75, 23);
            this.btnMonInsert.TabIndex = 2;
            this.btnMonInsert.Text = "Insert";
            this.btnMonInsert.UseVisualStyleBackColor = true;
            this.btnMonInsert.Click += new System.EventHandler(this.bMonInsert_Click);
            // 
            // playerBoxes
            // 
            this.playerBoxes.Controls.Add(this.groupBox4);
            this.playerBoxes.Controls.Add(this.groupBox3);
            this.playerBoxes.Controls.Add(this.btnPlayerInsert);
            this.playerBoxes.Location = new System.Drawing.Point(509, 12);
            this.playerBoxes.Name = "playerBoxes";
            this.playerBoxes.Size = new System.Drawing.Size(335, 358);
            this.playerBoxes.TabIndex = 3;
            this.playerBoxes.TabStop = false;
            this.playerBoxes.Text = "Players";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tCharacterBox8);
            this.groupBox4.Controls.Add(this.tCharacterBox7);
            this.groupBox4.Controls.Add(this.tCharacterBox6);
            this.groupBox4.Controls.Add(this.tCharacterBox5);
            this.groupBox4.Controls.Add(this.tCharacterBox4);
            this.groupBox4.Controls.Add(this.tCharacterBox3);
            this.groupBox4.Controls.Add(this.tCharacterBox2);
            this.groupBox4.Controls.Add(this.tCharacterBox1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 301);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Character Name";
            // 
            // tCharacterBox8
            // 
            this.tCharacterBox8.Location = new System.Drawing.Point(49, 201);
            this.tCharacterBox8.Name = "tCharacterBox8";
            this.tCharacterBox8.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox8.TabIndex = 8;
            // 
            // tCharacterBox7
            // 
            this.tCharacterBox7.Location = new System.Drawing.Point(49, 175);
            this.tCharacterBox7.Name = "tCharacterBox7";
            this.tCharacterBox7.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox7.TabIndex = 7;
            // 
            // tCharacterBox6
            // 
            this.tCharacterBox6.Location = new System.Drawing.Point(49, 149);
            this.tCharacterBox6.Name = "tCharacterBox6";
            this.tCharacterBox6.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox6.TabIndex = 6;
            // 
            // tCharacterBox5
            // 
            this.tCharacterBox5.Location = new System.Drawing.Point(49, 123);
            this.tCharacterBox5.Name = "tCharacterBox5";
            this.tCharacterBox5.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox5.TabIndex = 5;
            // 
            // tCharacterBox4
            // 
            this.tCharacterBox4.Location = new System.Drawing.Point(49, 97);
            this.tCharacterBox4.Name = "tCharacterBox4";
            this.tCharacterBox4.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox4.TabIndex = 4;
            // 
            // tCharacterBox3
            // 
            this.tCharacterBox3.Location = new System.Drawing.Point(49, 71);
            this.tCharacterBox3.Name = "tCharacterBox3";
            this.tCharacterBox3.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox3.TabIndex = 3;
            // 
            // tCharacterBox2
            // 
            this.tCharacterBox2.Location = new System.Drawing.Point(49, 45);
            this.tCharacterBox2.Name = "tCharacterBox2";
            this.tCharacterBox2.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox2.TabIndex = 2;
            // 
            // tCharacterBox1
            // 
            this.tCharacterBox1.Location = new System.Drawing.Point(49, 19);
            this.tCharacterBox1.Name = "tCharacterBox1";
            this.tCharacterBox1.Size = new System.Drawing.Size(100, 20);
            this.tCharacterBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tCharacterIniBox8);
            this.groupBox3.Controls.Add(this.tCharacterIniBox7);
            this.groupBox3.Controls.Add(this.tCharacterIniBox6);
            this.groupBox3.Controls.Add(this.tCharacterIniBox5);
            this.groupBox3.Controls.Add(this.tCharacterIniBox4);
            this.groupBox3.Controls.Add(this.tCharacterIniBox3);
            this.groupBox3.Controls.Add(this.tCharacterIniBox2);
            this.groupBox3.Controls.Add(this.tCharacterIniBox1);
            this.groupBox3.Location = new System.Drawing.Point(167, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 301);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Initiative";
            // 
            // tCharacterIniBox8
            // 
            this.tCharacterIniBox8.Location = new System.Drawing.Point(6, 201);
            this.tCharacterIniBox8.Name = "tCharacterIniBox8";
            this.tCharacterIniBox8.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox8.TabIndex = 9;
            // 
            // tCharacterIniBox7
            // 
            this.tCharacterIniBox7.Location = new System.Drawing.Point(6, 175);
            this.tCharacterIniBox7.Name = "tCharacterIniBox7";
            this.tCharacterIniBox7.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox7.TabIndex = 8;
            // 
            // tCharacterIniBox6
            // 
            this.tCharacterIniBox6.Location = new System.Drawing.Point(6, 149);
            this.tCharacterIniBox6.Name = "tCharacterIniBox6";
            this.tCharacterIniBox6.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox6.TabIndex = 6;
            // 
            // tCharacterIniBox5
            // 
            this.tCharacterIniBox5.Location = new System.Drawing.Point(6, 123);
            this.tCharacterIniBox5.Name = "tCharacterIniBox5";
            this.tCharacterIniBox5.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox5.TabIndex = 5;
            // 
            // tCharacterIniBox4
            // 
            this.tCharacterIniBox4.Location = new System.Drawing.Point(6, 97);
            this.tCharacterIniBox4.Name = "tCharacterIniBox4";
            this.tCharacterIniBox4.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox4.TabIndex = 4;
            // 
            // tCharacterIniBox3
            // 
            this.tCharacterIniBox3.Location = new System.Drawing.Point(6, 71);
            this.tCharacterIniBox3.Name = "tCharacterIniBox3";
            this.tCharacterIniBox3.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox3.TabIndex = 3;
            // 
            // tCharacterIniBox2
            // 
            this.tCharacterIniBox2.Location = new System.Drawing.Point(6, 45);
            this.tCharacterIniBox2.Name = "tCharacterIniBox2";
            this.tCharacterIniBox2.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox2.TabIndex = 2;
            // 
            // tCharacterIniBox1
            // 
            this.tCharacterIniBox1.Location = new System.Drawing.Point(6, 19);
            this.tCharacterIniBox1.Name = "tCharacterIniBox1";
            this.tCharacterIniBox1.Size = new System.Drawing.Size(100, 20);
            this.tCharacterIniBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lDataBox);
            this.groupBox2.Controls.Add(this.tInsertNumber);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tUpdateNumber);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.cUpdateGender);
            this.groupBox2.Controls.Add(this.cInsertGender);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tIniModBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tUpdateIni);
            this.groupBox2.Controls.Add(this.tUpdateHealth);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.tUpdateName);
            this.groupBox2.Controls.Add(this.tInsertHealthBox);
            this.groupBox2.Controls.Add(this.cNameBox);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Controls.Add(this.btnMonInsert);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 402);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monsters";
            // 
            // lDataBox
            // 
            this.lDataBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cInitiative,
            this.cNumber,
            this.cName,
            this.cHealth,
            this.cGender});
            this.lDataBox.Location = new System.Drawing.Point(6, 58);
            this.lDataBox.Name = "lDataBox";
            this.lDataBox.Size = new System.Drawing.Size(398, 291);
            this.lDataBox.TabIndex = 7;
            this.lDataBox.UseCompatibleStateImageBehavior = false;
            this.lDataBox.SelectedIndexChanged += new System.EventHandler(this.lDataBox_SelectedIndexChanged);
            // 
            // cInitiative
            // 
            this.cInitiative.Text = "Initiative";
            // 
            // cNumber
            // 
            this.cNumber.Text = "Number";
            // 
            // cName
            // 
            this.cName.Text = "Name";
            // 
            // cHealth
            // 
            this.cHealth.Text = "Health";
            // 
            // cGender
            // 
            this.cGender.Text = "Gender";
            // 
            // tInsertNumber
            // 
            this.tInsertNumber.Location = new System.Drawing.Point(113, 32);
            this.tInsertNumber.Name = "tInsertNumber";
            this.tInsertNumber.Size = new System.Drawing.Size(60, 20);
            this.tInsertNumber.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Number";
            // 
            // tUpdateNumber
            // 
            this.tUpdateNumber.Location = new System.Drawing.Point(113, 371);
            this.tUpdateNumber.Name = "tUpdateNumber";
            this.tUpdateNumber.Size = new System.Drawing.Size(60, 20);
            this.tUpdateNumber.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(409, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cUpdateGender
            // 
            this.cUpdateGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Unknown",
            "None"});
            this.cUpdateGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cUpdateGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cUpdateGender.FormattingEnabled = true;
            this.cUpdateGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown",
            "Random",
            "None"});
            this.cUpdateGender.Location = new System.Drawing.Point(324, 371);
            this.cUpdateGender.Name = "cUpdateGender";
            this.cUpdateGender.Size = new System.Drawing.Size(79, 21);
            this.cUpdateGender.TabIndex = 17;
            // 
            // cInsertGender
            // 
            this.cInsertGender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Unknown",
            "Random"});
            this.cInsertGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cInsertGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cInsertGender.FormattingEnabled = true;
            this.cInsertGender.Items.AddRange(new object[] {
            "Unknown",
            "Random",
            "Male",
            "Female"});
            this.cInsertGender.Location = new System.Drawing.Point(325, 32);
            this.cInsertGender.Name = "cInsertGender";
            this.cInsertGender.Size = new System.Drawing.Size(79, 21);
            this.cInsertGender.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Initiative modifier";
            // 
            // tIniModBox
            // 
            this.tIniModBox.Location = new System.Drawing.Point(239, 32);
            this.tIniModBox.Name = "tIniModBox";
            this.tIniModBox.Size = new System.Drawing.Size(80, 20);
            this.tIniModBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Initiative";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // tUpdateIni
            // 
            this.tUpdateIni.Location = new System.Drawing.Point(239, 371);
            this.tUpdateIni.Name = "tUpdateIni";
            this.tUpdateIni.Size = new System.Drawing.Size(80, 20);
            this.tUpdateIni.TabIndex = 8;
            // 
            // tUpdateHealth
            // 
            this.tUpdateHealth.Location = new System.Drawing.Point(179, 371);
            this.tUpdateHealth.Name = "tUpdateHealth";
            this.tUpdateHealth.Size = new System.Drawing.Size(55, 20);
            this.tUpdateHealth.TabIndex = 7;
            // 
            // tUpdateName
            // 
            this.tUpdateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tUpdateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tUpdateName.Location = new System.Drawing.Point(7, 371);
            this.tUpdateName.Name = "tUpdateName";
            this.tUpdateName.Size = new System.Drawing.Size(100, 20);
            this.tUpdateName.TabIndex = 6;
            // 
            // tInsertHealthBox
            // 
            this.tInsertHealthBox.Location = new System.Drawing.Point(179, 32);
            this.tInsertHealthBox.Name = "tInsertHealthBox";
            this.tInsertHealthBox.Size = new System.Drawing.Size(55, 20);
            this.tInsertHealthBox.TabIndex = 5;
            // 
            // cNameBox
            // 
            this.cNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cNameBox.FormattingEnabled = true;
            this.cNameBox.Location = new System.Drawing.Point(6, 32);
            this.cNameBox.Name = "cNameBox";
            this.cNameBox.Size = new System.Drawing.Size(101, 21);
            this.cNameBox.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(410, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPrev.Location = new System.Drawing.Point(410, 134);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Prev turn";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.Green;
            this.btnNext.Location = new System.Drawing.Point(410, 105);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next turn";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.Location = new System.Drawing.Point(12, 452);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(351, 37);
            this.lblCurrentTurn.TabIndex = 5;
            this.lblCurrentTurn.Text = "Click next turn to begin!";
            this.lblCurrentTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cNumberBox);
            this.groupBox5.Controls.Add(this.cRollBox);
            this.groupBox5.Location = new System.Drawing.Point(509, 376);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 149);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Options";
            // 
            // cNumberBox
            // 
            this.cNumberBox.AutoSize = true;
            this.cNumberBox.Location = new System.Drawing.Point(7, 44);
            this.cNumberBox.Name = "cNumberBox";
            this.cNumberBox.Size = new System.Drawing.Size(146, 17);
            this.cNumberBox.TabIndex = 1;
            this.cNumberBox.Text = "Auto enumerate monsters";
            this.cNumberBox.UseVisualStyleBackColor = true;
            // 
            // cRollBox
            // 
            this.cRollBox.AutoSize = true;
            this.cRollBox.Location = new System.Drawing.Point(7, 20);
            this.cRollBox.Name = "cRollBox";
            this.cRollBox.Size = new System.Drawing.Size(145, 17);
            this.cRollBox.TabIndex = 0;
            this.cRollBox.Text = "Auto roll monster initiative";
            this.cRollBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 537);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblCurrentTurn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.playerBoxes);
            this.Name = "Form1";
            this.Text = "DMBattleOverview";
            this.playerBoxes.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayerInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnMonInsert;
        private System.Windows.Forms.GroupBox playerBoxes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tCharacterBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tCharacterIniBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tUpdateIni;
        private System.Windows.Forms.TextBox tUpdateHealth;
        private System.Windows.Forms.TextBox tUpdateName;
        private System.Windows.Forms.TextBox tInsertHealthBox;
        private System.Windows.Forms.ComboBox cNameBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tCharacterBox8;
        private System.Windows.Forms.TextBox tCharacterBox7;
        private System.Windows.Forms.TextBox tCharacterBox6;
        private System.Windows.Forms.TextBox tCharacterBox5;
        private System.Windows.Forms.TextBox tCharacterBox4;
        private System.Windows.Forms.TextBox tCharacterBox3;
        private System.Windows.Forms.TextBox tCharacterBox2;
        private System.Windows.Forms.TextBox tCharacterIniBox8;
        private System.Windows.Forms.TextBox tCharacterIniBox7;
        private System.Windows.Forms.TextBox tCharacterIniBox6;
        private System.Windows.Forms.TextBox tCharacterIniBox5;
        private System.Windows.Forms.TextBox tCharacterIniBox4;
        private System.Windows.Forms.TextBox tCharacterIniBox3;
        private System.Windows.Forms.TextBox tCharacterIniBox2;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.TextBox tIniModBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cInsertGender;
        private System.Windows.Forms.ComboBox cUpdateGender;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tInsertNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tUpdateNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cNumberBox;
        private System.Windows.Forms.CheckBox cRollBox;
        private System.Windows.Forms.ListView lDataBox;
        private System.Windows.Forms.ColumnHeader cInitiative;
        private System.Windows.Forms.ColumnHeader cNumber;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cHealth;
        private System.Windows.Forms.ColumnHeader cGender;
    }
}

