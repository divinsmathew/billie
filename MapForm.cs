using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Billie
{
    public partial class MapForm : Form
    {
        readonly DataGridViewRowCollection ItemList;
        readonly DataGridViewRowCollection NameList;

        PersonItemMap Map;
        readonly int CurrentNameIndex;

        public MapForm(DataGridViewRowCollection NameList, int CurrentNameIndex, DataGridViewRowCollection ItemList)
        {
            InitializeComponent();

            this.ItemList = ItemList;
            this.NameList = NameList;
            this.CurrentNameIndex = CurrentNameIndex;
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemList.Count; i++)
                ItemComboBox.Items.Add(ItemList[i].Cells[0].Value.ToString());

            WhoText.Text = "What did " + NameList[CurrentNameIndex].Cells[0].Value.ToString() + " have?";
            NextPersonButton.Text = (CurrentNameIndex == NameList.Count - 1) ? "Finish" : "Next";
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select an Item Name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(QtyText.Text) || !int.TryParse(QtyText.Text, out _))
            {
                if (double.TryParse(QtyText.Text, out _))
                    MessageBox.Show("Enter decimals as fractions.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Enter a Valid Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (FractionBox.Checked)
                if (string.IsNullOrWhiteSpace(DenominatorText.Text) || !int.TryParse(DenominatorText.Text, out _))
                {
                    if (double.TryParse(DenominatorText.Text, out _))
                        MessageBox.Show("Enter decimals as fractions.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Enter a Valid Denominator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            ItemGrid.Rows.Add(ItemComboBox.Items[ItemComboBox.SelectedIndex].ToString().Trim(), (FractionBox.Checked) ? QtyText.Text.Trim() + "/" + DenominatorText.Text.Trim() : QtyText.Text.Trim(), "Remove");
            ItemComboBox.Items.RemoveAt(ItemComboBox.SelectedIndex);
            ItemComboBox.SelectedItem = null;
            QtyText.Text = "1";
        }

        private void ItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                ItemComboBox.Items.Add(senderGrid.Rows[e.RowIndex].Cells[0].Value);
                senderGrid.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Map = new PersonItemMap();
            Map.PersonIndex = CurrentNameIndex;

            foreach (DataGridViewRow Item in ItemGrid.Rows)
            {
                Map.Items.Add(Item.Cells[0].Value.ToString());

                if (Item.Cells[1].Value.ToString().Contains("/"))
                {
                    string[] fraction = Item.Cells[1].Value.ToString().Split('/');

                    Map.Quantities.Add(double.Parse(fraction[0]));
                    Map.Denominators.Add(double.Parse(fraction[1]));
                }
                else
                {
                    Map.Quantities.Add(double.Parse(Item.Cells[1].Value.ToString()));
                    Map.Denominators.Add(1);
                }
            }

            Close();
        }
        public PersonItemMap GetPersonItemMap()
        {
            return Map;
        }

        private void FractionBox_CheckedChanged(object sender, EventArgs e)
        {
            QtyText.Width = (FractionBox.Checked) ? 26 : 67;
        }
    }
}
