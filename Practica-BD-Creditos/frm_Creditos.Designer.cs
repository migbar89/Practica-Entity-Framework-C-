namespace Practica_BD_Creditos
{
    partial class frm_Creditos
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
            this.lbnombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctinteres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctmontoapagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctplazo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctmonto = new System.Windows.Forms.TextBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.lbmontocuota = new System.Windows.Forms.Label();
            this.ctfechainicio = new System.Windows.Forms.DateTimePicker();
            this.ctfechafin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbnombre.Location = new System.Drawing.Point(224, 50);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(66, 24);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Interes";
            // 
            // ctinteres
            // 
            this.ctinteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctinteres.Location = new System.Drawing.Point(452, 184);
            this.ctinteres.Name = "ctinteres";
            this.ctinteres.Size = new System.Drawing.Size(162, 24);
            this.ctinteres.TabIndex = 26;
            this.ctinteres.TextChanged += new System.EventHandler(this.ctinteres_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Monto a pagar";
            // 
            // ctmontoapagar
            // 
            this.ctmontoapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmontoapagar.Location = new System.Drawing.Point(452, 252);
            this.ctmontoapagar.Name = "ctmontoapagar";
            this.ctmontoapagar.Size = new System.Drawing.Size(162, 24);
            this.ctmontoapagar.TabIndex = 24;
            this.ctmontoapagar.TextChanged += new System.EventHandler(this.ctmontoapagar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Plazo";
            // 
            // ctplazo
            // 
            this.ctplazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctplazo.Location = new System.Drawing.Point(452, 122);
            this.ctplazo.Name = "ctplazo";
            this.ctplazo.Size = new System.Drawing.Size(162, 24);
            this.ctplazo.TabIndex = 20;
            this.ctplazo.TextChanged += new System.EventHandler(this.ctplazo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Monto";
            // 
            // ctmonto
            // 
            this.ctmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmonto.Location = new System.Drawing.Point(189, 122);
            this.ctmonto.Name = "ctmonto";
            this.ctmonto.Size = new System.Drawing.Size(162, 24);
            this.ctmonto.TabIndex = 16;
            this.ctmonto.TextChanged += new System.EventHandler(this.ctinteres_TextChanged);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Maroon;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btcancelar.FlatAppearance.BorderSize = 0;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcancelar.Location = new System.Drawing.Point(501, 335);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(86, 32);
            this.btcancelar.TabIndex = 15;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btguardar
            // 
            this.btguardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btguardar.FlatAppearance.BorderSize = 0;
            this.btguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.Location = new System.Drawing.Point(201, 335);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(86, 32);
            this.btguardar.TabIndex = 14;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = false;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // lbmontocuota
            // 
            this.lbmontocuota.AutoSize = true;
            this.lbmontocuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontocuota.Location = new System.Drawing.Point(498, 279);
            this.lbmontocuota.Name = "lbmontocuota";
            this.lbmontocuota.Size = new System.Drawing.Size(28, 18);
            this.lbmontocuota.TabIndex = 28;
            this.lbmontocuota.Text = "0.0";
            // 
            // ctfechainicio
            // 
            this.ctfechainicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctfechainicio.Location = new System.Drawing.Point(189, 188);
            this.ctfechainicio.Name = "ctfechainicio";
            this.ctfechainicio.Size = new System.Drawing.Size(200, 20);
            this.ctfechainicio.TabIndex = 29;
            // 
            // ctfechafin
            // 
            this.ctfechafin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctfechafin.Location = new System.Drawing.Point(189, 253);
            this.ctfechafin.Name = "ctfechafin";
            this.ctfechafin.Size = new System.Drawing.Size(200, 20);
            this.ctfechafin.TabIndex = 30;
            // 
            // frm_Creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctfechafin);
            this.Controls.Add(this.ctfechainicio);
            this.Controls.Add(this.lbmontocuota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctinteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctmontoapagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctplazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctmonto);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.lbnombre);
            this.Name = "frm_Creditos";
            this.Text = "frm_Creditos";
            this.Load += new System.EventHandler(this.frm_Creditos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctinteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctmontoapagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctplazo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctmonto;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Label lbmontocuota;
        private System.Windows.Forms.DateTimePicker ctfechainicio;
        private System.Windows.Forms.DateTimePicker ctfechafin;
    }
}