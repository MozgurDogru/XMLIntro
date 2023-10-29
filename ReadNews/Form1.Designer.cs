namespace ReadNews
{
    partial class Form1
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
            this.lbxTitle = new System.Windows.Forms.ListBox();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.wbContent = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lbxTitle
            // 
            this.lbxTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxTitle.FormattingEnabled = true;
            this.lbxTitle.ItemHeight = 25;
            this.lbxTitle.Location = new System.Drawing.Point(0, 0);
            this.lbxTitle.Name = "lbxTitle";
            this.lbxTitle.Size = new System.Drawing.Size(297, 450);
            this.lbxTitle.TabIndex = 0;
            this.lbxTitle.SelectedIndexChanged += new System.EventHandler(this.lbxTitle_SelectedIndexChanged);
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtDesc.Location = new System.Drawing.Point(297, 0);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(503, 96);
            this.rtxtDesc.TabIndex = 1;
            this.rtxtDesc.Text = "";
            // 
            // wbContent
            // 
            this.wbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbContent.Location = new System.Drawing.Point(297, 96);
            this.wbContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbContent.Name = "wbContent";
            this.wbContent.Size = new System.Drawing.Size(503, 354);
            this.wbContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbContent);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.lbxTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTitle;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.WebBrowser wbContent;
    }
}

