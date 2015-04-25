namespace ImgCompressV1
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
            this.lblImgaePath = new System.Windows.Forms.Label();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblImgQuality = new System.Windows.Forms.Label();
            this.trcBarImageQuaity = new System.Windows.Forms.TrackBar();
            this.prgbar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcBarImageQuaity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImgaePath
            // 
            this.lblImgaePath.AutoSize = true;
            this.lblImgaePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgaePath.Location = new System.Drawing.Point(32, 42);
            this.lblImgaePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImgaePath.Name = "lblImgaePath";
            this.lblImgaePath.Size = new System.Drawing.Size(100, 16);
            this.lblImgaePath.TabIndex = 0;
            this.lblImgaePath.Text = "Image Location";
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.Location = new System.Drawing.Point(156, 39);
            this.txtImageLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(255, 22);
            this.txtImageLocation.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(419, 36);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(386, 145);
            this.btnCompress.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(100, 28);
            this.btnCompress.TabIndex = 3;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 145);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblImgQuality
            // 
            this.lblImgQuality.AutoSize = true;
            this.lblImgQuality.Location = new System.Drawing.Point(32, 79);
            this.lblImgQuality.Name = "lblImgQuality";
            this.lblImgQuality.Size = new System.Drawing.Size(90, 16);
            this.lblImgQuality.TabIndex = 5;
            this.lblImgQuality.Text = "Image Quality";
            // 
            // trcBarImageQuaity
            // 
            this.trcBarImageQuaity.Location = new System.Drawing.Point(156, 68);
            this.trcBarImageQuaity.Maximum = 100;
            this.trcBarImageQuaity.Name = "trcBarImageQuaity";
            this.trcBarImageQuaity.Size = new System.Drawing.Size(255, 45);
            this.trcBarImageQuaity.TabIndex = 6;
            this.trcBarImageQuaity.TickFrequency = 5;
            this.trcBarImageQuaity.Scroll += new System.EventHandler(this.trcBarImageQuaity_Scroll);
            // 
            // prgbar
            // 
            this.prgbar.Location = new System.Drawing.Point(35, 147);
            this.prgbar.Name = "prgbar";
            this.prgbar.Size = new System.Drawing.Size(236, 23);
            this.prgbar.TabIndex = 7;
            this.prgbar.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Output Location";
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(156, 108);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(321, 22);
            this.txtOutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 182);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgbar);
            this.Controls.Add(this.trcBarImageQuaity);
            this.Controls.Add(this.lblImgQuality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImageLocation);
            this.Controls.Add(this.lblImgaePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Image Compress";
            ((System.ComponentModel.ISupportInitialize)(this.trcBarImageQuaity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImgaePath;
        private System.Windows.Forms.TextBox txtImageLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblImgQuality;
        private System.Windows.Forms.TrackBar trcBarImageQuaity;
        private System.Windows.Forms.ProgressBar prgbar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

