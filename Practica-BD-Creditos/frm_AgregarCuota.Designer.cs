namespace Practica_BD_Creditos
{
    partial class frm_AgregarCuota
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
            this.btagregar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ctmonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctfecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btagregar
            // 
            this.btagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btagregar.FlatAppearance.BorderSize = 0;
            this.btagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.Location = new System.Drawing.Point(53, 107);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(100, 47);
            this.btagregar.TabIndex = 0;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = false;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Red;
            this.btcancelar.FlatAppearance.BorderSize = 0;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(232, 107);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(110, 47);
            this.btcancelar.TabIndex = 1;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(53, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Monto";
            // 
            // ctmonto
            // 
            this.ctmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmonto.Location = new System.Drawing.Point(53, 39);
            this.ctmonto.Name = "ctmonto";
            this.ctmonto.Size = new System.Drawing.Size(100, 22);
            this.ctmonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // ctfecha
            // 
            this.ctfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctfecha.Location = new System.Drawing.Point(217, 39);
            this.ctfecha.Name = "ctfecha";
            this.ctfecha.Size = new System.Drawing.Size(268, 22);
            this.ctfecha.TabIndex = 5;
            // 
            // frm_AgregarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 181);
            this.Controls.Add(this.ctfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctmonto);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btagregar);
            this.Name = "frm_AgregarCuota";
            this.Text = "Agreguando Cuota";
            this.Load += new System.EventHandler(this.frm_AgregarCuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ctmonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ctfecha;
    }
}