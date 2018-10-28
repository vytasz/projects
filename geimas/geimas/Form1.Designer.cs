namespace geimas
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
            this.Button1 = new System.Windows.Forms.Button();
            this.txtGame = new System.Windows.Forms.RichTextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(13, 366);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(451, 72);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Pradėti žaidimą";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtGame
            // 
            this.txtGame.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtGame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGame.Location = new System.Drawing.Point(13, 12);
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(451, 303);
            this.txtGame.TabIndex = 3;
            this.txtGame.Text = "Čia pavyzdys.";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(369, 321);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(95, 42);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "0.00";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(13, 321);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(273, 39);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "Viršuje įrašykite tekstą";
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.Button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Ponas Rašytojas. Autorius Vytautas Žvinys PRif 16/2 20162524";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.RichTextBox txtGame;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtInput;
    }
}

