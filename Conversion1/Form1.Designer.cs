namespace ChamaBasinMiner
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
            this.btnEnterData = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnterData
            // 
            this.btnEnterData.Location = new System.Drawing.Point(158, 91);
            this.btnEnterData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(62, 19);
            this.btnEnterData.TabIndex = 0;
            this.btnEnterData.Text = "Next";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.Next_Click);
            this.btnEnterData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(33, 91);
            this.txtEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(76, 20);
            this.txtEntry.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnterData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.btnEnterData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Mineral Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.TextBox txtEntry;
    }
}

