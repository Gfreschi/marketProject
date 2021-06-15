
namespace marketProject.View
{
    partial class ViewHelpType
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
            this.label2 = new System.Windows.Forms.Label();
            this.HelpNotWorking = new System.Windows.Forms.Button();
            this.SoftwareDoubt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How to use software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Software not working";
            // 
            // HelpNotWorking
            // 
            this.HelpNotWorking.Location = new System.Drawing.Point(278, 211);
            this.HelpNotWorking.Name = "HelpNotWorking";
            this.HelpNotWorking.Size = new System.Drawing.Size(174, 61);
            this.HelpNotWorking.TabIndex = 2;
            this.HelpNotWorking.Text = "Option 2";
            this.HelpNotWorking.UseVisualStyleBackColor = true;
            this.HelpNotWorking.Click += new System.EventHandler(this.HelpNotWorking_Click);
            // 
            // SoftwareDoubt
            // 
            this.SoftwareDoubt.Location = new System.Drawing.Point(33, 211);
            this.SoftwareDoubt.Name = "SoftwareDoubt";
            this.SoftwareDoubt.Size = new System.Drawing.Size(171, 61);
            this.SoftwareDoubt.TabIndex = 3;
            this.SoftwareDoubt.Text = "Option 1";
            this.SoftwareDoubt.UseVisualStyleBackColor = true;
            this.SoftwareDoubt.Click += new System.EventHandler(this.SoftwareDoubt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "What kind of help do you need?";
            // 
            // ViewHelpType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoftwareDoubt);
            this.Controls.Add(this.HelpNotWorking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewHelpType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type of Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HelpNotWorking;
        private System.Windows.Forms.Button SoftwareDoubt;
        private System.Windows.Forms.Label label3;
    }
}