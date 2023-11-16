namespace Orders
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
            this.labelQuantityOrdered = new System.Windows.Forms.Label();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxQuantity = new System.Windows.Forms.ListBox();
            this.textBoxQuantityNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelQuantityOrdered
            // 
            this.labelQuantityOrdered.AutoSize = true;
            this.labelQuantityOrdered.Location = new System.Drawing.Point(129, 75);
            this.labelQuantityOrdered.Name = "labelQuantityOrdered";
            this.labelQuantityOrdered.Size = new System.Drawing.Size(168, 25);
            this.labelQuantityOrdered.TabIndex = 0;
            this.labelQuantityOrdered.Text = "Quantity Ordered:";
            // 
            // buttonPlace
            // 
            this.buttonPlace.Location = new System.Drawing.Point(74, 580);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(129, 88);
            this.buttonPlace.TabIndex = 1;
            this.buttonPlace.Text = "Place Order (Write)";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(279, 580);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(129, 88);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "Display Order (Read)";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(503, 580);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(129, 88);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(739, 580);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 88);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxQuantity
            // 
            this.listBoxQuantity.FormattingEnabled = true;
            this.listBoxQuantity.ItemHeight = 24;
            this.listBoxQuantity.Location = new System.Drawing.Point(234, 191);
            this.listBoxQuantity.Name = "listBoxQuantity";
            this.listBoxQuantity.Size = new System.Drawing.Size(398, 292);
            this.listBoxQuantity.TabIndex = 6;
            // 
            // textBoxQuantityNum
            // 
            this.textBoxQuantityNum.Location = new System.Drawing.Point(375, 75);
            this.textBoxQuantityNum.Name = "textBoxQuantityNum";
            this.textBoxQuantityNum.Size = new System.Drawing.Size(100, 29);
            this.textBoxQuantityNum.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 680);
            this.Controls.Add(this.textBoxQuantityNum);
            this.Controls.Add(this.listBoxQuantity);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.labelQuantityOrdered);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuantityOrdered;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxQuantity;
        private System.Windows.Forms.TextBox textBoxQuantityNum;
    }
}

