
namespace WinForm
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserSave
            // 
            this.btnUserSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserSave.Location = new System.Drawing.Point(0, 0);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(800, 84);
            this.btnUserSave.TabIndex = 0;
            this.btnUserSave.Text = "ユーザー登録";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserForm
            // 
            this.btnUserForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserForm.Location = new System.Drawing.Point(0, 84);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(800, 84);
            this.btnUserForm.TabIndex = 1;
            this.btnUserForm.Text = "ユーザーリスト";
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.btnUserSave);
            this.Name = "MenuForm";
            this.Text = "メニュ＝";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserForm;
    }
}