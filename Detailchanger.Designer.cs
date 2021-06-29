
namespace Thisisarpctest
{
    partial class Detailchanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailchanger));
            this.Details = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.LableName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(21, 67);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(156, 20);
            this.Details.TabIndex = 0;
            this.Details.Text = "Game Details";
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(338, 67);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(197, 20);
            this.State.TabIndex = 1;
            this.State.Text = "Game State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SgtGigdi On YouTube";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(436, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "This is still in testing";
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.DimGray;
            this.Change.FlatAppearance.BorderSize = 0;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Change.Location = new System.Drawing.Point(204, 100);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(105, 23);
            this.Change.TabIndex = 4;
            this.Change.Text = "Change Status!";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableName.ForeColor = System.Drawing.SystemColors.Control;
            this.LableName.Location = new System.Drawing.Point(124, 9);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(301, 37);
            this.LableName.TabIndex = 5;
            this.LableName.Text = "SgtGigdi RPC Changer";
            // 
            // Detailchanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(537, 147);
            this.Controls.Add(this.LableName);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Details);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detailchanger";
            this.Text = "SgtGigdi RPC Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label LableName;
    }
}

