namespace MartinPlocha1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUlož = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Skupina = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Skupina.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUlož
            // 
            this.btnUlož.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUlož.Location = new System.Drawing.Point(12, 12);
            this.btnUlož.Name = "btnUlož";
            this.btnUlož.Size = new System.Drawing.Size(97, 30);
            this.btnUlož.TabIndex = 0;
            this.btnUlož.Text = "Ulož";
            this.btnUlož.UseVisualStyleBackColor = false;
            this.btnUlož.Click += new System.EventHandler(this.Ulož);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 298);
            this.textBox1.TabIndex = 1;
            // 
            // Skupina
            // 
            this.Skupina.Controls.Add(this.radioButton3);
            this.Skupina.Controls.Add(this.radioButton2);
            this.Skupina.Controls.Add(this.radioButton1);
            this.Skupina.Location = new System.Drawing.Point(560, 60);
            this.Skupina.Name = "Skupina";
            this.Skupina.Size = new System.Drawing.Size(200, 165);
            this.Skupina.TabIndex = 2;
            this.Skupina.TabStop = false;
            this.Skupina.Text = "Skupinový rámeček";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 103);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Skupina);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUlož);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Skupina.ResumeLayout(false);
            this.Skupina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUlož;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Skupina;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

