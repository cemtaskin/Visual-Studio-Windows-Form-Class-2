
namespace Hangman
{
    partial class frmHangman
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLetter = new System.Windows.Forms.Label();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pBoxHangman = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.White;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDesc.Location = new System.Drawing.Point(3, 16);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(727, 78);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLetter);
            this.groupBox2.Location = new System.Drawing.Point(24, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblLetter
            // 
            this.lblLetter.BackColor = System.Drawing.Color.White;
            this.lblLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetter.Location = new System.Drawing.Point(219, 29);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(176, 130);
            this.lblLetter.TabIndex = 0;
            this.lblLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbButtons
            // 
            this.grbButtons.BackColor = System.Drawing.Color.White;
            this.grbButtons.Location = new System.Drawing.Point(24, 306);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(733, 111);
            this.grbButtons.TabIndex = 2;
            this.grbButtons.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pBoxHangman);
            this.groupBox3.Location = new System.Drawing.Point(763, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 404);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // pBoxHangman
            // 
            this.pBoxHangman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxHangman.Image = global::Hangman.Properties.Resources._001;
            this.pBoxHangman.Location = new System.Drawing.Point(3, 16);
            this.pBoxHangman.Name = "pBoxHangman";
            this.pBoxHangman.Size = new System.Drawing.Size(213, 385);
            this.pBoxHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxHangman.TabIndex = 0;
            this.pBoxHangman.TabStop = false;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHangman";
            this.Text = "Hangman Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHangman_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHangman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pBoxHangman;
    }
}

