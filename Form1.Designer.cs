namespace Billie
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddNameButton = new System.Windows.Forms.Button();
            this.NameGrid = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveOption = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TaxExcludeCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxExc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaxRateText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BreakdownButton = new System.Windows.Forms.Button();
            this.ShopNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResetItemsButton = new System.Windows.Forms.Button();
            this.ResetNamesButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NameText);
            this.groupBox2.Controls.Add(this.AddNameButton);
            this.groupBox2.Controls.Add(this.NameGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(6, 289);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(176, 20);
            this.NameText.TabIndex = 95;
            this.NameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameText_KeyDown);
            // 
            // AddNameButton
            // 
            this.AddNameButton.Location = new System.Drawing.Point(188, 288);
            this.AddNameButton.Name = "AddNameButton";
            this.AddNameButton.Size = new System.Drawing.Size(68, 23);
            this.AddNameButton.TabIndex = 94;
            this.AddNameButton.Text = "Add";
            this.AddNameButton.UseVisualStyleBackColor = true;
            this.AddNameButton.Click += new System.EventHandler(this.AddNameButton_Click);
            // 
            // NameGrid
            // 
            this.NameGrid.AllowUserToAddRows = false;
            this.NameGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.NameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.RemoveOption});
            this.NameGrid.Location = new System.Drawing.Point(6, 19);
            this.NameGrid.Name = "NameGrid";
            this.NameGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.NameGrid.RowHeadersVisible = false;
            this.NameGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.NameGrid.Size = new System.Drawing.Size(250, 264);
            this.NameGrid.TabIndex = 0;
            this.NameGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrustedFacesList_CellContentClick);
            // 
            // PersonName
            // 
            this.PersonName.Frozen = true;
            this.PersonName.HeaderText = "Name";
            this.PersonName.MinimumWidth = 6;
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 175;
            // 
            // RemoveOption
            // 
            this.RemoveOption.Frozen = true;
            this.RemoveOption.HeaderText = "";
            this.RemoveOption.MinimumWidth = 6;
            this.RemoveOption.Name = "RemoveOption";
            this.RemoveOption.ReadOnly = true;
            this.RemoveOption.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TaxExcludeCheckBox);
            this.groupBox1.Controls.Add(this.PriceTextBox);
            this.groupBox1.Controls.Add(this.ItemTextBox);
            this.groupBox1.Controls.Add(this.AddItemButton);
            this.groupBox1.Controls.Add(this.ItemGrid);
            this.groupBox1.Location = new System.Drawing.Point(281, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // TaxExcludeCheckBox
            // 
            this.TaxExcludeCheckBox.AutoSize = true;
            this.TaxExcludeCheckBox.Enabled = false;
            this.TaxExcludeCheckBox.Location = new System.Drawing.Point(259, 293);
            this.TaxExcludeCheckBox.Name = "TaxExcludeCheckBox";
            this.TaxExcludeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TaxExcludeCheckBox.TabIndex = 94;
            this.TaxExcludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(185, 290);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(56, 20);
            this.PriceTextBox.TabIndex = 93;
            this.PriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PriceTextBox_KeyDown);
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(7, 290);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(171, 20);
            this.ItemTextBox.TabIndex = 92;
            this.ItemTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemTextBox_KeyDown);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(291, 288);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(76, 23);
            this.AddItemButton.TabIndex = 91;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.dataGridViewTextBoxColumn1,
            this.TaxExc,
            this.dataGridViewButtonColumn1});
            this.ItemGrid.Location = new System.Drawing.Point(7, 19);
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ItemGrid.RowHeadersVisible = false;
            this.ItemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ItemGrid.Size = new System.Drawing.Size(360, 264);
            this.ItemGrid.TabIndex = 0;
            this.ItemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrustedFacesList_CellContentClick);
            // 
            // SlNo
            // 
            this.SlNo.Frozen = true;
            this.SlNo.HeaderText = "Item";
            this.SlNo.MinimumWidth = 6;
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SlNo.Width = 165;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Price";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // TaxExc
            // 
            this.TaxExc.Frozen = true;
            this.TaxExc.HeaderText = "Exclude Tax";
            this.TaxExc.MinimumWidth = 6;
            this.TaxExc.Name = "TaxExc";
            this.TaxExc.ReadOnly = true;
            this.TaxExc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TaxExc.Width = 72;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.Frozen = true;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Width = 65;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(454, 339);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(60, 47);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Map";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tax Percentage:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TaxRateText
            // 
            this.TaxRateText.Location = new System.Drawing.Point(18, 363);
            this.TaxRateText.Name = "TaxRateText";
            this.TaxRateText.Size = new System.Drawing.Size(35, 20);
            this.TaxRateText.TabIndex = 95;
            this.TaxRateText.Text = "0";
            this.TaxRateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TaxRateText.TextChanged += new System.EventHandler(this.TaxRateText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 96;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakdownButton
            // 
            this.BreakdownButton.Location = new System.Drawing.Point(520, 339);
            this.BreakdownButton.Name = "BreakdownButton";
            this.BreakdownButton.Size = new System.Drawing.Size(136, 47);
            this.BreakdownButton.TabIndex = 97;
            this.BreakdownButton.Text = "Build Bill Breakdown";
            this.BreakdownButton.UseVisualStyleBackColor = true;
            this.BreakdownButton.Click += new System.EventHandler(this.BreakdownButton_Click);
            // 
            // ShopNameBox
            // 
            this.ShopNameBox.Location = new System.Drawing.Point(163, 363);
            this.ShopNameBox.Name = "ShopNameBox";
            this.ShopNameBox.Size = new System.Drawing.Size(186, 20);
            this.ShopNameBox.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "Shop Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(374, 338);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(74, 47);
            this.ResetButton.TabIndex = 100;
            this.ResetButton.Text = "Start Over";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ResetItemsButton
            // 
            this.ResetItemsButton.Location = new System.Drawing.Point(574, 5);
            this.ResetItemsButton.Name = "ResetItemsButton";
            this.ResetItemsButton.Size = new System.Drawing.Size(74, 21);
            this.ResetItemsButton.TabIndex = 101;
            this.ResetItemsButton.Text = "Reset";
            this.ResetItemsButton.UseVisualStyleBackColor = true;
            this.ResetItemsButton.Click += new System.EventHandler(this.ResetItemsButton_Click);
            // 
            // ResetNamesButton
            // 
            this.ResetNamesButton.Location = new System.Drawing.Point(194, 4);
            this.ResetNamesButton.Name = "ResetNamesButton";
            this.ResetNamesButton.Size = new System.Drawing.Size(74, 21);
            this.ResetNamesButton.TabIndex = 102;
            this.ResetNamesButton.Text = "Reset";
            this.ResetNamesButton.UseVisualStyleBackColor = true;
            this.ResetNamesButton.Click += new System.EventHandler(this.ResetNamesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 396);
            this.Controls.Add(this.ResetNamesButton);
            this.Controls.Add(this.ResetItemsButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShopNameBox);
            this.Controls.Add(this.BreakdownButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaxRateText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billie, the Bill Splitter!";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView NameGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button AddNameButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveOption;
        private System.Windows.Forms.CheckBox TaxExcludeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaxRateText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BreakdownButton;
        private System.Windows.Forms.TextBox ShopNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TaxExc;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ResetItemsButton;
        private System.Windows.Forms.Button ResetNamesButton;
    }
}

