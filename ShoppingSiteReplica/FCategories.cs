using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ShoppingSiteReplica.Domain;
using ShoppinSiteReplica.Services;
namespace ShoppingSiteReplica
{
    public partial class FCategories : Form
    {
        ICategoryService myCateService = ServiceActivator.Get<ICategoryService>();
        public FCategories()
        {
            InitializeComponent();
        }

        //private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string item = (sender as ToolStripMenuItem).Text;
        //    if (item == "Category")
        //        ;
        //    else
        //    {
        //        CategorySearch categorySearch = new CategorySearch();
        //        categorySearch.Name = (sender as ToolStripMenuItem).Text;
        //        var searchID = myCateService.FindIdByName(categorySearch);
        //        var subCats = myCateService.GetSubCat(searchID);
        //        foreach (var cat in subCats)
        //        {
        //            categoryToolStripMenuItem.DropDownItems.Add(cat.Name);
        //        }
        //    }
        //}

        private void FCategories_Load(object sender, EventArgs e)
        {
            //var mainCats = myCateService.GetMainCat();
            //foreach (var cat in mainCats)
            //{
            //    categoryToolStripMenuItem.DropDownItems.Add(cat.Name);

            //}
            var mainCats = myCateService.GetMainCat();
            foreach(var cat in mainCats)
            {
                CategoriesCB.Items.Add(cat.Name);
            }
            //string path = @"C:\Users\osman\Desktop\Lectures\C#\ShoppingSiteReplica\Catogaries.xml";

            //XElement doc = XElement.Load(path);
            //Category cat1 = new Category { ID = Guid.NewGuid(), Name = "Elektronik", ParentID = null };
            //Category cat2 = new Category { ID = Guid.NewGuid(), Name = "Cep Telefonu", ParentID = cat1.ID };
            //Category cat3 = new Category { ID = Guid.NewGuid(), Name = "Beyas Esya", ParentID = cat1.ID };
            //Category cat4 = new Category { ID = Guid.NewGuid(), Name = "Dondurucu", ParentID = cat3.ID };
            //Category cat5 = new Category { ID = Guid.NewGuid(), Name = "Derin Dondurucu", ParentID = cat4.ID };

            //doc.Add(new XElement("Category",
            //    new XElement("ID", cat1.ID.ToString()),
            //    new XElement("Name", cat1.Name),
            //    new XElement("ParentID", cat1.ParentID.ToString())));
            //doc.Add(new XElement("Category",
            //    new XElement("ID", cat2.ID.ToString()),
            //    new XElement("Name", cat2.Name),
            //    new XElement("ParentID", cat2.ParentID.ToString())));
            //doc.Add(new XElement("Category",
            //                new XElement("ID", cat3.ID.ToString()),
            //                new XElement("Name", cat3.Name),
            //                new XElement("ParentID", cat3.ParentID.ToString())));
            //doc.Add(new XElement("Category",
            //                new XElement("ID", cat4.ID.ToString()),
            //                new XElement("Name", cat4.Name),
            //                new XElement("ParentID", cat4.ParentID.ToString())));
            //doc.Add(new XElement("Category",
            //                new XElement("ID", cat5.ID.ToString()),
            //                new XElement("Name", cat5.Name),
            //                new XElement("ParentID", cat5.ParentID.ToString())));
            //doc.Save(path);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string item = e.ClickedItem.Text; //(sender as ToolStripMenuItem).Text;
            if (item == "Elektronik")
                ;
            else
            {
                CategorySearch categorySearch = new CategorySearch();
                categorySearch.Name = e.ClickedItem.Text;
                var searchID = myCateService.FindIdByName(categorySearch);
                var subCats = myCateService.GetSubCat(searchID);
                foreach (var cat in subCats)
                {
                    categoryToolStripMenuItem.DropDownItems.Add(cat.Name);
                }
            }
        }

        private void CategoriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategorySearch categorySearch = new CategorySearch();
            categorySearch.Name = CategoriesCB.SelectedItem.ToString();
            var searchID = myCateService.FindIdByName(categorySearch);
            var subCats = myCateService.GetSubCat(searchID);
            CategoriesCB.Items.Clear();
            foreach (var cat in subCats)
            {
                CategoriesCB.Items.Add(cat.Name);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            CategorySearch categorySearch = new CategorySearch();
            categorySearch.Name = searchNametextBox.Text;
            dataGridView1.DataSource = myCateService.Search(categorySearch);
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            FrmUpdIns frmIns = new FrmUpdIns();
            frmIns.SelectMode = 0;
            frmIns.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Guid _id = Guid.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                myCateService.Delete(_id);

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                FrmUpdIns frmUpdIns = new FrmUpdIns();
                frmUpdIns.SelectMode = 1;
                frmUpdIns.UpdatedCatID = _id;
                frmUpdIns.ShowDialog();
            }
        }
    }
}
