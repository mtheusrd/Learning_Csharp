namespace Verifica_Caracteres
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
            this.txtCaractere = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCaractere
            // 
            this.txtCaractere.Location = new System.Drawing.Point(75, 150);
            this.txtCaractere.Name = "txtCaractere";
            this.txtCaractere.Size = new System.Drawing.Size(138, 23);
            this.txtCaractere.TabIndex = 0;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(99, 179);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(86, 27);
            this.btnVerifica.TabIndex = 1;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelMsg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMsg.Location = new System.Drawing.Point(56, 94);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(180, 25);
            this.labelMsg.TabIndex = 2;
            this.labelMsg.Text = "Informe o Caractere";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMsg.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(122, 238);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(298, 288);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtCaractere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCaractere;
        private Button btnVerifica;
        private Label labelMsg;
        private Label labelResultado;
    }
}