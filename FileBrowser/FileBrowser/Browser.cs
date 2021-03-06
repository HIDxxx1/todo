using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Browser_Load(object sender, EventArgs e)
        {
            //初期フォルダは、MyDocuments
            string initialFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //初期フォルダのサブフォルダ、ファイルを一覧表示
            OpenFolder(initialFolder);

            //初期フォルダのファイルを一覧表示
        }

        private void OpenFolder(string folder)
        {

            this.addressText.Text = folder;

            this.folderList.Items.Clear();

            string[] dirs = Directory.GetDirectories(folder);
            //this.folderList.Items.AddRange(dirs);
            foreach (string dir in dirs)
            {
                string[] subitems = new string[] { Path.GetFileName(dir), "フォルダ" };
                ListViewItem item = new ListViewItem(subitems);
                this.folderList.Items.Add(item);
            }
        }

        private void folderList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //マウスがどのアイテムをクリックしたか判定
          ListViewHitTestInfo hti =  this.folderList.HitTest(e.Location);
           ListViewItem item =  hti.Item;

            //該当するアイテムを開く
            string path = Path.Combine(this.addressText.Text, item.Text);
            if(item.SubItems[1].Text == "フォルダ")
            {
                OpenFolder(path);
            }
        }
    }
}
