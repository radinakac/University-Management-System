
namespace WindowsFormsApp23
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.въвежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.извежданеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДисциплинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наОценкиПоИмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среденУспехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.полToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.въвежданеToolStripMenuItem,
            this.извежданеToolStripMenuItem,
            this.отчетиToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // въвежданеToolStripMenuItem
            // 
            this.въвежданеToolStripMenuItem.Name = "въвежданеToolStripMenuItem";
            this.въвежданеToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.въвежданеToolStripMenuItem.Text = "Въвеждане";
            this.въвежданеToolStripMenuItem.Click += new System.EventHandler(this.въвежданеToolStripMenuItem_Click);
            // 
            // извежданеToolStripMenuItem
            // 
            this.извежданеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всичкиToolStripMenuItem,
            this.поДисциплинаToolStripMenuItem,
            this.наОценкиПоИмеToolStripMenuItem});
            this.извежданеToolStripMenuItem.Name = "извежданеToolStripMenuItem";
            this.извежданеToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.извежданеToolStripMenuItem.Text = "Извеждане";
            // 
            // всичкиToolStripMenuItem
            // 
            this.всичкиToolStripMenuItem.Name = "всичкиToolStripMenuItem";
            this.всичкиToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.всичкиToolStripMenuItem.Text = "Всички";
            this.всичкиToolStripMenuItem.Click += new System.EventHandler(this.всичкиToolStripMenuItem_Click);
            // 
            // поДисциплинаToolStripMenuItem
            // 
            this.поДисциплинаToolStripMenuItem.Name = "поДисциплинаToolStripMenuItem";
            this.поДисциплинаToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.поДисциплинаToolStripMenuItem.Text = "По дисциплина";
            this.поДисциплинаToolStripMenuItem.Click += new System.EventHandler(this.поДисциплинаToolStripMenuItem_Click);
            // 
            // наОценкиПоИмеToolStripMenuItem
            // 
            this.наОценкиПоИмеToolStripMenuItem.Name = "наОценкиПоИмеToolStripMenuItem";
            this.наОценкиПоИмеToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.наОценкиПоИмеToolStripMenuItem.Text = "На оценки по име";
            this.наОценкиПоИмеToolStripMenuItem.Click += new System.EventHandler(this.наОценкиПоИмеToolStripMenuItem_Click);
            // 
            // отчетиToolStripMenuItem
            // 
            this.отчетиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.среденУспехToolStripMenuItem,
            this.полToolStripMenuItem});
            this.отчетиToolStripMenuItem.Name = "отчетиToolStripMenuItem";
            this.отчетиToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.отчетиToolStripMenuItem.Text = "Отчети";
            // 
            // среденУспехToolStripMenuItem
            // 
            this.среденУспехToolStripMenuItem.Name = "среденУспехToolStripMenuItem";
            this.среденУспехToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.среденУспехToolStripMenuItem.Text = "Среден успех ";
            this.среденУспехToolStripMenuItem.Click += new System.EventHandler(this.среденУспехToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 644);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // полToolStripMenuItem
            // 
            this.полToolStripMenuItem.Name = "полToolStripMenuItem";
            this.полToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.полToolStripMenuItem.Text = "Пол";
            this.полToolStripMenuItem.Click += new System.EventHandler(this.полToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Студентска форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem въвежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem извежданеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem всичкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДисциплинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наОценкиПоИмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среденУспехToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полToolStripMenuItem;
    }
}

