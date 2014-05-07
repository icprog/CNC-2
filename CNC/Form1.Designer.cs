namespace CNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.image = new System.Windows.Forms.PictureBox();
            this.convert = new System.Windows.Forms.Button();
            this.invert = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(12, 26);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(560, 358);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // convert
            // 
            this.convert.Enabled = false;
            this.convert.Location = new System.Drawing.Point(578, 23);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(116, 37);
            this.convert.TabIndex = 1;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // invert
            // 
            this.invert.Enabled = false;
            this.invert.Location = new System.Drawing.Point(578, 66);
            this.invert.Name = "invert";
            this.invert.Size = new System.Drawing.Size(116, 37);
            this.invert.TabIndex = 1;
            this.invert.Text = "Invert Colour";
            this.invert.UseVisualStyleBackColor = true;
            this.invert.Click += new System.EventHandler(this.invert_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(578, 347);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 37);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.Name = "statusBar";
            this.statusBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.statusBar.Size = new System.Drawing.Size(540, 20);
            this.statusBar.Text = "Select Image";
            this.statusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(154, 17);
            this.toolStripProgressBar1.Step = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(578, 109);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(116, 37);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse Image";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(702, 425);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.invert);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button invert;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button browse;
    }
}

