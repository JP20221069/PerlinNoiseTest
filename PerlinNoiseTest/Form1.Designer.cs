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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.GB_Picture = new System.Windows.Forms.GroupBox();
            this.PNL_PictureBoxPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_Controls = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LB_STATUS = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PICTURE_STATUS = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_OCTAVES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_BIAS)).BeginInit();
            this.GB_Picture.SuspendLayout();
            this.PNL_PictureBoxPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GB_Controls.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 467);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FIELD_WIDTH
            // 
            this.FIELD_WIDTH.Location = new System.Drawing.Point(57, 13);
            this.FIELD_WIDTH.Name = "FIELD_WIDTH";
            this.FIELD_WIDTH.Size = new System.Drawing.Size(100, 20);
            this.FIELD_WIDTH.TabIndex = 1;
            this.FIELD_WIDTH.Text = "500";
            // 
            // FIELD_HEIGHT
            // 
            this.FIELD_HEIGHT.Location = new System.Drawing.Point(57, 39);
            this.FIELD_HEIGHT.Name = "FIELD_HEIGHT";
            this.FIELD_HEIGHT.Size = new System.Drawing.Size(100, 20);
            this.FIELD_HEIGHT.TabIndex = 2;
            this.FIELD_HEIGHT.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // FIELD_OCTAVES
            // 
            this.FIELD_OCTAVES.Location = new System.Drawing.Point(57, 66);
            this.FIELD_OCTAVES.Maximum = new decimal(new int[] {
            9,
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
            this.FIELD_BIAS.Location = new System.Drawing.Point(57, 92);
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
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Octaves";
            // 
            // BT_GENERATE
            // 
            this.BT_GENERATE.Location = new System.Drawing.Point(15, 161);
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
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bias";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "SET/RESET SEED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GB_Picture
            // 
            this.GB_Picture.Controls.Add(this.PNL_PictureBoxPanel);
            this.GB_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Picture.Location = new System.Drawing.Point(0, 0);
            this.GB_Picture.Name = "GB_Picture";
            this.GB_Picture.Size = new System.Drawing.Size(517, 486);
            this.GB_Picture.TabIndex = 14;
            this.GB_Picture.TabStop = false;
            this.GB_Picture.Text = "View";
            // 
            // PNL_PictureBoxPanel
            // 
            this.PNL_PictureBoxPanel.Controls.Add(this.pictureBox1);
            this.PNL_PictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_PictureBoxPanel.Location = new System.Drawing.Point(3, 16);
            this.PNL_PictureBoxPanel.Name = "PNL_PictureBoxPanel";
            this.PNL_PictureBoxPanel.Size = new System.Drawing.Size(511, 467);
            this.PNL_PictureBoxPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveAsToolStripMenuItem.Text = "Save As . . .";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GB_Picture);
            this.panel1.Controls.Add(this.GB_Controls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 486);
            this.panel1.TabIndex = 16;
            // 
            // GB_Controls
            // 
            this.GB_Controls.Controls.Add(this.label1);
            this.GB_Controls.Controls.Add(this.FIELD_WIDTH);
            this.GB_Controls.Controls.Add(this.FIELD_HEIGHT);
            this.GB_Controls.Controls.Add(this.BT_GENERATE);
            this.GB_Controls.Controls.Add(this.button1);
            this.GB_Controls.Controls.Add(this.label2);
            this.GB_Controls.Controls.Add(this.label4);
            this.GB_Controls.Controls.Add(this.FIELD_OCTAVES);
            this.GB_Controls.Controls.Add(this.FIELD_BIAS);
            this.GB_Controls.Controls.Add(this.label3);
            this.GB_Controls.Dock = System.Windows.Forms.DockStyle.Right;
            this.GB_Controls.Location = new System.Drawing.Point(517, 0);
            this.GB_Controls.Name = "GB_Controls";
            this.GB_Controls.Size = new System.Drawing.Size(311, 486);
            this.GB_Controls.TabIndex = 17;
            this.GB_Controls.TabStop = false;
            this.GB_Controls.Text = "Controls";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LB_STATUS,
            this.PICTURE_STATUS});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LB_STATUS
            // 
            this.LB_STATUS.Name = "LB_STATUS";
            this.LB_STATUS.Size = new System.Drawing.Size(57, 17);
            this.LB_STATUS.Text = "Ready . . .";
            // 
            // PICTURE_STATUS
            // 
            this.PICTURE_STATUS.Image = ((System.Drawing.Image)(resources.GetObject("PICTURE_STATUS.Image")));
            this.PICTURE_STATUS.Name = "PICTURE_STATUS";
            this.PICTURE_STATUS.Size = new System.Drawing.Size(16, 17);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PIC_ERROR.png");
            this.imageList1.Images.SetKeyName(1, "PIC_OK.png");
            this.imageList1.Images.SetKeyName(2, "PIC_QUESTION.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Perlin Noise Bitmap Maker V1.2.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_OCTAVES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIELD_BIAS)).EndInit();
            this.GB_Picture.ResumeLayout(false);
            this.PNL_PictureBoxPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GB_Controls.ResumeLayout(false);
            this.GB_Controls.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox GB_Picture;
        private System.Windows.Forms.Panel PNL_PictureBoxPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GB_Controls;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LB_STATUS;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel PICTURE_STATUS;
        private System.Windows.Forms.ImageList imageList1;
    }
}

