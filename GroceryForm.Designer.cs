namespace FreshCartManager
{
    partial class GroceryForm
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
            dgvGroceries = new DataGridView();
            txtProdName = new TextBox();
            txtPrice = new TextBox();
            txtCategoryId = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGroceries).BeginInit();
            SuspendLayout();
            // 
            // dgvGroceries
            // 
            dgvGroceries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroceries.Location = new Point(388, 79);
            dgvGroceries.Name = "dgvGroceries";
            dgvGroceries.Size = new Size(287, 147);
            dgvGroceries.TabIndex = 0;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(388, 236);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(87, 23);
            txtProdName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(481, 236);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(98, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(585, 236);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(92, 23);
            txtCategoryId.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(383, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(479, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 33);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update Selected";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(588, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 32);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // GroceryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCategoryId);
            Controls.Add(txtPrice);
            Controls.Add(txtProdName);
            Controls.Add(dgvGroceries);
            Name = "GroceryForm";
            Text = "GroceryForm";
            Load += GroceryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroceries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGroceries;
        private TextBox txtProdName;
        private TextBox txtPrice;
        private TextBox txtCategoryId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}