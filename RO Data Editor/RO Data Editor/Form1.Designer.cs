namespace RO_Data_Editor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uiFileTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // uiFileTreeView
            // 
            this.uiFileTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiFileTreeView.Location = new System.Drawing.Point(0, 0);
            this.uiFileTreeView.Name = "uiFileTreeView";
            this.uiFileTreeView.Size = new System.Drawing.Size(215, 537);
            this.uiFileTreeView.TabIndex = 0;
            this.uiFileTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.uiFileTreeView_BeforeSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 537);
            this.Controls.Add(this.uiFileTreeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView uiFileTreeView;
    }
}

