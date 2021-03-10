
namespace MetroSample
{
    partial class SampleMetro
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Metrolabel = new MetroFramework.Controls.MetroLabel();
            this.ColorComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(50, 178);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(284, 46);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(50, 282);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(284, 244);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(347, 282);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(284, 244);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(50, 538);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(581, 244);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.ItemHeight = 23;
            this.ThemeComboBox.Location = new System.Drawing.Point(303, 40);
            this.ThemeComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(161, 29);
            this.ThemeComboBox.TabIndex = 4;
            this.ThemeComboBox.UseSelectable = true;
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(231, 50);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Theme";
            // 
            // Metrolabel
            // 
            this.Metrolabel.AutoSize = true;
            this.Metrolabel.Location = new System.Drawing.Point(516, 50);
            this.Metrolabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Metrolabel.Name = "Metrolabel";
            this.Metrolabel.Size = new System.Drawing.Size(42, 19);
            this.Metrolabel.TabIndex = 7;
            this.Metrolabel.Text = "Color";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ItemHeight = 23;
            this.ColorComboBox.Location = new System.Drawing.Point(603, 40);
            this.ColorComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(161, 29);
            this.ColorComboBox.TabIndex = 6;
            this.ColorComboBox.UseSelectable = true;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // SampleMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 900);
            this.Controls.Add(this.Metrolabel);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ThemeComboBox);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButton1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SampleMetro";
            this.Padding = new System.Windows.Forms.Padding(43, 120, 43, 40);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox ThemeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel Metrolabel;
        private MetroFramework.Controls.MetroComboBox ColorComboBox;
    }
}

