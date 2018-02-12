namespace Forms
{
    partial class InquiryForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.conditionDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attributesListBox = new System.Windows.Forms.ListBox();
            this.selectedAttributesListBox = new System.Windows.Forms.ListBox();
            this.addAttributeButton = new System.Windows.Forms.Button();
            this.deleteAttributeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.selectedTablesListBox = new System.Windows.Forms.ListBox();
            this.addTableButton = new System.Windows.Forms.Button();
            this.deleteTableButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inquiryTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.condition1ComboBox = new System.Windows.Forms.ComboBox();
            this.attribute1ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attribute2ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.condition2ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createConditionButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.conditionColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createInquiryButton = new System.Windows.Forms.Button();
            this.createAndCarryInquiryButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 453);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Конструктор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.createAndCarryInquiryButton);
            this.groupBox3.Controls.Add(this.createInquiryButton);
            this.groupBox3.Controls.Add(this.createConditionButton);
            this.groupBox3.Controls.Add(this.attribute2ComboBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.condition2ComboBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.attribute1ComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.condition1ComboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.conditionDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(0, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 188);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Условия";
            // 
            // conditionDataGridView
            // 
            this.conditionDataGridView.AllowUserToAddRows = false;
            this.conditionDataGridView.AllowUserToResizeColumns = false;
            this.conditionDataGridView.AllowUserToResizeRows = false;
            this.conditionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.conditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteButton,
            this.conditionColumn1,
            this.attributeColumn1,
            this.conditionColumn2,
            this.attributeColumn2});
            this.conditionDataGridView.Location = new System.Drawing.Point(9, 59);
            this.conditionDataGridView.Name = "conditionDataGridView";
            this.conditionDataGridView.RowHeadersVisible = false;
            this.conditionDataGridView.Size = new System.Drawing.Size(474, 93);
            this.conditionDataGridView.TabIndex = 0;
            this.conditionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conditionDataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.attributesListBox);
            this.groupBox2.Controls.Add(this.selectedAttributesListBox);
            this.groupBox2.Controls.Add(this.addAttributeButton);
            this.groupBox2.Controls.Add(this.deleteAttributeButton);
            this.groupBox2.Location = new System.Drawing.Point(0, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 120);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Атрибуты";
            // 
            // attributesListBox
            // 
            this.attributesListBox.FormattingEnabled = true;
            this.attributesListBox.Location = new System.Drawing.Point(6, 19);
            this.attributesListBox.Name = "attributesListBox";
            this.attributesListBox.Size = new System.Drawing.Size(217, 95);
            this.attributesListBox.TabIndex = 0;
            this.attributesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.attributesListBox_MouseDoubleClick);
            // 
            // selectedAttributesListBox
            // 
            this.selectedAttributesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedAttributesListBox.FormattingEnabled = true;
            this.selectedAttributesListBox.Location = new System.Drawing.Point(261, 19);
            this.selectedAttributesListBox.Name = "selectedAttributesListBox";
            this.selectedAttributesListBox.Size = new System.Drawing.Size(222, 95);
            this.selectedAttributesListBox.TabIndex = 4;
            this.selectedAttributesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedAttributesListBox_MouseDoubleClick);
            // 
            // addAttributeButton
            // 
            this.addAttributeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAttributeButton.Location = new System.Drawing.Point(229, 38);
            this.addAttributeButton.Name = "addAttributeButton";
            this.addAttributeButton.Size = new System.Drawing.Size(26, 23);
            this.addAttributeButton.TabIndex = 2;
            this.addAttributeButton.Text = "->";
            this.addAttributeButton.UseVisualStyleBackColor = true;
            this.addAttributeButton.Click += new System.EventHandler(this.addAttributeButton_Click);
            // 
            // deleteAttributeButton
            // 
            this.deleteAttributeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteAttributeButton.Location = new System.Drawing.Point(229, 67);
            this.deleteAttributeButton.Name = "deleteAttributeButton";
            this.deleteAttributeButton.Size = new System.Drawing.Size(26, 23);
            this.deleteAttributeButton.TabIndex = 3;
            this.deleteAttributeButton.Text = "<-";
            this.deleteAttributeButton.UseVisualStyleBackColor = true;
            this.deleteAttributeButton.Click += new System.EventHandler(this.deleteAttributeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tablesListBox);
            this.groupBox1.Controls.Add(this.selectedTablesListBox);
            this.groupBox1.Controls.Add(this.addTableButton);
            this.groupBox1.Controls.Add(this.deleteTableButton);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблицы";
            // 
            // tablesListBox
            // 
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Location = new System.Drawing.Point(6, 19);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.Size = new System.Drawing.Size(217, 95);
            this.tablesListBox.TabIndex = 0;
            this.tablesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tablesListBox_MouseDoubleClick);
            // 
            // selectedTablesListBox
            // 
            this.selectedTablesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTablesListBox.FormattingEnabled = true;
            this.selectedTablesListBox.Location = new System.Drawing.Point(261, 19);
            this.selectedTablesListBox.Name = "selectedTablesListBox";
            this.selectedTablesListBox.Size = new System.Drawing.Size(222, 95);
            this.selectedTablesListBox.TabIndex = 4;
            this.selectedTablesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedTablesListBox_MouseDoubleClick);
            // 
            // addTableButton
            // 
            this.addTableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTableButton.Location = new System.Drawing.Point(229, 38);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(26, 23);
            this.addTableButton.TabIndex = 2;
            this.addTableButton.Text = "->";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // deleteTableButton
            // 
            this.deleteTableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteTableButton.Location = new System.Drawing.Point(229, 67);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(26, 23);
            this.deleteTableButton.TabIndex = 3;
            this.deleteTableButton.Text = "<-";
            this.deleteTableButton.UseVisualStyleBackColor = true;
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inquiryTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(489, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Текст";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inquiryTextBox
            // 
            this.inquiryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inquiryTextBox.Location = new System.Drawing.Point(0, 0);
            this.inquiryTextBox.Multiline = true;
            this.inquiryTextBox.Name = "inquiryTextBox";
            this.inquiryTextBox.Size = new System.Drawing.Size(489, 427);
            this.inquiryTextBox.TabIndex = 0;
            this.inquiryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Результат";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(483, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(357, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Условие 1";
            // 
            // condition1ComboBox
            // 
            this.condition1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condition1ComboBox.Enabled = false;
            this.condition1ComboBox.FormattingEnabled = true;
            this.condition1ComboBox.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.condition1ComboBox.Location = new System.Drawing.Point(9, 32);
            this.condition1ComboBox.Name = "condition1ComboBox";
            this.condition1ComboBox.Size = new System.Drawing.Size(57, 21);
            this.condition1ComboBox.TabIndex = 2;
            // 
            // attribute1ComboBox
            // 
            this.attribute1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attribute1ComboBox.FormattingEnabled = true;
            this.attribute1ComboBox.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.attribute1ComboBox.Location = new System.Drawing.Point(72, 32);
            this.attribute1ComboBox.Name = "attribute1ComboBox";
            this.attribute1ComboBox.Size = new System.Drawing.Size(125, 21);
            this.attribute1ComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Атрибут 1";
            // 
            // attribute2ComboBox
            // 
            this.attribute2ComboBox.FormattingEnabled = true;
            this.attribute2ComboBox.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.attribute2ComboBox.Location = new System.Drawing.Point(266, 32);
            this.attribute2ComboBox.Name = "attribute2ComboBox";
            this.attribute2ComboBox.Size = new System.Drawing.Size(125, 21);
            this.attribute2ComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Атрибут 1";
            // 
            // condition2ComboBox
            // 
            this.condition2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condition2ComboBox.FormattingEnabled = true;
            this.condition2ComboBox.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            "<=",
            ">",
            ">="});
            this.condition2ComboBox.Location = new System.Drawing.Point(203, 32);
            this.condition2ComboBox.Name = "condition2ComboBox";
            this.condition2ComboBox.Size = new System.Drawing.Size(57, 21);
            this.condition2ComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Условие 1";
            // 
            // createConditionButton
            // 
            this.createConditionButton.Location = new System.Drawing.Point(397, 30);
            this.createConditionButton.Name = "createConditionButton";
            this.createConditionButton.Size = new System.Drawing.Size(87, 23);
            this.createConditionButton.TabIndex = 9;
            this.createConditionButton.Text = "Добавить";
            this.createConditionButton.UseVisualStyleBackColor = true;
            this.createConditionButton.Click += new System.EventHandler(this.createConditionButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Frozen = true;
            this.deleteButton.HeaderText = "X";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Width = 23;
            // 
            // conditionColumn1
            // 
            this.conditionColumn1.FillWeight = 50F;
            this.conditionColumn1.Frozen = true;
            this.conditionColumn1.HeaderText = "Усл1";
            this.conditionColumn1.Name = "conditionColumn1";
            this.conditionColumn1.ReadOnly = true;
            this.conditionColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conditionColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conditionColumn1.Width = 50;
            // 
            // attributeColumn1
            // 
            this.attributeColumn1.FillWeight = 160F;
            this.attributeColumn1.Frozen = true;
            this.attributeColumn1.HeaderText = "Атрибут1";
            this.attributeColumn1.Name = "attributeColumn1";
            this.attributeColumn1.ReadOnly = true;
            this.attributeColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.attributeColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.attributeColumn1.Width = 160;
            // 
            // conditionColumn2
            // 
            this.conditionColumn2.FillWeight = 50F;
            this.conditionColumn2.Frozen = true;
            this.conditionColumn2.HeaderText = "Усл2";
            this.conditionColumn2.Name = "conditionColumn2";
            this.conditionColumn2.ReadOnly = true;
            this.conditionColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conditionColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conditionColumn2.Width = 50;
            // 
            // attributeColumn2
            // 
            this.attributeColumn2.FillWeight = 160F;
            this.attributeColumn2.Frozen = true;
            this.attributeColumn2.HeaderText = "Атрибут2";
            this.attributeColumn2.Name = "attributeColumn2";
            this.attributeColumn2.ReadOnly = true;
            this.attributeColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.attributeColumn2.Width = 160;
            // 
            // createInquiryButton
            // 
            this.createInquiryButton.Location = new System.Drawing.Point(9, 158);
            this.createInquiryButton.Name = "createInquiryButton";
            this.createInquiryButton.Size = new System.Drawing.Size(235, 23);
            this.createInquiryButton.TabIndex = 10;
            this.createInquiryButton.Text = "Сгенерировать запрос";
            this.createInquiryButton.UseVisualStyleBackColor = true;
            this.createInquiryButton.Click += new System.EventHandler(this.createInquiryButton_Click);
            // 
            // createAndCarryInquiryButton
            // 
            this.createAndCarryInquiryButton.Location = new System.Drawing.Point(250, 158);
            this.createAndCarryInquiryButton.Name = "createAndCarryInquiryButton";
            this.createAndCarryInquiryButton.Size = new System.Drawing.Size(233, 23);
            this.createAndCarryInquiryButton.TabIndex = 11;
            this.createAndCarryInquiryButton.Text = "Сгенерировать и выполнить";
            this.createAndCarryInquiryButton.UseVisualStyleBackColor = true;
            this.createAndCarryInquiryButton.Click += new System.EventHandler(this.createAndCarryInquiryButton_Click);
            // 
            // InquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 10000);
            this.MinimumSize = new System.Drawing.Size(499, 476);
            this.Name = "InquiryForm";
            this.Text = "InquiryForm";
            this.Load += new System.EventHandler(this.InquiryForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox inquiryTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.Button deleteTableButton;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.ListBox selectedTablesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox attributesListBox;
        private System.Windows.Forms.ListBox selectedAttributesListBox;
        private System.Windows.Forms.Button addAttributeButton;
        private System.Windows.Forms.Button deleteAttributeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView conditionDataGridView;
        private System.Windows.Forms.Button createConditionButton;
        private System.Windows.Forms.ComboBox attribute2ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox condition2ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox attribute1ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox condition1ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeColumn2;
        private System.Windows.Forms.Button createAndCarryInquiryButton;
        private System.Windows.Forms.Button createInquiryButton;
    }
}