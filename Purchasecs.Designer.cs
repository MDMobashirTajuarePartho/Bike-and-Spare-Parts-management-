namespace BikeParts
{
    partial class Purchasecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchasecs));
            this.BuyBike = new System.Windows.Forms.Button();
            this.BuyParts = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyBike
            // 
            this.BuyBike.BackColor = System.Drawing.SystemColors.Highlight;
            this.BuyBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBike.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBike.ForeColor = System.Drawing.SystemColors.Control;
            this.BuyBike.Location = new System.Drawing.Point(808, 670);
            this.BuyBike.Margin = new System.Windows.Forms.Padding(4);
            this.BuyBike.Name = "BuyBike";
            this.BuyBike.Size = new System.Drawing.Size(237, 73);
            this.BuyBike.TabIndex = 32;
            this.BuyBike.Text = "Buy Bike";
            this.BuyBike.UseVisualStyleBackColor = false;
            this.BuyBike.Click += new System.EventHandler(this.BuyBike_Click);
            // 
            // BuyParts
            // 
            this.BuyParts.BackColor = System.Drawing.SystemColors.Highlight;
            this.BuyParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyParts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyParts.ForeColor = System.Drawing.SystemColors.Control;
            this.BuyParts.Location = new System.Drawing.Point(113, 670);
            this.BuyParts.Margin = new System.Windows.Forms.Padding(4);
            this.BuyParts.Name = "BuyParts";
            this.BuyParts.Size = new System.Drawing.Size(295, 73);
            this.BuyParts.TabIndex = 33;
            this.BuyParts.Text = "Buy Parts";
            this.BuyParts.UseVisualStyleBackColor = false;
            this.BuyParts.Click += new System.EventHandler(this.BuyParts_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.IndianRed;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.Control;
            this.Back.Location = new System.Drawing.Point(476, 689);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(218, 54);
            this.Back.TabIndex = 34;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(605, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(577, 640);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Purchasecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 782);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.BuyParts);
            this.Controls.Add(this.BuyBike);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Purchasecs";
            this.Text = "Purchasecs";
            this.Load += new System.EventHandler(this.Purchasecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BuyBike;
        private System.Windows.Forms.Button BuyParts;
        private System.Windows.Forms.Button Back;
    }
}