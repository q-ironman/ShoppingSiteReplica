
namespace ShoppingSiteReplica
{
    partial class FCategories
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNametextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // CategoriesCB
            // 
            this.CategoriesCB.FormattingEnabled = true;
            this.CategoriesCB.Location = new System.Drawing.Point(141, 89);
            this.CategoriesCB.Name = "CategoriesCB";
            this.CategoriesCB.Size = new System.Drawing.Size(221, 24);
            this.CategoriesCB.TabIndex = 1;
            this.CategoriesCB.SelectedIndexChanged += new System.EventHandler(this.CategoriesCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories:";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.Location = new System.Drawing.Point(669, 89);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 24);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(673, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // searchNametextBox
            // 
            this.searchNametextBox.Location = new System.Drawing.Point(758, 129);
            this.searchNametextBox.Name = "searchNametextBox";
            this.searchNametextBox.Size = new System.Drawing.Size(168, 22);
            this.searchNametextBox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBtn.Location = new System.Drawing.Point(758, 171);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(168, 33);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.parentIDDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(326, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 193);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addNewBtn
            // 
            this.addNewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewBtn.Location = new System.Drawing.Point(949, 171);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(168, 33);
            this.addNewBtn.TabIndex = 8;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(ShoppingSiteReplica.Domain.Category);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentIDDataGridViewTextBoxColumn
            // 
            this.parentIDDataGridViewTextBoxColumn.DataPropertyName = "ParentID";
            this.parentIDDataGridViewTextBoxColumn.HeaderText = "ParentID";
            this.parentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentIDDataGridViewTextBoxColumn.Name = "parentIDDataGridViewTextBoxColumn";
            this.parentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // FCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 513);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchNametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriesCB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FCategories";
            this.Text = "FCategories";
            this.Load += new System.EventHandler(this.FCategories_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox CategoriesCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchNametextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}