
namespace marketProject.View
{
    partial class ViewSaleUpdate
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
            this.textBoxPricePaid = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.buttoncConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaleCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPricePaid
            // 
            this.textBoxPricePaid.Location = new System.Drawing.Point(212, 156);
            this.textBoxPricePaid.Name = "textBoxPricePaid";
            this.textBoxPricePaid.Size = new System.Drawing.Size(267, 26);
            this.textBoxPricePaid.TabIndex = 19;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(212, 124);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(267, 26);
            this.textBoxAmount.TabIndex = 18;
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Location = new System.Drawing.Point(212, 92);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(267, 26);
            this.textBoxClientCode.TabIndex = 17;
            // 
            // buttoncConfirm
            // 
            this.buttoncConfirm.Location = new System.Drawing.Point(240, 249);
            this.buttoncConfirm.Name = "buttoncConfirm";
            this.buttoncConfirm.Size = new System.Drawing.Size(239, 65);
            this.buttoncConfirm.TabIndex = 16;
            this.buttoncConfirm.Text = "CONFIRM";
            this.buttoncConfirm.UseVisualStyleBackColor = true;
            this.buttoncConfirm.Click += new System.EventHandler(this.buttoncConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(222, 65);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(212, 60);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(267, 26);
            this.textBoxProductCode.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Client Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Code";
            // 
            // textBoxSaleCode
            // 
            this.textBoxSaleCode.Location = new System.Drawing.Point(212, 28);
            this.textBoxSaleCode.Name = "textBoxSaleCode";
            this.textBoxSaleCode.Size = new System.Drawing.Size(267, 26);
            this.textBoxSaleCode.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sale Code";
            // 
            // ViewSaleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 324);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxSaleCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPricePaid);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.buttoncConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxProductCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewSaleUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update a Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPricePaid;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.Button buttoncConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaleCode;
        private System.Windows.Forms.Label label5;
    }
}