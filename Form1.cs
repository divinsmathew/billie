using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Billie
{
    public partial class Form1 : Form
    {
        List<PersonItemMap> PersonItemMaps;
        public Form1()
        {
            InitializeComponent();
            PersonItemMaps = new List<PersonItemMap>();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaxRateText.Text) || !double.TryParse(TaxRateText.Text, out _))
            {
                MessageBox.Show("Enter a Valid Tax Percentage.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(ShopNameBox.Text))
            {
                MessageBox.Show("Enter a Shop Name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PersonItemMaps.Clear();

            for (int i = 0; i < NameGrid.Rows.Count; i++)
            {
                MapForm mapForm = new MapForm(NameGrid.Rows, i, ItemGrid.Rows);
                mapForm.ShowDialog();

                PersonItemMaps.Add(mapForm.GetPersonItemMap());
            }

            //NextButton.Enabled = false;
            BreakdownButton.Enabled = true;
        }

        private void AddNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameText.Text))
            {
                MessageBox.Show("Enter A Name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < NameGrid.Rows.Count; i++)
                if (NameGrid.Rows[i].Cells[0].Value as string == NameText.Text.Trim())
                {
                    MessageBox.Show("Name already exists. Enter a different name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            NameGrid.Rows.Add(NameText.Text.Trim(), "Remove");
            NameText.Text = "";
        }

        private void TrustedFacesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                senderGrid.Rows.RemoveAt(e.RowIndex);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemTextBox.Text))
            {
                MessageBox.Show("Enter an Item Name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(PriceTextBox.Text) || !double.TryParse(PriceTextBox.Text, out _))
            {
                MessageBox.Show("Enter a Valid Price.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ItemGrid.Rows.Add(ItemTextBox.Text.Trim(), PriceTextBox.Text.Trim(), TaxExcludeCheckBox.Checked, "Remove");
            ItemTextBox.Text = "";
            PriceTextBox.Text = "";
            TaxExcludeCheckBox.Checked = false;
        }

        private void BreakdownButton_Click(object sender, EventArgs e)
        {
            BillieData billieData = new BillieData();

            for (int i = 0; i < NameGrid.Rows.Count; i++)
                billieData.PeopleNames.Add(NameGrid.Rows[i].Cells[0].Value.ToString());

            for (int i = 0; i < ItemGrid.Rows.Count; i++)
            {
                ItemDetails itemDetails = new ItemDetails
                {
                    Name = ItemGrid.Rows[i].Cells[0].Value.ToString(),
                    Price = double.Parse(ItemGrid.Rows[i].Cells[1].Value.ToString()),
                    TaxExcempted = Convert.ToBoolean(ItemGrid.Rows[i].Cells[2].Value)
                };

                billieData.Items.Add(itemDetails);
            }

            billieData.Maps = PersonItemMaps;
            billieData.TaxPercentage = double.Parse(TaxRateText.Text.Trim());
            billieData.ShopName = ShopNameBox.Text.Trim();
            billieData.PurchaseDate = DateTime.Now;
            billieData.Currency = "Rs.";

            //string json = JsonConvert.SerializeObject(billieData);
            //File.WriteAllText("json.txt", json);
            //MessageBox.Show(json);

            //BillieData readData = JsonConvert.DeserializeObject<BillieData>(File.ReadAllText("json.txt"));
            //Billie billie = new Billie(readData);

            Billie billie = new Billie(billieData);
            string path = billie.GenerateBreakdown();

            if (MessageBox.Show("Breakdown generated Successfully!\n\nOpen now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Process.Start(path);
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("json.txt");
            BillieData billieDataL = JsonConvert.DeserializeObject<BillieData>(json);
            Billie billie = new Billie(billieDataL);
            string path = billie.GenerateBreakdown();

            if (MessageBox.Show("Breakdown generated Successfully!\n\nOpen now?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Process.Start(path);
        }

        private void TaxRateText_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TaxRateText.Text, out double p))
                TaxExcludeCheckBox.Enabled = p > 0;

            if (p <= 0)
                for (int i = 0; i < ItemGrid.Rows.Count; i++)
                    (ItemGrid.Rows[i].Cells[2] as DataGridViewCheckBoxCell).Value = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ItemGrid.Rows.Clear();
            NameGrid.Rows.Clear();
            PersonItemMaps.Clear();

            TaxRateText.Text = "";
            ShopNameBox.Text = "";

            NextButton.Enabled = true;
            BreakdownButton.Enabled = false;
        }

        private void ResetNamesButton_Click(object sender, EventArgs e)
        {
            NameGrid.Rows.Clear();
            PersonItemMaps.Clear();

            NextButton.Enabled = true;
            BreakdownButton.Enabled = false;
        }

        private void ResetItemsButton_Click(object sender, EventArgs e)
        {
            ItemGrid.Rows.Clear();
            PersonItemMaps.Clear();

            NextButton.Enabled = true;
            BreakdownButton.Enabled = false;
        }

        private void NameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNameButton_Click(null, null);
        }

        private void ItemTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = PriceTextBox;
        }

        private void PriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItemButton_Click(null, null);
                ActiveControl = ItemTextBox;
            }
        }
    }
}
