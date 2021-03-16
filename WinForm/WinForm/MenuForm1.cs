using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            using (UserSaveForm userSaveForm = new UserSaveForm())
            {
                //処理が進む
                //userSaveForm.Show();
                //処理が止まる
                userSaveForm.ShowDialog();
            }

        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            using (UserListForm userListForm = new UserListForm())
            {
                //処理が進む
                //userSaveForm.Show();
                //処理が止まる
                userListForm.ShowDialog();
            }

        }
    }
}
