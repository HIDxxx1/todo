
namespace FileBrowser
{
    partial class Browser
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
            this.addressText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.folderList = new System.Windows.Forms.ListView();
            this.contentText = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressText
            // 
            this.addressText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressText.Location = new System.Drawing.Point(6, 10);
            this.addressText.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(424, 19);
            this.addressText.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 34);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.folderList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.contentText);
            this.splitContainer1.Size = new System.Drawing.Size(424, 299);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // folderList
            // 
            this.folderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.folderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderList.HideSelection = false;
            this.folderList.Location = new System.Drawing.Point(0, 0);
            this.folderList.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(121, 299);
            this.folderList.TabIndex = 0;
            this.folderList.UseCompatibleStateImageBehavior = false;
            this.folderList.View = System.Windows.Forms.View.Details;
            this.folderList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.folderList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.folderList_MouseDoubleClick);
            // 
            // contentText
            // 
            this.contentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentText.Location = new System.Drawing.Point(0, 0);
            this.contentText.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.contentText.Multiline = true;
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(301, 299);
            this.contentText.TabIndex = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "種類";
            this.columnHeader2.Width = 40;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 340);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.addressText);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Browser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView folderList;
        private System.Windows.Forms.TextBox contentText;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

