
namespace FruitCatcher
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
            this.apple1 = new System.Windows.Forms.PictureBox();
            this.apple2 = new System.Windows.Forms.PictureBox();
            this.apple3 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.basket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            this.SuspendLayout();
            // 
            // apple1
            // 
            this.apple1.Image = ((System.Drawing.Image)(resources.GetObject("apple1.Image")));
            this.apple1.Location = new System.Drawing.Point(126, 179);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(100, 50);
            this.apple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple1.TabIndex = 1;
            this.apple1.TabStop = false;
            // 
            // apple2
            // 
            this.apple2.Image = ((System.Drawing.Image)(resources.GetObject("apple2.Image")));
            this.apple2.Location = new System.Drawing.Point(348, 31);
            this.apple2.Name = "apple2";
            this.apple2.Size = new System.Drawing.Size(100, 50);
            this.apple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple2.TabIndex = 2;
            this.apple2.TabStop = false;
            // 
            // apple3
            // 
            this.apple3.Image = ((System.Drawing.Image)(resources.GetObject("apple3.Image")));
            this.apple3.Location = new System.Drawing.Point(645, 111);
            this.apple3.Name = "apple3";
            this.apple3.Size = new System.Drawing.Size(100, 50);
            this.apple3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple3.TabIndex = 3;
            this.apple3.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(65, 16);
            this.score.TabIndex = 4;
            this.score.Text = "Score: 0";
            // 
            // basket
            // 
            this.basket.Image = ((System.Drawing.Image)(resources.GetObject("basket.Image")));
            this.basket.Location = new System.Drawing.Point(348, 484);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(100, 71);
            this.basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basket.TabIndex = 5;
            this.basket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.score);
            this.Controls.Add(this.apple3);
            this.Controls.Add(this.apple2);
            this.Controls.Add(this.apple1);
            this.Name = "Form1";
            this.Text = "Fruit Catcher";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox apple1;
        private System.Windows.Forms.PictureBox apple2;
        private System.Windows.Forms.PictureBox apple3;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox basket;
        private System.Windows.Forms.Timer timer1;
    }
}

