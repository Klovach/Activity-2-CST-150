namespace Activity_2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblNewWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtNewWeight = new System.Windows.Forms.TextBox();
            this.btnKG = new System.Windows.Forms.Button();
            this.btnLBS = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(95, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Weight Conversion Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(51, 68);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(80, 16);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Your Weight";
            // 
            // lblNewWeight
            // 
            this.lblNewWeight.AutoSize = true;
            this.lblNewWeight.Location = new System.Drawing.Point(51, 96);
            this.lblNewWeight.Name = "lblNewWeight";
            this.lblNewWeight.Size = new System.Drawing.Size(80, 16);
            this.lblNewWeight.TabIndex = 2;
            this.lblNewWeight.Text = "Converts To";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(139, 68);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 3;
            // 
            // txtNewWeight
            // 
            this.txtNewWeight.Location = new System.Drawing.Point(137, 96);
            this.txtNewWeight.Name = "txtNewWeight";
            this.txtNewWeight.Size = new System.Drawing.Size(100, 22);
            this.txtNewWeight.TabIndex = 4;
            // 
            // btnKG
            // 
            this.btnKG.Location = new System.Drawing.Point(245, 66);
            this.btnKG.Name = "btnKG";
            this.btnKG.Size = new System.Drawing.Size(99, 23);
            this.btnKG.TabIndex = 5;
            this.btnKG.Text = "Lbs to KG";
            this.btnKG.UseVisualStyleBackColor = true;
            this.btnKG.Click += new System.EventHandler(this.btnKG_Click);
            // 
            // btnLBS
            // 
            this.btnLBS.Location = new System.Drawing.Point(245, 95);
            this.btnLBS.Name = "btnLBS";
            this.btnLBS.Size = new System.Drawing.Size(99, 23);
            this.btnLBS.TabIndex = 6;
            this.btnLBS.Text = "KG to Lbs";
            this.btnLBS.UseVisualStyleBackColor = true;
            this.btnLBS.Click += new System.EventHandler(this.btnLBS_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(135, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 33);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 233);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLBS);
            this.Controls.Add(this.btnKG);
            this.Controls.Add(this.txtNewWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblNewWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Activity 2 - Grand Canyon University";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblNewWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtNewWeight;
        private System.Windows.Forms.Button btnKG;
        private System.Windows.Forms.Button btnLBS;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

