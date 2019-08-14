namespace ProcessNote
{
    partial class Threads
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
            this.threadListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // threadListView
            // 
            this.threadListView.HideSelection = false;
            this.threadListView.Location = new System.Drawing.Point(21, 12);
            this.threadListView.Name = "threadListView";
            this.threadListView.Size = new System.Drawing.Size(511, 110);
            this.threadListView.TabIndex = 0;
            this.threadListView.UseCompatibleStateImageBehavior = false;
            // 
            // Threads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 155);
            this.Controls.Add(this.threadListView);
            this.Name = "Threads";
            this.Text = "Threads";
            this.Load += new System.EventHandler(this.Threads_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView threadListView;
    }
}