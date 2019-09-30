namespace Russian_Roullete
{
    partial class gameforms
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
            this.loadedgunbt = new System.Windows.Forms.Button();
            this.spinchambernt = new System.Windows.Forms.Button();
            this.Shootgunbt = new System.Windows.Forms.Button();
            this.AwayBt = new System.Windows.Forms.Button();
            this.btnplayagain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadedgunbt
            // 
            this.loadedgunbt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedgunbt.Location = new System.Drawing.Point(231, 314);
            this.loadedgunbt.Name = "loadedgunbt";
            this.loadedgunbt.Size = new System.Drawing.Size(97, 41);
            this.loadedgunbt.TabIndex = 0;
            this.loadedgunbt.Text = "Load";
            this.loadedgunbt.UseVisualStyleBackColor = true;
            this.loadedgunbt.Click += new System.EventHandler(this.loadedgunbt_Click);
            // 
            // spinchambernt
            // 
            this.spinchambernt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinchambernt.Location = new System.Drawing.Point(334, 314);
            this.spinchambernt.Name = "spinchambernt";
            this.spinchambernt.Size = new System.Drawing.Size(97, 41);
            this.spinchambernt.TabIndex = 1;
            this.spinchambernt.Text = "Spin";
            this.spinchambernt.UseVisualStyleBackColor = true;
            this.spinchambernt.Click += new System.EventHandler(this.spinchambernt_Click);
            // 
            // Shootgunbt
            // 
            this.Shootgunbt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shootgunbt.Location = new System.Drawing.Point(437, 314);
            this.Shootgunbt.Name = "Shootgunbt";
            this.Shootgunbt.Size = new System.Drawing.Size(97, 41);
            this.Shootgunbt.TabIndex = 2;
            this.Shootgunbt.Text = "shoot";
            this.Shootgunbt.UseVisualStyleBackColor = true;
            this.Shootgunbt.Click += new System.EventHandler(this.Shootgunbt_Click);
            // 
            // AwayBt
            // 
            this.AwayBt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AwayBt.Location = new System.Drawing.Point(260, 373);
            this.AwayBt.Name = "AwayBt";
            this.AwayBt.Size = new System.Drawing.Size(97, 41);
            this.AwayBt.TabIndex = 3;
            this.AwayBt.Text = "Away";
            this.AwayBt.UseVisualStyleBackColor = true;
            this.AwayBt.Click += new System.EventHandler(this.AwayBt_Click);
            // 
            // btnplayagain
            // 
            this.btnplayagain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplayagain.Location = new System.Drawing.Point(395, 373);
            this.btnplayagain.Name = "btnplayagain";
            this.btnplayagain.Size = new System.Drawing.Size(139, 41);
            this.btnplayagain.TabIndex = 4;
            this.btnplayagain.Text = "play again";
            this.btnplayagain.UseVisualStyleBackColor = true;
            this.btnplayagain.Click += new System.EventHandler(this.btnplayagain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(82, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 281);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // gameforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnplayagain);
            this.Controls.Add(this.AwayBt);
            this.Controls.Add(this.Shootgunbt);
            this.Controls.Add(this.spinchambernt);
            this.Controls.Add(this.loadedgunbt);
            this.Name = "gameforms";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Gameforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadedgunbt;
        private System.Windows.Forms.Button spinchambernt;
        private System.Windows.Forms.Button Shootgunbt;
        private System.Windows.Forms.Button AwayBt;
        private System.Windows.Forms.Button btnplayagain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}