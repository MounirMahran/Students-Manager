using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudent()
        {
            if(string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(mtbID.Text) ||
               string.IsNullOrEmpty(mtbLevel.Text) || string.IsNullOrEmpty(mtbPhoneNumber.Text))
                return;

            ListViewItem Item = new ListViewItem(mtbID.Text.Trim());

            Item.SubItems.Add(tbName.Text.Trim());
            Item.SubItems.Add(mtbLevel.Text.Trim());
            Item.SubItems.Add(mtbPhoneNumber.Text.Trim());
            Item.SubItems.Add(cbGender.Text);
            Item.SubItems.Add(dateTimePicker1.Text.Trim());

            if (cbGender.SelectedIndex == 0)
            {
                Item.ImageIndex = 1;
            }
            else
            {
                Item.ImageIndex = 0;
            }

            listView1.Items.Add(Item);

            mtbID.Clear();
            tbName.Clear();
            mtbLevel.Clear();
            mtbPhoneNumber.Clear();
            cbGender.SelectedItem = null;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void rbListViewLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbListViewDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbListViewSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbListViewList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbListViewTiles_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Student will be deleted from the list.", "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            
        }
    }
}
