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
    public partial class UserListForm : Form
    {
        private BindingList<UserInfoDTO> _dtos = new BindingList<UserInfoDTO>();
        public UserListForm()
        {

            InitializeComponent();

            if (!System.IO.File.Exists("save.csv")) return;

           string[] linse = System.IO.File.ReadAllLines(
               "save.csv",
               Encoding.GetEncoding("shift_jis"));

            foreach(var line in linse)
            {
              string[] row = line.Split(',');
                UserInfoDTO userInfo = new UserInfoDTO(
                    row[0], 
                    row[1], 
                    row[2], 
                    row[3], 
                    row[4]);
                _dtos.Add(userInfo);
            }
            dgvUserDataGrid.DataSource = _dtos;

            dgvUserDataGrid.Columns[0].HeaderText = "ID";
            dgvUserDataGrid.Columns[1].HeaderText = "メール送信";
            dgvUserDataGrid.Columns[2].HeaderText = "メールアドレス";
            dgvUserDataGrid.Columns[3].HeaderText = "プラン";
            dgvUserDataGrid.Columns[4].HeaderText = "テキスト";
        }

        private void dgvUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
