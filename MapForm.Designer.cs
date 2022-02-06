namespace Billie
{
    partial class MapForm
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
            this.WhoText = new System.Windows.Forms.Label();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveOption = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.QtyText = new System.Windows.Forms.TextBox();
            this.NextPersonButton = new System.Windows.Forms.Button();
            this.FractionBox = new System.Windows.Forms.CheckBox();
            this.DenominatorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // WhoText
            // 
            this.WhoText.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoText.Location = new System.Drawing.Point(13, 1);
            this.WhoText.Name = "WhoText";
            this.WhoText.Size = new System.Drawing.Size(336, 46);
            this.WhoText.TabIndex = 0;
            this.WhoText.Text = "What did Liya have?";
            this.WhoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.Qty,
            this.RemoveOption});
            this.ItemGrid.Location = new System.Drawing.Point(12, 97);
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ItemGrid.RowHeadersVisible = false;
            this.ItemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ItemGrid.Size = new System.Drawing.Size(337, 241);
            this.ItemGrid.TabIndex = 0;
            this.ItemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGrid_CellContentClick);
            // 
            // PersonName
            // 
            this.PersonName.Frozen = true;
            this.PersonName.HeaderText = "Item";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 190;
            // 
            // Qty
            // 
            this.Qty.Frozen = true;
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.Width = 75;
            // 
            // RemoveOption
            // 
            this.RemoveOption.Frozen = true;
            this.RemoveOption.HeaderText = "";
            this.RemoveOption.Name = "RemoveOption";
            this.RemoveOption.ReadOnly = true;
            this.RemoveOption.Width = 70;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(283, 53);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(66, 41);
            this.AddItemButton.TabIndex = 94;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(12, 71);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(191, 21);
            this.ItemComboBox.TabIndex = 95;
            // 
            // QtyText
            // 
            this.QtyText.Location = new System.Drawing.Point(210, 71);
            this.QtyText.Name = "QtyText";
            this.QtyText.Size = new System.Drawing.Size(67, 20);
            this.QtyText.TabIndex = 96;
            this.QtyText.Text = "1";
            // 
            // NextPersonButton
            // 
            this.NextPersonButton.Location = new System.Drawing.Point(271, 348);
            this.NextPersonButton.Name = "NextPersonButton";
            this.NextPersonButton.Size = new System.Drawing.Size(78, 29);
            this.NextPersonButton.TabIndex = 97;
            this.NextPersonButton.Text = "Next";
            this.NextPersonButton.UseVisualStyleBackColor = true;
            this.NextPersonButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FractionBox
            // 
            this.FractionBox.AutoSize = true;
            this.FractionBox.Location = new System.Drawing.Point(210, 52);
            this.FractionBox.Name = "FractionBox";
            this.FractionBox.Size = new System.Drawing.Size(64, 17);
            this.FractionBox.TabIndex = 98;
            this.FractionBox.Text = "Fraction";
            this.FractionBox.UseVisualStyleBackColor = true;
            this.FractionBox.CheckedChanged += new System.EventHandler(this.FractionBox_CheckedChanged);
            // 
            // DenominatorText
            // 
            this.DenominatorText.Location = new System.Drawing.Point(251, 71);
            this.DenominatorText.Name = "DenominatorText";
            this.DenominatorText.Size = new System.Drawing.Size(26, 20);
            this.DenominatorText.TabIndex = 99;
            this.DenominatorText.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "/";
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 388);
            this.ControlBox = false;
            this.Controls.Add(this.QtyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DenominatorText);
            this.Controls.Add(this.FractionBox);
            this.Controls.Add(this.NextPersonButton);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.WhoText);
            this.Controls.Add(this.ItemGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who had what?";
            this.Load += new System.EventHandler(this.MapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhoText;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.TextBox QtyText;
        private System.Windows.Forms.Button NextPersonButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveOption;
        private System.Windows.Forms.CheckBox FractionBox;
        private System.Windows.Forms.TextBox DenominatorText;
        private System.Windows.Forms.Label label1;
    }
}