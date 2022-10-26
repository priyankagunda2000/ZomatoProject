namespace billpage
{
    partial class BillPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPage));
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.TextBox();
            this.tax = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.items = new System.Windows.Forms.TextBox();
            this.transactionid = new System.Windows.Forms.TextBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_invoice = new System.Windows.Forms.Label();
            this.lbl_Orderid = new System.Windows.Forms.Label();
            this.lbl_transactionid = new System.Windows.Forms.Label();
            this.orderid = new System.Windows.Forms.TextBox();
            this.lbl_items = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_totalprice = new System.Windows.Forms.Label();
            this.tax_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_reset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1071, 624);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(171, 52);
            this.btn_reset.TabIndex = 33;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_submit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(818, 624);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(172, 52);
            this.btn_submit.TabIndex = 32;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // totalprice
            // 
            this.totalprice.Location = new System.Drawing.Point(769, 428);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(488, 26);
            this.totalprice.TabIndex = 31;
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(769, 364);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(488, 26);
            this.tax.TabIndex = 30;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(769, 297);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(488, 26);
            this.quantity.TabIndex = 29;
            // 
            // items
            // 
            this.items.Location = new System.Drawing.Point(769, 230);
            this.items.Multiline = true;
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(488, 26);
            this.items.TabIndex = 28;
            // 
            // transactionid
            // 
            this.transactionid.Location = new System.Drawing.Point(769, 173);
            this.transactionid.Name = "transactionid";
            this.transactionid.Size = new System.Drawing.Size(488, 26);
            this.transactionid.TabIndex = 27;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(331, 297);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(129, 29);
            this.lbl_Quantity.TabIndex = 26;
            this.lbl_Quantity.Text = "Quantity";
            this.lbl_Quantity.Click += new System.EventHandler(this.lbl_Quantity_Click);
            // 
            // lbl_invoice
            // 
            this.lbl_invoice.AutoSize = true;
            this.lbl_invoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_invoice.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoice.Location = new System.Drawing.Point(894, 0);
            this.lbl_invoice.Name = "lbl_invoice";
            this.lbl_invoice.Size = new System.Drawing.Size(225, 78);
            this.lbl_invoice.TabIndex = 22;
            this.lbl_invoice.Text = "Invoice";
            this.lbl_invoice.Click += new System.EventHandler(this.lbl_invoice_Click);
            // 
            // lbl_Orderid
            // 
            this.lbl_Orderid.AutoSize = true;
            this.lbl_Orderid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Orderid.Location = new System.Drawing.Point(320, 112);
            this.lbl_Orderid.Name = "lbl_Orderid";
            this.lbl_Orderid.Size = new System.Drawing.Size(131, 29);
            this.lbl_Orderid.TabIndex = 19;
            this.lbl_Orderid.Text = "Order ID";
            // 
            // lbl_transactionid
            // 
            this.lbl_transactionid.AutoSize = true;
            this.lbl_transactionid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionid.Location = new System.Drawing.Point(243, 168);
            this.lbl_transactionid.Name = "lbl_transactionid";
            this.lbl_transactionid.Size = new System.Drawing.Size(208, 29);
            this.lbl_transactionid.TabIndex = 21;
            this.lbl_transactionid.Text = "Transaction Id";
            this.lbl_transactionid.Click += new System.EventHandler(this.lbl_transactionid_Click);
            // 
            // orderid
            // 
            this.orderid.Location = new System.Drawing.Point(769, 117);
            this.orderid.Name = "orderid";
            this.orderid.Size = new System.Drawing.Size(488, 26);
            this.orderid.TabIndex = 20;
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items.Location = new System.Drawing.Point(359, 227);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(92, 29);
            this.lbl_items.TabIndex = 24;
            this.lbl_items.Text = "Items";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tax.Location = new System.Drawing.Point(-69, 376);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(61, 29);
            this.lbl_tax.TabIndex = 23;
            this.lbl_tax.Text = "Tax";
            // 
            // lbl_totalprice
            // 
            this.lbl_totalprice.AutoSize = true;
            this.lbl_totalprice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalprice.Location = new System.Drawing.Point(304, 423);
            this.lbl_totalprice.Name = "lbl_totalprice";
            this.lbl_totalprice.Size = new System.Drawing.Size(156, 29);
            this.lbl_totalprice.TabIndex = 25;
            this.lbl_totalprice.Text = "Total Price";
            // 
            // tax_lbl
            // 
            this.tax_lbl.AutoSize = true;
            this.tax_lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_lbl.Location = new System.Drawing.Point(399, 364);
            this.tax_lbl.Name = "tax_lbl";
            this.tax_lbl.Size = new System.Drawing.Size(61, 29);
            this.tax_lbl.TabIndex = 34;
            this.tax_lbl.Text = "Tax";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1382, 715);
            this.Controls.Add(this.tax_lbl);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.items);
            this.Controls.Add(this.transactionid);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_invoice);
            this.Controls.Add(this.lbl_Orderid);
            this.Controls.Add(this.lbl_transactionid);
            this.Controls.Add(this.orderid);
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_totalprice);
            this.Name = "Form1";
            this.Text = "Billpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox totalprice;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox items;
        private System.Windows.Forms.TextBox transactionid;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_invoice;
        private System.Windows.Forms.Label lbl_Orderid;
        private System.Windows.Forms.Label lbl_transactionid;
        private System.Windows.Forms.TextBox orderid;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_totalprice;
        private System.Windows.Forms.Label tax_lbl;
    }
}

