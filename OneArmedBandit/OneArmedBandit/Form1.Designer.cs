namespace OneArmedBandit
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
            this.Nudge3 = new System.Windows.Forms.Button();
            this.Nudge2 = new System.Windows.Forms.Button();
            this.Nudge1 = new System.Windows.Forms.Button();
            this.Spin1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            this.PicBox3 = new System.Windows.Forms.PictureBox();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Nudge3
            // 
            this.Nudge3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudge3.Location = new System.Drawing.Point(617, 267);
            this.Nudge3.Name = "Nudge3";
            this.Nudge3.Size = new System.Drawing.Size(83, 33);
            this.Nudge3.TabIndex = 4;
            this.Nudge3.Text = "Nudge";
            this.Nudge3.UseVisualStyleBackColor = true;
            this.Nudge3.Click += new System.EventHandler(this.Nudge3_Click);
            // 
            // Nudge2
            // 
            this.Nudge2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudge2.Location = new System.Drawing.Point(375, 267);
            this.Nudge2.Name = "Nudge2";
            this.Nudge2.Size = new System.Drawing.Size(83, 33);
            this.Nudge2.TabIndex = 5;
            this.Nudge2.Text = "Nudge";
            this.Nudge2.UseVisualStyleBackColor = true;
            this.Nudge2.Click += new System.EventHandler(this.Nudge2_Click);
            // 
            // Nudge1
            // 
            this.Nudge1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudge1.Location = new System.Drawing.Point(130, 267);
            this.Nudge1.Name = "Nudge1";
            this.Nudge1.Size = new System.Drawing.Size(83, 33);
            this.Nudge1.TabIndex = 6;
            this.Nudge1.Text = "Nudge";
            this.Nudge1.UseVisualStyleBackColor = true;
            this.Nudge1.Click += new System.EventHandler(this.Nudge1_Click);
            // 
            // Spin1
            // 
            this.Spin1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin1.Location = new System.Drawing.Point(340, 339);
            this.Spin1.Name = "Spin1";
            this.Spin1.Size = new System.Drawing.Size(145, 60);
            this.Spin1.TabIndex = 10;
            this.Spin1.Text = "Spin";
            this.Spin1.UseVisualStyleBackColor = true;
            this.Spin1.Click += new System.EventHandler(this.Spin1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(219, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(418, 51);
            this.Title.TabIndex = 11;
            this.Title.Text = "Spin To Win a Banana";
            // 
            // PicBox1
            // 
            this.PicBox1.Location = new System.Drawing.Point(98, 94);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(145, 118);
            this.PicBox1.TabIndex = 9;
            this.PicBox1.TabStop = false;
            this.PicBox1.Click += new System.EventHandler(this.PicBox1_Click);
            // 
            // PicBox3
            // 
            this.PicBox3.Location = new System.Drawing.Point(589, 94);
            this.PicBox3.Name = "PicBox3";
            this.PicBox3.Size = new System.Drawing.Size(145, 118);
            this.PicBox3.TabIndex = 8;
            this.PicBox3.TabStop = false;
            this.PicBox3.Click += new System.EventHandler(this.PicBox3_Click);
            // 
            // PicBox2
            // 
            this.PicBox2.Location = new System.Drawing.Point(340, 94);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(145, 118);
            this.PicBox2.TabIndex = 7;
            this.PicBox2.TabStop = false;
            this.PicBox2.Click += new System.EventHandler(this.PicBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Spin1);
            this.Controls.Add(this.PicBox1);
            this.Controls.Add(this.PicBox3);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.Nudge1);
            this.Controls.Add(this.Nudge2);
            this.Controls.Add(this.Nudge3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nudge3;
        private System.Windows.Forms.Button Nudge2;
        private System.Windows.Forms.Button Nudge1;
        private System.Windows.Forms.PictureBox PicBox2;
        private System.Windows.Forms.PictureBox PicBox3;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.Button Spin1;
        private System.Windows.Forms.Label Title;
    }
}

