using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshCartManager
{
    public partial class GroceryForm : Form
    {
        public GroceryForm()
        {
            InitializeComponent();
        }

        private void GroceryForm_Load(object sender, EventArgs e)
        {
            LoadGroceries();
        }

        private void LoadGroceries()
        {
            using (var db = new FreshCartContext())
            {
                // This fills your DataGridView (dgvGroceries) with the list from the database
                dgvGroceries.DataSource = db.GroceryItems.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new FreshCartContext())
            {
                try
                {
                    var item = new GroceryItem
                    {
                        // Text is fine for the name
                        ProdName = txtProdName.Text,

                        // Use decimal.Parse only for the Price box (e.g., 2.50)
                        Price = decimal.Parse(txtPrice.Text),

                        // Use int.Parse only for the Category ID box (e.g., 1)
                        CategoryId = int.Parse(txtCategoryId.Text)
                    };

                    db.GroceryItems.Add(item);
                    db.SaveChanges();
                    LoadGroceries();
                    MessageBox.Show("Success! Item added.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter numbers only for Price and Category ID!");
                }
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGroceries.CurrentRow == null) return;
            int id = (int)dgvGroceries.CurrentRow.Cells["ProductId"].Value;

            using (var db = new FreshCartContext())
            {
                var item = db.GroceryItems.Find(id);
                if (item != null)
                {
                    item.ProdName = txtProdName.Text;
                    item.Price = decimal.Parse(txtPrice.Text);
                    db.SaveChanges();
                    LoadGroceries();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGroceries.CurrentRow == null) return;
            int id = (int)dgvGroceries.CurrentRow.Cells["ProductId"].Value;

            using (var db = new FreshCartContext())
            {
                var item = db.GroceryItems.Find(id);
                if (item != null)
                {
                    db.GroceryItems.Remove(item);
                    db.SaveChanges();
                    LoadGroceries();
                }
            }
        }
    }
}


        
 
