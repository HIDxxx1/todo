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
    public partial class UserSaveForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserSaveForm()
        {
            InitializeComponent();
            StatusLabel.Text = "必要事項を入力お願いいたします。";

            EnableComboBox.SelectedIndex = 0;
            //EnableComboBox.Items.Add("有効");
            //EnableComboBox.Items.Add("無効");
            //CheckBoxの初期表示
            SetMailAddressTextBox();
            //ラベルの初期表示
            SetNateLabel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressTextBox();
        }

        /// <summary>
        /// CheckBoxの初期表示
        /// </summary>
        private void SetMailAddressTextBox()
        {
            MailAddressTextBox.Enabled = MailCheckBox.Checked;
            MailAddressLabel.Enabled = MailCheckBox.Checked;

        }

        private void BusinessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetNateLabel();
        }

        /// <summary>
        /// ラベルのセット
        /// </summary>
        public void SetNateLabel()
        {
            //if (BusinessRadioButton.Checked)
            //{
            //    NateLabel.Visible = true;
            //}
            //else
            //{
            //    NateLabel.Visible = false;

            //}]

            //上記は冗長な実装
            NateLabel.Visible = BusinessRadioButton.Checked;

        }

        /// <summary>
        /// 保存ボタン保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
          DialogResult dialog =  MessageBox.Show(
                "保存しますか？",
                "確認", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(dialog == DialogResult.OK)
            {
                StatusLabel.Text = "保存しました。";
            }
            else
            {
                StatusLabel.Text = "キャンセルしました。";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
