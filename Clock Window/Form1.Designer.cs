namespace Clock_Window
{
    partial class Clock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clock));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.hourState = new System.Windows.Forms.Label();
            this.minuteState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fullscreenButton = new System.Windows.Forms.PictureBox();
            this.fullscreenExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(119, 69);
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
            this.bg2.Location = new System.Drawing.Point(334, 69);
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
            this.hourState.Location = new System.Drawing.Point(161, 204);
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
            this.minuteState.Location = new System.Drawing.Point(376, 204);
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
            this.fullscreenButton.Location = new System.Drawing.Point(330, 485);
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
            this.fullscreenExitButton.Location = new System.Drawing.Point(661, 497);
            this.fullscreenExitButton.Name = "fullscreenExitButton";
            this.fullscreenExitButton.Size = new System.Drawing.Size(32, 32);
            this.fullscreenExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fullscreenExitButton.TabIndex = 6;
            this.fullscreenExitButton.TabStop = false;
            this.fullscreenExitButton.Visible = false;
            this.fullscreenExitButton.Click += new System.EventHandler(this.fullscreenExitButton_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(705, 537);
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
            this.Name = "Clock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullscreenExitButton)).EndInit();
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
    }
}

