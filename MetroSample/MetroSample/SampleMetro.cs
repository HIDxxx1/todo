using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroSample
{                                     //Metroを継承
    public partial class SampleMetro : MetroForm
    {
        public SampleMetro()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

            ThemeComboBox.Items.Add("Dark");
            ThemeComboBox.Items.Add("Light");
        }

        /// <summary>
        /// コンボボックスでテーマの変更処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ThemeComboBox.Text == "Dark")
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }
    }
}
