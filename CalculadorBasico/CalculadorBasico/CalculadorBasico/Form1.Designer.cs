namespace CalculadorBasico
{
    partial class CalculadorBasico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt01 = new System.Windows.Forms.Label();
            this.CaixaTxt02 = new System.Windows.Forms.TextBox();
            this.CaixaTxt01 = new System.Windows.Forms.TextBox();
            this.Bt01 = new System.Windows.Forms.Button();
            this.Bt02 = new System.Windows.Forms.Button();
            this.Bt03 = new System.Windows.Forms.Button();
            this.Bt04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite outro número:";
            // 
            // Txt01
            // 
            this.Txt01.AutoSize = true;
            this.Txt01.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt01.Location = new System.Drawing.Point(142, 254);
            this.Txt01.Name = "Txt01";
            this.Txt01.Size = new System.Drawing.Size(113, 30);
            this.Txt01.TabIndex = 2;
            this.Txt01.Text = "Resultado:";
            // 
            // CaixaTxt02
            // 
            this.CaixaTxt02.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaixaTxt02.Location = new System.Drawing.Point(282, 165);
            this.CaixaTxt02.Name = "CaixaTxt02";
            this.CaixaTxt02.Size = new System.Drawing.Size(143, 34);
            this.CaixaTxt02.TabIndex = 3;
            // 
            // CaixaTxt01
            // 
            this.CaixaTxt01.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaixaTxt01.Location = new System.Drawing.Point(261, 94);
            this.CaixaTxt01.Name = "CaixaTxt01";
            this.CaixaTxt01.Size = new System.Drawing.Size(141, 34);
            this.CaixaTxt01.TabIndex = 4;
            // 
            // Bt01
            // 
            this.Bt01.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Bt01.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt01.ForeColor = System.Drawing.SystemColors.Control;
            this.Bt01.Location = new System.Drawing.Point(475, 82);
            this.Bt01.Name = "Bt01";
            this.Bt01.Size = new System.Drawing.Size(75, 70);
            this.Bt01.TabIndex = 5;
            this.Bt01.Text = "+";
            this.Bt01.UseVisualStyleBackColor = false;
            this.Bt01.Click += new System.EventHandler(this.Bt01_Click);
            // 
            // Bt02
            // 
            this.Bt02.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Bt02.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt02.ForeColor = System.Drawing.SystemColors.Control;
            this.Bt02.Location = new System.Drawing.Point(556, 82);
            this.Bt02.Name = "Bt02";
            this.Bt02.Size = new System.Drawing.Size(75, 70);
            this.Bt02.TabIndex = 6;
            this.Bt02.Text = "-";
            this.Bt02.UseVisualStyleBackColor = false;
            this.Bt02.Click += new System.EventHandler(this.Bt02_Click);
            // 
            // Bt03
            // 
            this.Bt03.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Bt03.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt03.ForeColor = System.Drawing.SystemColors.Control;
            this.Bt03.Location = new System.Drawing.Point(475, 165);
            this.Bt03.Name = "Bt03";
            this.Bt03.Size = new System.Drawing.Size(75, 68);
            this.Bt03.TabIndex = 7;
            this.Bt03.Text = "*";
            this.Bt03.UseVisualStyleBackColor = false;
            this.Bt03.Click += new System.EventHandler(this.Bt03_Click);
            // 
            // Bt04
            // 
            this.Bt04.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Bt04.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt04.ForeColor = System.Drawing.SystemColors.Control;
            this.Bt04.Location = new System.Drawing.Point(556, 165);
            this.Bt04.Name = "Bt04";
            this.Bt04.Size = new System.Drawing.Size(75, 68);
            this.Bt04.TabIndex = 8;
            this.Bt04.Text = "/";
            this.Bt04.UseVisualStyleBackColor = false;
            this.Bt04.Click += new System.EventHandler(this.Bt04_Click);
            // 
            // CalculadorBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt04);
            this.Controls.Add(this.Bt03);
            this.Controls.Add(this.Bt02);
            this.Controls.Add(this.Bt01);
            this.Controls.Add(this.CaixaTxt01);
            this.Controls.Add(this.CaixaTxt02);
            this.Controls.Add(this.Txt01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculadorBasico";
            this.Text = "Calculador";
            this.Load += new System.EventHandler(this.CalculadorBasico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txt01;
        private TextBox CaixaTxt02;
        private TextBox CaixaTxt01;
        private Button Bt01;
        private Button Bt02;
        private Button Bt03;
        private Button Bt04;
        private Label Txt01;
    }
}