using MetroFramework;
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
        private BindingList<ColorDto> _colorDtos = new BindingList<ColorDto>();
        public SampleMetro()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

            ThemeComboBox.Items.Add("Dark");
            ThemeComboBox.Items.Add("Light");

            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Default));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Black));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.White));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Silver));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Blue));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Green));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Lime));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Teal));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Orange));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Brown));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Pink));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Magenta));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Purple));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Red));
            _colorDtos.Add(new ColorDto(MetroFramework.MetroColorStyle.Yellow));

            ColorComboBox.ValueMember = nameof(ColorDto.Value);
            ColorComboBox.DisplayMember = nameof(ColorDto.DisplayValue);
            ColorComboBox.DataSource = _colorDtos;

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
            var dto = ColorComboBox.SelectedItem as ColorDto;
            if(dto != null)
            {
                metroStyleManager1.Style = dto.Value;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show()
           
            MetroMessageBox.Show(
                this,
                "保存しました",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            MetroMessageBox.Show(
               this,
               "保存しました",
               "Error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);

            MetroMessageBox.Show(
            this,
            "保存しますか？",
            "Question",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            MetroMessageBox.Show(
         this,
         "保存しますか？",
         "Question",
         MessageBoxButtons.OKCancel,
         MessageBoxIcon.Question);

            MetroMessageBox.Show(
         this,
         "保存しますか？",
         "Question",
         MessageBoxButtons.YesNoCancel,
         MessageBoxIcon.Question);

            MetroMessageBox.Show(
    this,
    "実行しますか？",
    "Question",
    MessageBoxButtons.RetryCancel,
    MessageBoxIcon.Question);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(
               this,
               "保存しました",
               "Infometion",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            MetroMessageBox.Show(
                this,
            metroDateTime1.Value.ToString("yyyy/MM/dd HH:mm:ss"),
            "Information");
        }
    }
}
