using ShoppingSiteReplica.Domain;
using ShoppinSiteReplica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingSiteReplica
{
    public partial class FrmUpdIns : Form
    {
        public int SelectMode { get; set; }
        public Guid UpdatedCatID { get; set; }
        ICategoryService myCateService = ServiceActivator.Get<ICategoryService>();
        public FrmUpdIns()
        {
            InitializeComponent();
        }

        private void FrmUpdIns_Load(object sender, EventArgs e)
        {
            if(SelectMode == 0)
            {
                upInsBtn.Text = "Add new category";
            }
            if(SelectMode == 1)
            {
                upInsBtn.Text = "Update category";
                var updCat = myCateService.FindByID(UpdatedCatID);
                CatNametextBox.Text = updCat.Name;
                if (updCat.ParentID == null)
                { ParCattextBox.Text = ""; }
                else
                {
                    var prntCat = myCateService.FindByID(Guid.Parse(updCat.ParentID.ToString()));
                    ParCattextBox.Text = prntCat.Name;
                }
            }
        }

        private void upInsBtn_Click(object sender, EventArgs e)
        {
            if(SelectMode == 0)
            {
                var newCat = new Category();
                newCat.ID = Guid.NewGuid();
                newCat.Name = CatNametextBox.Text;
                if(ParCattextBox.Text == null)
                {
                    newCat.ParentID = null;
                }
                else
                {
                    CategorySearch categorySearch = new CategorySearch();
                    categorySearch.Name = ParCattextBox.Text;
                    newCat.ParentID = myCateService.FindIdByName(categorySearch);
                }
                myCateService.Insert(newCat);
                this.Close();
            }
            if(SelectMode == 1)
            {

                var updCat = new Category();
                updCat.Name = CatNametextBox.Text;
                var parntSrch = new CategorySearch { Name = ParCattextBox.Text };
                updCat.ParentID = myCateService.FindIdByName(parntSrch);
                updCat.ID = UpdatedCatID;
                myCateService.Update(updCat);
            }
        }
    }
}
