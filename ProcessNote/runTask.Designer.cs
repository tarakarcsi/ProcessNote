namespace ProcessNote
{
    partial class runTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.runTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(62, 22);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(439, 20);
            this.txtOpen.TabIndex = 1;
            this.txtOpen.TextChanged += new System.EventHandler(this.txtOpen_TextChanged);
            // 
            // runTaskButton
            // 
            this.runTaskButton.Location = new System.Drawing.Point(426, 48);
            this.runTaskButton.Name = "runTaskButton";
            this.runTaskButton.Size = new System.Drawing.Size(75, 23);
            this.runTaskButton.TabIndex = 2;
            this.runTaskButton.Text = "Run";
            this.runTaskButton.UseVisualStyleBackColor = true;
            this.runTaskButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // runTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 104);
            this.Controls.Add(this.runTaskButton);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.label1);
            this.Name = "runTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Button runTaskButton;
    }
}