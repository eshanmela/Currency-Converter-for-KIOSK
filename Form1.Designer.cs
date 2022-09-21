namespace CurrenyUSD
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
            this.components = new System.ComponentModel.Container();
            this.btnRupees = new System.Windows.Forms.Button();
            this.lblLKR = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClosd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRupees
            // 
            this.btnRupees.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRupees.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRupees.ForeColor = System.Drawing.Color.White;
            this.btnRupees.Location = new System.Drawing.Point(5, 3);
            this.btnRupees.Name = "btnRupees";
            this.btnRupees.Size = new System.Drawing.Size(369, 94);
            this.btnRupees.TabIndex = 9;
            this.btnRupees.Text = "Get Rupees";
            this.btnRupees.UseVisualStyleBackColor = false;
            this.btnRupees.Click += new System.EventHandler(this.btnRupees_Click);
            // 
            // lblLKR
            // 
            this.lblLKR.AutoSize = true;
            this.lblLKR.BackColor = System.Drawing.Color.Transparent;
            this.lblLKR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLKR.ForeColor = System.Drawing.Color.Blue;
            this.lblLKR.Location = new System.Drawing.Point(595, 431);
            this.lblLKR.Name = "lblLKR";
            this.lblLKR.Size = new System.Drawing.Size(55, 37);
            this.lblLKR.TabIndex = 8;
            this.lblLKR.Text = "00";
            this.lblLKR.Click += new System.EventHandler(this.lblLKR_Click);
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.BackColor = System.Drawing.Color.Transparent;
            this.lblUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD.ForeColor = System.Drawing.Color.Blue;
            this.lblUSD.Location = new System.Drawing.Point(595, 334);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(55, 37);
            this.lblUSD.TabIndex = 7;
            this.lblUSD.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(274, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sri Lanka Rupees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(274, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserted USD";
            // 
            // btnClosd
            // 
            this.btnClosd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClosd.BackgroundImage = global::CurrenyUSD.Properties.Resources._001918_black_inlay_steel_square_icon_media_a_media31_back;
            this.btnClosd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClosd.Location = new System.Drawing.Point(885, 536);
            this.btnClosd.Name = "btnClosd";
            this.btnClosd.Size = new System.Drawing.Size(90, 74);
            this.btnClosd.TabIndex = 10;
            this.btnClosd.UseVisualStyleBackColor = false;
            this.btnClosd.Click += new System.EventHandler(this.btnClosd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(95, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(833, 55);
            this.label2.TabIndex = 11;
            this.label2.Text = "Insert USD to get Sri lankan Rupees";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.btnRupees);
            this.panel1.Location = new System.Drawing.Point(271, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 100);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CurrenyUSD.Properties.Resources._05;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClosd);
            this.Controls.Add(this.lblLKR);
            this.Controls.Add(this.lblUSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRupees;
        private System.Windows.Forms.Label lblLKR;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClosd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

