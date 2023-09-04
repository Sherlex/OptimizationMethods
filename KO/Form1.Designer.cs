namespace KO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.optionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A1totextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.A1fromtextBox = new System.Windows.Forms.TextBox();
            this.A2totextBox = new System.Windows.Forms.TextBox();
            this.A2fromtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hourstextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.accuracytextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.b1textBox = new System.Windows.Forms.TextBox();
            this.btextBox = new System.Windows.Forms.TextBox();
            this.a1textBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.atextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.u1textBox = new System.Windows.Forms.TextBox();
            this.utextBox = new System.Windows.Forms.TextBox();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.button2d = new System.Windows.Forms.Button();
            this.button3d = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.V2textBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.V1textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.resA2textBox = new System.Windows.Forms.TextBox();
            this.resA1textBox = new System.Windows.Forms.TextBox();
            this.maxtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.editToolStripMenuItem,
            this.refToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetableToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // savetableToolStripMenuItem
            // 
            this.savetableToolStripMenuItem.Name = "savetableToolStripMenuItem";
            this.savetableToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.savetableToolStripMenuItem.Text = "Сохранить таблицу значений";
            this.savetableToolStripMenuItem.Click += new System.EventHandler(this.savetableToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // refToolStripMenuItem1
            // 
            this.refToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.refToolStripMenuItem1.Name = "refToolStripMenuItem1";
            this.refToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.refToolStripMenuItem1.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Метод оптимизации";
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(150, 38);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(184, 21);
            this.methodComboBox.TabIndex = 2;
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.methodComboBox_SelectedIndexChanged);
            // 
            // optionComboBox
            // 
            this.optionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionComboBox.FormattingEnabled = true;
            this.optionComboBox.Location = new System.Drawing.Point(150, 75);
            this.optionComboBox.Name = "optionComboBox";
            this.optionComboBox.Size = new System.Drawing.Size(184, 21);
            this.optionComboBox.TabIndex = 4;
            this.optionComboBox.SelectedIndexChanged += new System.EventHandler(this.optionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вариант";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(438, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Математическая модель";
            // 
            // A1totextBox
            // 
            this.A1totextBox.Location = new System.Drawing.Point(198, 230);
            this.A1totextBox.Name = "A1totextBox";
            this.A1totextBox.Size = new System.Drawing.Size(55, 20);
            this.A1totextBox.TabIndex = 11;
            this.A1totextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.A1totextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Объемные расходы компонентов, м³/ч";
            // 
            // A1fromtextBox
            // 
            this.A1fromtextBox.Location = new System.Drawing.Point(91, 230);
            this.A1fromtextBox.Name = "A1fromtextBox";
            this.A1fromtextBox.Size = new System.Drawing.Size(55, 20);
            this.A1fromtextBox.TabIndex = 9;
            this.A1fromtextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.A1fromtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // A2totextBox
            // 
            this.A2totextBox.Location = new System.Drawing.Point(198, 271);
            this.A2totextBox.Name = "A2totextBox";
            this.A2totextBox.Size = new System.Drawing.Size(55, 20);
            this.A2totextBox.TabIndex = 13;
            this.A2totextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.A2totextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // A2fromtextBox
            // 
            this.A2fromtextBox.Location = new System.Drawing.Point(91, 271);
            this.A2fromtextBox.Name = "A2fromtextBox";
            this.A2fromtextBox.Size = new System.Drawing.Size(55, 20);
            this.A2fromtextBox.TabIndex = 12;
            this.A2fromtextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.A2fromtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "А1: от";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "А2: от";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "до";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Рабочая смена, ч";
            // 
            // hourstextBox
            // 
            this.hourstextBox.Location = new System.Drawing.Point(178, 326);
            this.hourstextBox.Name = "hourstextBox";
            this.hourstextBox.Size = new System.Drawing.Size(55, 20);
            this.hourstextBox.TabIndex = 18;
            this.hourstextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.hourstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Точность решения, кг";
            // 
            // accuracytextBox
            // 
            this.accuracytextBox.Location = new System.Drawing.Point(178, 361);
            this.accuracytextBox.Name = "accuracytextBox";
            this.accuracytextBox.Size = new System.Drawing.Size(55, 20);
            this.accuracytextBox.TabIndex = 20;
            this.accuracytextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.accuracytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = " β1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "α1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = " β";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(381, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "α";
            // 
            // b1textBox
            // 
            this.b1textBox.Location = new System.Drawing.Point(511, 224);
            this.b1textBox.Name = "b1textBox";
            this.b1textBox.Size = new System.Drawing.Size(55, 20);
            this.b1textBox.TabIndex = 26;
            this.b1textBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.b1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // btextBox
            // 
            this.btextBox.Location = new System.Drawing.Point(404, 224);
            this.btextBox.Name = "btextBox";
            this.btextBox.Size = new System.Drawing.Size(55, 20);
            this.btextBox.TabIndex = 25;
            this.btextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.btextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // a1textBox
            // 
            this.a1textBox.Location = new System.Drawing.Point(511, 182);
            this.a1textBox.Name = "a1textBox";
            this.a1textBox.Size = new System.Drawing.Size(55, 20);
            this.a1textBox.TabIndex = 24;
            this.a1textBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.a1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(360, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Нормирующие коэффициенты";
            // 
            // atextBox
            // 
            this.atextBox.Location = new System.Drawing.Point(404, 182);
            this.atextBox.Name = "atextBox";
            this.atextBox.Size = new System.Drawing.Size(55, 20);
            this.atextBox.TabIndex = 22;
            this.atextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.atextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(483, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = " μ1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(381, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = " μ";
            // 
            // u1textBox
            // 
            this.u1textBox.Location = new System.Drawing.Point(511, 266);
            this.u1textBox.Name = "u1textBox";
            this.u1textBox.Size = new System.Drawing.Size(55, 20);
            this.u1textBox.TabIndex = 32;
            this.u1textBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.u1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // utextBox
            // 
            this.utextBox.Location = new System.Drawing.Point(404, 266);
            this.utextBox.Name = "utextBox";
            this.utextBox.Size = new System.Drawing.Size(55, 20);
            this.utextBox.TabIndex = 31;
            this.utextBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.utextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // calculatebutton
            // 
            this.calculatebutton.Enabled = false;
            this.calculatebutton.Location = new System.Drawing.Point(178, 410);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.calculatebutton.TabIndex = 38;
            this.calculatebutton.Text = "Рассчитать";
            this.calculatebutton.UseVisualStyleBackColor = true;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton1_Click);
            // 
            // button2d
            // 
            this.button2d.Location = new System.Drawing.Point(337, 410);
            this.button2d.Name = "button2d";
            this.button2d.Size = new System.Drawing.Size(75, 23);
            this.button2d.TabIndex = 39;
            this.button2d.Text = "2D график";
            this.button2d.UseVisualStyleBackColor = true;
            this.button2d.Click += new System.EventHandler(this.button2d_Click);
            // 
            // button3d
            // 
            this.button3d.Location = new System.Drawing.Point(496, 410);
            this.button3d.Name = "button3d";
            this.button3d.Size = new System.Drawing.Size(75, 23);
            this.button3d.TabIndex = 40;
            this.button3d.Text = "3D график";
            this.button3d.UseVisualStyleBackColor = true;
            this.button3d.Click += new System.EventHandler(this.button3d_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(157, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "V2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(47, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "V1";
            // 
            // V2textBox
            // 
            this.V2textBox.Location = new System.Drawing.Point(198, 155);
            this.V2textBox.Name = "V2textBox";
            this.V2textBox.Size = new System.Drawing.Size(55, 20);
            this.V2textBox.TabIndex = 43;
            this.V2textBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.V2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(47, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(166, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Рабочие объемы реакторов, м³";
            // 
            // V1textBox
            // 
            this.V1textBox.Location = new System.Drawing.Point(91, 155);
            this.V1textBox.Name = "V1textBox";
            this.V1textBox.Size = new System.Drawing.Size(55, 20);
            this.V1textBox.TabIndex = 41;
            this.V1textBox.TextChanged += new System.EventHandler(this.Any_main_TextChanged);
            this.V1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.V1textBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KO.Properties.Resources.Снимок2;
            this.pictureBox1.Location = new System.Drawing.Point(353, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 50);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.resA2textBox);
            this.groupBox1.Controls.Add(this.resA1textBox);
            this.groupBox1.Controls.Add(this.maxtextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(281, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 77);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(192, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 13);
            this.label22.TabIndex = 58;
            this.label22.Text = "А2:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(47, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "При А1:";
            // 
            // resA2textBox
            // 
            this.resA2textBox.Location = new System.Drawing.Point(217, 47);
            this.resA2textBox.Name = "resA2textBox";
            this.resA2textBox.ReadOnly = true;
            this.resA2textBox.Size = new System.Drawing.Size(85, 20);
            this.resA2textBox.TabIndex = 56;
            // 
            // resA1textBox
            // 
            this.resA1textBox.Location = new System.Drawing.Point(101, 47);
            this.resA1textBox.Name = "resA1textBox";
            this.resA1textBox.ReadOnly = true;
            this.resA1textBox.Size = new System.Drawing.Size(85, 20);
            this.resA1textBox.TabIndex = 55;
            // 
            // maxtextBox
            // 
            this.maxtextBox.Location = new System.Drawing.Point(277, 12);
            this.maxtextBox.Name = "maxtextBox";
            this.maxtextBox.ReadOnly = true;
            this.maxtextBox.Size = new System.Drawing.Size(85, 20);
            this.maxtextBox.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Максимальный выход целевого компонента ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A1,
            this.A2,
            this.C});
            this.dataGridView1.Location = new System.Drawing.Point(710, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 431);
            this.dataGridView1.TabIndex = 54;
            // 
            // A1
            // 
            this.A1.HeaderText = "A1";
            this.A1.Name = "A1";
            // 
            // A2
            // 
            this.A2.HeaderText = "A2";
            this.A2.Name = "A2";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.V2textBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.V1textBox);
            this.Controls.Add(this.button3d);
            this.Controls.Add(this.button2d);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.u1textBox);
            this.Controls.Add(this.utextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.b1textBox);
            this.Controls.Add(this.btextBox);
            this.Controls.Add(this.a1textBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.atextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.accuracytextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hourstextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.A2totextBox);
            this.Controls.Add(this.A2fromtextBox);
            this.Controls.Add(this.A1totextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.A1fromtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savetableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.ComboBox optionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A1totextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A1fromtextBox;
        private System.Windows.Forms.TextBox A2totextBox;
        private System.Windows.Forms.TextBox A2fromtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hourstextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox accuracytextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox b1textBox;
        private System.Windows.Forms.TextBox btextBox;
        private System.Windows.Forms.TextBox a1textBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox atextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox u1textBox;
        private System.Windows.Forms.TextBox utextBox;
        private System.Windows.Forms.ToolStripMenuItem refToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Button button2d;
        private System.Windows.Forms.Button button3d;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox V2textBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox V1textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox resA2textBox;
        private System.Windows.Forms.TextBox resA1textBox;
        private System.Windows.Forms.TextBox maxtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
    }
}

