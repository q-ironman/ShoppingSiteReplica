using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppinSiteReplica.Services;
namespace ShoppingSiteReplica
{
    public partial class FUsers : Form
    {
        IUserService service = ServiceActivator.Get<IUserService>();
        
        public FUsers()
        {
            InitializeComponent();
        }

        private void FUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = service.GetAllService();
        }

    }
}
