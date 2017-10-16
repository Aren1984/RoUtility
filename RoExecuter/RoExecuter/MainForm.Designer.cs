namespace RoExecuter {
    partial class MainForm {
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
            this.uiAccountListBox = new System.Windows.Forms.ListBox();
            this.uiResolutionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uiAccountListBox
            // 
            this.uiAccountListBox.FormattingEnabled = true;
            this.uiAccountListBox.ItemHeight = 12;
            this.uiAccountListBox.Items.AddRange(new object[] {
            "arenchien\t",
            "kenjai1984a",
            "kenjai1984b",
            "kenjai1984c",
            "kenjai1984d"});
            this.uiAccountListBox.Location = new System.Drawing.Point(12, 12);
            this.uiAccountListBox.Name = "uiAccountListBox";
            this.uiAccountListBox.Size = new System.Drawing.Size(120, 88);
            this.uiAccountListBox.TabIndex = 0;
            // 
            // uiResolutionListBox
            // 
            this.uiResolutionListBox.FormattingEnabled = true;
            this.uiResolutionListBox.ItemHeight = 12;
            this.uiResolutionListBox.Items.AddRange(new object[] {
            "640x480",
            "1024x768",
            "1600x900"});
            this.uiResolutionListBox.Location = new System.Drawing.Point(138, 12);
            this.uiResolutionListBox.Name = "uiResolutionListBox";
            this.uiResolutionListBox.Size = new System.Drawing.Size(120, 88);
            this.uiResolutionListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 413);
            this.Controls.Add(this.uiResolutionListBox);
            this.Controls.Add(this.uiAccountListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uiAccountListBox;
        private System.Windows.Forms.ListBox uiResolutionListBox;
    }
}