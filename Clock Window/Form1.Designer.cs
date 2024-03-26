namespace Clock_Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.hourState = new System.Windows.Forms.Label();
            this.minuteState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fullscreenButton = new System.Windows.Forms.PictureBox();
            this.fullscreenExitButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenExitButton)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(247, 109);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(250, 400);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            this.bg1.Click += new System.EventHandler(this.bg1_Click);
            // 
            // bg2
            // 
            this.bg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(462, 109);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(250, 400);
            this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bg2.TabIndex = 1;
            this.bg2.TabStop = false;
            // 
            // hourState
            // 
            this.hourState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hourState.AutoSize = true;
            this.hourState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(116)))), ((int)(((byte)(115)))));
            this.hourState.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.hourState.ForeColor = System.Drawing.SystemColors.Control;
            this.hourState.Location = new System.Drawing.Point(289, 244);
            this.hourState.Name = "hourState";
            this.hourState.Size = new System.Drawing.Size(0, 120);
            this.hourState.TabIndex = 2;
            // 
            // minuteState
            // 
            this.minuteState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minuteState.AutoSize = true;
            this.minuteState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(116)))), ((int)(((byte)(115)))));
            this.minuteState.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.minuteState.ForeColor = System.Drawing.SystemColors.Control;
            this.minuteState.Location = new System.Drawing.Point(504, 244);
            this.minuteState.Name = "minuteState";
            this.minuteState.Size = new System.Drawing.Size(0, 120);
            this.minuteState.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fullscreenButton.Image = ((System.Drawing.Image)(resources.GetObject("fullscreenButton.Image")));
            this.fullscreenButton.Location = new System.Drawing.Point(458, 565);
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(44, 44);
            this.fullscreenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fullscreenButton.TabIndex = 5;
            this.fullscreenButton.TabStop = false;
            this.fullscreenButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fullscreenExitButton
            // 
            this.fullscreenExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreenExitButton.Image = ((System.Drawing.Image)(resources.GetObject("fullscreenExitButton.Image")));
            this.fullscreenExitButton.Location = new System.Drawing.Point(916, 577);
            this.fullscreenExitButton.Name = "fullscreenExitButton";
            this.fullscreenExitButton.Size = new System.Drawing.Size(32, 32);
            this.fullscreenExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fullscreenExitButton.TabIndex = 6;
            this.fullscreenExitButton.TabStop = false;
            this.fullscreenExitButton.Visible = false;
            this.fullscreenExitButton.Click += new System.EventHandler(this.fullscreenExitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(6, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 21);
            this.button4.TabIndex = 8;
            this.button4.Text = "Değiştir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(80, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(768, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(960, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fullscreenExitButton);
            this.Controls.Add(this.fullscreenButton);
            this.Controls.Add(this.minuteState);
            this.Controls.Add(this.hourState);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenExitButton)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.Label hourState;
        private System.Windows.Forms.Label minuteState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox fullscreenButton;
        private System.Windows.Forms.PictureBox fullscreenExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}

