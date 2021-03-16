
namespace WinForm
{
    partial class UserListForm
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
            this.dgvUserDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserDataGrid
            // 
            this.dgvUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserDataGrid.Location = new System.Drawing.Point(0, 0);
            this.dgvUserDataGrid.Name = "dgvUserDataGrid";
            this.dgvUserDataGrid.RowHeadersWidth = 82;
            this.dgvUserDataGrid.RowTemplate.Height = 33;
            this.dgvUserDataGrid.Size = new System.Drawing.Size(800, 450);
            this.dgvUserDataGrid.TabIndex = 0;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUserDataGrid);
            this.Name = "UserListForm";
            this.Text = "ユーザーフォーム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserDataGrid;
    }
}