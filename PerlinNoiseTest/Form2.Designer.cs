namespace PerlinNoiseTest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.FIELD_HELP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FIELD_HELP
            // 
            this.FIELD_HELP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FIELD_HELP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIELD_HELP.Location = new System.Drawing.Point(0, 0);
            this.FIELD_HELP.Multiline = true;
            this.FIELD_HELP.Name = "FIELD_HELP";
            this.FIELD_HELP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FIELD_HELP.Size = new System.Drawing.Size(815, 576);
            this.FIELD_HELP.TabIndex = 0;
            this.FIELD_HELP.Text = resources.GetString("FIELD_HELP.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 576);
            this.Controls.Add(this.FIELD_HELP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FIELD_HELP;
    }
}