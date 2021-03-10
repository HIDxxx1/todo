using MetroFramework.Forms;
using MetroSample.Helpers;
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
        private BindingList<ColorDto> _colorDtos = new BindingList<ColorDto>
        public SampleMetro()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

            ThemeComboBox.Items.Add("Dark");
            ThemeComboBox.Items.Add("Light");

           

             = 0,
        Black = 1,
        White = 2,
        Silver = 3,
        Blue = 4,
        Green = 5,
        Lime = 6,
        Teal = 7,
        Orange = 8,
        Brown = 9,
        Pink = 10,
        Magenta = 11,
        Purple = 12,
        Red = 13,
        Yellow = 14
                _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Default));
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

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
        }
    }
}
