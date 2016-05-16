namespace WindowsFormsApplication2
{
    partial class paintJobEstimator
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
            this.txtSquareFootage = new System.Windows.Forms.TextBox();
            this.lblPaintGallons = new System.Windows.Forms.Label();
            this.lblBillableHours = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSquareFootage = new System.Windows.Forms.Label();
            this.lblPaintCost = new System.Windows.Forms.Label();
            this.lblLaborCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblPaintGallonsResults = new System.Windows.Forms.Label();
            this.lblPaintCostResults = new System.Windows.Forms.Label();
            this.lblBillableHrsResults = new System.Windows.Forms.Label();
            this.lblLaborCostResults = new System.Windows.Forms.Label();
            this.lblTotalCostResults = new System.Windows.Forms.Label();
            this.lblPaintPrice = new System.Windows.Forms.Label();
            this.txtPaintPrice = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSquareFootage
            // 
            this.txtSquareFootage.Location = new System.Drawing.Point(158, 34);
            this.txtSquareFootage.Name = "txtSquareFootage";
            this.txtSquareFootage.Size = new System.Drawing.Size(100, 20);
            this.txtSquareFootage.TabIndex = 0;
            // 
            // lblPaintGallons
            // 
            this.lblPaintGallons.AutoSize = true;
            this.lblPaintGallons.Location = new System.Drawing.Point(76, 175);
            this.lblPaintGallons.Name = "lblPaintGallons";
            this.lblPaintGallons.Size = new System.Drawing.Size(83, 13);
            this.lblPaintGallons.TabIndex = 2;
            this.lblPaintGallons.Text = "Gallons of paint:";
            // 
            // lblBillableHours
            // 
            this.lblBillableHours.AutoSize = true;
            this.lblBillableHours.Location = new System.Drawing.Point(85, 201);
            this.lblBillableHours.Name = "lblBillableHours";
            this.lblBillableHours.Size = new System.Drawing.Size(74, 13);
            this.lblBillableHours.TabIndex = 3;
            this.lblBillableHours.Text = "Billable Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Paint Job Estimator";
            // 
            // lblSquareFootage
            // 
            this.lblSquareFootage.AutoSize = true;
            this.lblSquareFootage.Location = new System.Drawing.Point(3, 41);
            this.lblSquareFootage.Name = "lblSquareFootage";
            this.lblSquareFootage.Size = new System.Drawing.Size(150, 13);
            this.lblSquareFootage.TabIndex = 5;
            this.lblSquareFootage.Text = "Enter the total square footage:";
            // 
            // lblPaintCost
            // 
            this.lblPaintCost.AutoSize = true;
            this.lblPaintCost.Location = new System.Drawing.Point(95, 188);
            this.lblPaintCost.Name = "lblPaintCost";
            this.lblPaintCost.Size = new System.Drawing.Size(58, 13);
            this.lblPaintCost.TabIndex = 6;
            this.lblPaintCost.Text = "Paint Cost:";
            // 
            // lblLaborCost
            // 
            this.lblLaborCost.AutoSize = true;
            this.lblLaborCost.Location = new System.Drawing.Point(85, 214);
            this.lblLaborCost.Name = "lblLaborCost";
            this.lblLaborCost.Size = new System.Drawing.Size(73, 13);
            this.lblLaborCost.TabIndex = 7;
            this.lblLaborCost.Text = "Cost of Labor:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(100, 227);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(58, 13);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblPaintGallonsResults
            // 
            this.lblPaintGallonsResults.AutoSize = true;
            this.lblPaintGallonsResults.Location = new System.Drawing.Point(165, 175);
            this.lblPaintGallonsResults.Name = "lblPaintGallonsResults";
            this.lblPaintGallonsResults.Size = new System.Drawing.Size(13, 13);
            this.lblPaintGallonsResults.TabIndex = 9;
            this.lblPaintGallonsResults.Text = "0";
            // 
            // lblPaintCostResults
            // 
            this.lblPaintCostResults.AutoSize = true;
            this.lblPaintCostResults.Location = new System.Drawing.Point(165, 188);
            this.lblPaintCostResults.Name = "lblPaintCostResults";
            this.lblPaintCostResults.Size = new System.Drawing.Size(13, 13);
            this.lblPaintCostResults.TabIndex = 10;
            this.lblPaintCostResults.Text = "0";
            // 
            // lblBillableHrsResults
            // 
            this.lblBillableHrsResults.AutoSize = true;
            this.lblBillableHrsResults.Location = new System.Drawing.Point(165, 201);
            this.lblBillableHrsResults.Name = "lblBillableHrsResults";
            this.lblBillableHrsResults.Size = new System.Drawing.Size(13, 13);
            this.lblBillableHrsResults.TabIndex = 11;
            this.lblBillableHrsResults.Text = "0";
            // 
            // lblLaborCostResults
            // 
            this.lblLaborCostResults.AutoSize = true;
            this.lblLaborCostResults.Location = new System.Drawing.Point(165, 214);
            this.lblLaborCostResults.Name = "lblLaborCostResults";
            this.lblLaborCostResults.Size = new System.Drawing.Size(13, 13);
            this.lblLaborCostResults.TabIndex = 12;
            this.lblLaborCostResults.Text = "0";
            // 
            // lblTotalCostResults
            // 
            this.lblTotalCostResults.AutoSize = true;
            this.lblTotalCostResults.Location = new System.Drawing.Point(165, 227);
            this.lblTotalCostResults.Name = "lblTotalCostResults";
            this.lblTotalCostResults.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCostResults.TabIndex = 13;
            this.lblTotalCostResults.Text = "0";
            // 
            // lblPaintPrice
            // 
            this.lblPaintPrice.AutoSize = true;
            this.lblPaintPrice.Location = new System.Drawing.Point(37, 58);
            this.lblPaintPrice.Name = "lblPaintPrice";
            this.lblPaintPrice.Size = new System.Drawing.Size(115, 13);
            this.lblPaintPrice.TabIndex = 14;
            this.lblPaintPrice.Text = "Price of 1 Gallon Paint:";
            // 
            // txtPaintPrice
            // 
            this.txtPaintPrice.Location = new System.Drawing.Point(158, 55);
            this.txtPaintPrice.Name = "txtPaintPrice";
            this.txtPaintPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPaintPrice.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(103, 95);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // paintJobEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPaintPrice);
            this.Controls.Add(this.lblPaintPrice);
            this.Controls.Add(this.lblTotalCostResults);
            this.Controls.Add(this.lblLaborCostResults);
            this.Controls.Add(this.lblBillableHrsResults);
            this.Controls.Add(this.lblPaintCostResults);
            this.Controls.Add(this.lblPaintGallonsResults);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblLaborCost);
            this.Controls.Add(this.lblPaintCost);
            this.Controls.Add(this.lblSquareFootage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBillableHours);
            this.Controls.Add(this.lblPaintGallons);
            this.Controls.Add(this.txtSquareFootage);
            this.Name = "paintJobEstimator";
            this.Text = "Paint Job Estimator v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquareFootage;
        private System.Windows.Forms.Label lblPaintGallons;
        private System.Windows.Forms.Label lblBillableHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSquareFootage;
        private System.Windows.Forms.Label lblPaintCost;
        private System.Windows.Forms.Label lblLaborCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblPaintGallonsResults;
        private System.Windows.Forms.Label lblPaintCostResults;
        private System.Windows.Forms.Label lblBillableHrsResults;
        private System.Windows.Forms.Label lblLaborCostResults;
        private System.Windows.Forms.Label lblTotalCostResults;
        private System.Windows.Forms.Label lblPaintPrice;
        private System.Windows.Forms.TextBox txtPaintPrice;
        private System.Windows.Forms.Button btnSubmit;
    }
}

