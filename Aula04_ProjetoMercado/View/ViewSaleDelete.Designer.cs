
namespace marketProject.View
{
    partial class ViewSaleDelete
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
            this.textBoxSaleCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoncConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSaleCode
            // 
            this.textBoxSaleCode.Location = new System.Drawing.Point(212, 56);
            this.textBoxSaleCode.Name = "textBoxSaleCode";
            this.textBoxSaleCode.Size = new System.Drawing.Size(267, 26);
            this.textBoxSaleCode.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sale Code";
            // 
            // buttoncConfirm
            // 
            this.buttoncConfirm.Location = new System.Drawing.Point(247, 159);
            this.buttoncConfirm.Name = "buttoncConfirm";
            this.buttoncConfirm.Size = new System.Drawing.Size(239, 65);
            this.buttoncConfirm.TabIndex = 18;
            this.buttoncConfirm.Text = "CONFIRM";
            this.buttoncConfirm.UseVisualStyleBackColor = true;
            this.buttoncConfirm.Click += new System.EventHandler(this.buttoncConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(19, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(222, 65);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ViewSaleDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 236);
            this.ControlBox = false;
            this.Controls.Add(this.buttoncConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSaleCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewSaleDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete a Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSaleCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoncConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}