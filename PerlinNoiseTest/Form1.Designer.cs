namespace PerlinNoiseTest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FIELD_WIDTH = new System.Windows.Forms.TextBox();
            this.FIELD_HEIGHT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FIELD_OCTAVES = new System.Windows.Forms.NumericUpDown();
            this.FIELD_BIAS = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_GENERATE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_OCTAVES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_BIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 381);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FIELD_WIDTH
            // 
            this.FIELD_WIDTH.Location = new System.Drawing.Point(510, 22);
            this.FIELD_WIDTH.Name = "FIELD_WIDTH";
            this.FIELD_WIDTH.Size = new System.Drawing.Size(100, 20);
            this.FIELD_WIDTH.TabIndex = 1;
            this.FIELD_WIDTH.Text = "500";
            // 
            // FIELD_HEIGHT
            // 
            this.FIELD_HEIGHT.Location = new System.Drawing.Point(510, 48);
            this.FIELD_HEIGHT.Name = "FIELD_HEIGHT";
            this.FIELD_HEIGHT.Size = new System.Drawing.Size(100, 20);
            this.FIELD_HEIGHT.TabIndex = 2;
            this.FIELD_HEIGHT.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // FIELD_OCTAVES
            // 
            this.FIELD_OCTAVES.Location = new System.Drawing.Point(510, 75);
            this.FIELD_OCTAVES.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.FIELD_OCTAVES.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FIELD_OCTAVES.Name = "FIELD_OCTAVES";
            this.FIELD_OCTAVES.Size = new System.Drawing.Size(100, 20);
            this.FIELD_OCTAVES.TabIndex = 5;
            this.FIELD_OCTAVES.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FIELD_BIAS
            // 
            this.FIELD_BIAS.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.FIELD_BIAS.Location = new System.Drawing.Point(510, 101);
            this.FIELD_BIAS.Name = "FIELD_BIAS";
            this.FIELD_BIAS.Size = new System.Drawing.Size(100, 20);
            this.FIELD_BIAS.TabIndex = 6;
            this.FIELD_BIAS.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Octaves";
            // 
            // BT_GENERATE
            // 
            this.BT_GENERATE.Location = new System.Drawing.Point(519, 412);
            this.BT_GENERATE.Name = "BT_GENERATE";
            this.BT_GENERATE.Size = new System.Drawing.Size(91, 37);
            this.BT_GENERATE.TabIndex = 9;
            this.BT_GENERATE.Text = "GENERATE";
            this.BT_GENERATE.UseVisualStyleBackColor = true;
            this.BT_GENERATE.Click += new System.EventHandler(this.BT_GENERATE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bias";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "SET/RESET SEED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_GENERATE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FIELD_BIAS);
            this.Controls.Add(this.FIELD_OCTAVES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIELD_HEIGHT);
            this.Controls.Add(this.FIELD_WIDTH);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Perlin noise test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_OCTAVES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_BIAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FIELD_WIDTH;
        private System.Windows.Forms.TextBox FIELD_HEIGHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FIELD_OCTAVES;
        private System.Windows.Forms.NumericUpDown FIELD_BIAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_GENERATE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

