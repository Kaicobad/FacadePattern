using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacadeLearning.BLL;
using FacadeLearning.DAL;

namespace LearningFacade.WindowsForm
{
    public partial class frmFacadeLearning : Form
    {
        public frmFacadeLearning()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            tblUser user = new tblUser();
            user.Name = txtAddUser.Text.ToUpper();

            using (TheFacade facade = new TheFacade())
            {
                if (user.Name != null)
                {
                    facade.Insert<tblUser>(user);
                    MessageBox.Show("Succeed!!");
                    txtAddUser.Text = "";
                }
                else
                {
                    MessageBox.Show("error!!");
                }
                
            }
        }
    }
}
