
namespace shop_system_design_patterns
{
    partial class FrenchutoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.eventLogListBox = new System.Windows.Forms.ListBox();
			this.timeSkipButton = new System.Windows.Forms.Button();
			this.clearLogButton = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// eventLogListBox
			// 
			this.eventLogListBox.FormattingEnabled = true;
			this.eventLogListBox.ItemHeight = 15;
			this.eventLogListBox.Location = new System.Drawing.Point(12, 207);
			this.eventLogListBox.Name = "eventLogListBox";
			this.eventLogListBox.Size = new System.Drawing.Size(587, 454);
			this.eventLogListBox.TabIndex = 0;
			this.eventLogListBox.SelectedIndexChanged += new System.EventHandler(this.EventLogListBox_SelectedIndexChanged);
			// 
			// timeSkipButton
			// 
			this.timeSkipButton.Location = new System.Drawing.Point(605, 12);
			this.timeSkipButton.Name = "timeSkipButton";
			this.timeSkipButton.Size = new System.Drawing.Size(547, 324);
			this.timeSkipButton.TabIndex = 1;
			this.timeSkipButton.Text = "TIME SKIP";
			this.timeSkipButton.UseVisualStyleBackColor = true;
			this.timeSkipButton.Click += new System.EventHandler(this.TimeSkip_Click);
			// 
			// clearLogButton
			// 
			this.clearLogButton.Location = new System.Drawing.Point(605, 342);
			this.clearLogButton.Name = "clearLogButton";
			this.clearLogButton.Size = new System.Drawing.Size(547, 319);
			this.clearLogButton.TabIndex = 2;
			this.clearLogButton.Text = "CLEAR LOG";
			this.clearLogButton.UseVisualStyleBackColor = true;
			this.clearLogButton.Click += new System.EventHandler(this.ClearEventLog_Click);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(587, 189);
			this.treeView1.TabIndex = 3;
			// 
			// FrenchutoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1164, 681);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.clearLogButton);
			this.Controls.Add(this.timeSkipButton);
			this.Controls.Add(this.eventLogListBox);
			this.Name = "FrenchutoForm";
			this.Text = "Frenchuto Store";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.ListBox eventLogListBox;
		private System.Windows.Forms.Button timeSkipButton;
		private System.Windows.Forms.Button clearLogButton;
		private System.Windows.Forms.TreeView treeView1;
	}
}

