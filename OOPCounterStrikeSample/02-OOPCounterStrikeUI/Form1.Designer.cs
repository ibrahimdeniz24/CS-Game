namespace _02_OOPCounterStrikeUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        ///  Required method for Designer support - do not modify

        ///  the contents of this method with the code editor.

        /// </summary>

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            grpKesici = new GroupBox();
            btnBileyle = new Button();
            btnKes = new Button();
            grpAtesli = new GroupBox();
            btnUzaklastir = new Button();
            btnYakinlastir = new Button();
            btnReload = new Button();
            btnAtesEt = new Button();
            progressBar1 = new ProgressBar();
            grpSarjor = new GroupBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpKesici.SuspendLayout();
            grpAtesli.SuspendLayout();
            grpSarjor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 35);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(604, 406);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grpKesici
            // 
            grpKesici.Controls.Add(btnBileyle);
            grpKesici.Controls.Add(btnKes);
            grpKesici.Location = new Point(38, 450);
            grpKesici.Margin = new Padding(4, 5, 4, 5);
            grpKesici.Name = "grpKesici";
            grpKesici.Padding = new Padding(4, 5, 4, 5);
            grpKesici.Size = new Size(132, 154);
            grpKesici.TabIndex = 1;
            grpKesici.TabStop = false;
            grpKesici.Text = "Kesiciler";
            // 
            // btnBileyle
            // 
            btnBileyle.Location = new Point(10, 90);
            btnBileyle.Margin = new Padding(4, 5, 4, 5);
            btnBileyle.Name = "btnBileyle";
            btnBileyle.Size = new Size(100, 35);
            btnBileyle.TabIndex = 1;
            btnBileyle.Text = "Bileyle";
            btnBileyle.UseVisualStyleBackColor = true;
            btnBileyle.Click += btnBileyle_Click;
            // 
            // btnKes
            // 
            btnKes.Location = new Point(10, 45);
            btnKes.Margin = new Padding(4, 5, 4, 5);
            btnKes.Name = "btnKes";
            btnKes.Size = new Size(100, 35);
            btnKes.TabIndex = 0;
            btnKes.Text = "Kes";
            btnKes.UseVisualStyleBackColor = true;
            btnKes.Click += btnKes_Click;
            // 
            // grpAtesli
            // 
            grpAtesli.Controls.Add(btnUzaklastir);
            grpAtesli.Controls.Add(btnYakinlastir);
            grpAtesli.Controls.Add(btnReload);
            grpAtesli.Controls.Add(btnAtesEt);
            grpAtesli.Location = new Point(192, 450);
            grpAtesli.Margin = new Padding(4, 5, 4, 5);
            grpAtesli.Name = "grpAtesli";
            grpAtesli.Padding = new Padding(4, 5, 4, 5);
            grpAtesli.Size = new Size(230, 154);
            grpAtesli.TabIndex = 2;
            grpAtesli.TabStop = false;
            grpAtesli.Text = "Atesliler";
            // 
            // btnUzaklastir
            // 
            btnUzaklastir.Location = new Point(118, 75);
            btnUzaklastir.Margin = new Padding(4, 5, 4, 5);
            btnUzaklastir.Name = "btnUzaklastir";
            btnUzaklastir.Size = new Size(100, 35);
            btnUzaklastir.TabIndex = 3;
            btnUzaklastir.Text = "Uzaklaştır";
            btnUzaklastir.UseVisualStyleBackColor = true;
            btnUzaklastir.Click += btnUzaklastir_Click;
            // 
            // btnYakinlastir
            // 
            btnYakinlastir.Location = new Point(118, 30);
            btnYakinlastir.Margin = new Padding(4, 5, 4, 5);
            btnYakinlastir.Name = "btnYakinlastir";
            btnYakinlastir.Size = new Size(100, 35);
            btnYakinlastir.TabIndex = 2;
            btnYakinlastir.Text = "Yakınlaştır";
            btnYakinlastir.UseVisualStyleBackColor = true;
            btnYakinlastir.Click += btnYakinlastir_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(10, 77);
            btnReload.Margin = new Padding(4, 5, 4, 5);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(100, 35);
            btnReload.TabIndex = 1;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnAtesEt
            // 
            btnAtesEt.Location = new Point(10, 30);
            btnAtesEt.Margin = new Padding(4, 5, 4, 5);
            btnAtesEt.Name = "btnAtesEt";
            btnAtesEt.Size = new Size(100, 35);
            btnAtesEt.TabIndex = 0;
            btnAtesEt.Text = "Ateş Et";
            btnAtesEt.UseVisualStyleBackColor = true;
            btnAtesEt.Click += btnAtesEt_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(40, 15);
            progressBar1.Margin = new Padding(4, 5, 4, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(152, 35);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 3;
            // 
            // grpSarjor
            // 
            grpSarjor.Controls.Add(pictureBox2);
            grpSarjor.Controls.Add(progressBar1);
            grpSarjor.Location = new Point(430, 450);
            grpSarjor.Margin = new Padding(4, 5, 4, 5);
            grpSarjor.Name = "grpSarjor";
            grpSarjor.Padding = new Padding(4, 5, 4, 5);
            grpSarjor.Size = new Size(200, 60);
            grpSarjor.TabIndex = 4;
            grpSarjor.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(2, 15);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 637);
            Controls.Add(grpSarjor);
            Controls.Add(grpAtesli);
            Controls.Add(grpKesici);
            Controls.Add(pictureBox1);
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpKesici.ResumeLayout(false);
            grpAtesli.ResumeLayout(false);
            grpSarjor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.GroupBox grpKesici;

        private System.Windows.Forms.Button btnBileyle;

        private System.Windows.Forms.Button btnKes;

        private System.Windows.Forms.GroupBox grpAtesli;

        private System.Windows.Forms.Button btnUzaklastir;

        private System.Windows.Forms.Button btnYakinlastir;

        private System.Windows.Forms.Button btnReload;

        private System.Windows.Forms.Button btnAtesEt;

        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.GroupBox grpSarjor;

        private System.Windows.Forms.PictureBox pictureBox2;



        #endregion
    }
}
