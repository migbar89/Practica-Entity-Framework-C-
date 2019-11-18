namespace Practica_BD_Creditos
{
    partial class frm_verCreditos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbmontocuota = new System.Windows.Forms.Label();
            this.lbfechafin = new System.Windows.Forms.Label();
            this.lbfechainicio = new System.Windows.Forms.Label();
            this.lbmontoapagar = new System.Windows.Forms.Label();
            this.lbinteres = new System.Windows.Forms.Label();
            this.lbplazo = new System.Windows.Forms.Label();
            this.lbmonto = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.gridcuotas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btagregarcuota = new System.Windows.Forms.Button();
            this.contextcuotas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcuotas)).BeginInit();
            this.contextcuotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lbmontocuota);
            this.groupBox1.Controls.Add(this.lbfechafin);
            this.groupBox1.Controls.Add(this.lbfechainicio);
            this.groupBox1.Controls.Add(this.lbmontoapagar);
            this.groupBox1.Controls.Add(this.lbinteres);
            this.groupBox1.Controls.Add(this.lbplazo);
            this.groupBox1.Controls.Add(this.lbmonto);
            this.groupBox1.Controls.Add(this.lbnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(90, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Credito";
            // 
            // lbmontocuota
            // 
            this.lbmontocuota.AutoSize = true;
            this.lbmontocuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontocuota.ForeColor = System.Drawing.Color.White;
            this.lbmontocuota.Location = new System.Drawing.Point(457, 31);
            this.lbmontocuota.Name = "lbmontocuota";
            this.lbmontocuota.Size = new System.Drawing.Size(57, 20);
            this.lbmontocuota.TabIndex = 8;
            this.lbmontocuota.Text = "label2";
            // 
            // lbfechafin
            // 
            this.lbfechafin.AutoSize = true;
            this.lbfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechafin.ForeColor = System.Drawing.Color.White;
            this.lbfechafin.Location = new System.Drawing.Point(457, 141);
            this.lbfechafin.Name = "lbfechafin";
            this.lbfechafin.Size = new System.Drawing.Size(57, 20);
            this.lbfechafin.TabIndex = 7;
            this.lbfechafin.Text = "label3";
            // 
            // lbfechainicio
            // 
            this.lbfechainicio.AutoSize = true;
            this.lbfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechainicio.ForeColor = System.Drawing.Color.White;
            this.lbfechainicio.Location = new System.Drawing.Point(65, 157);
            this.lbfechainicio.Name = "lbfechainicio";
            this.lbfechainicio.Size = new System.Drawing.Size(57, 20);
            this.lbfechainicio.TabIndex = 6;
            this.lbfechainicio.Text = "label2";
            // 
            // lbmontoapagar
            // 
            this.lbmontoapagar.AutoSize = true;
            this.lbmontoapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontoapagar.ForeColor = System.Drawing.Color.White;
            this.lbmontoapagar.Location = new System.Drawing.Point(457, 103);
            this.lbmontoapagar.Name = "lbmontoapagar";
            this.lbmontoapagar.Size = new System.Drawing.Size(57, 20);
            this.lbmontoapagar.TabIndex = 5;
            this.lbmontoapagar.Text = "label2";
            // 
            // lbinteres
            // 
            this.lbinteres.AutoSize = true;
            this.lbinteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinteres.ForeColor = System.Drawing.Color.White;
            this.lbinteres.Location = new System.Drawing.Point(457, 63);
            this.lbinteres.Name = "lbinteres";
            this.lbinteres.Size = new System.Drawing.Size(57, 20);
            this.lbinteres.TabIndex = 4;
            this.lbinteres.Text = "label2";
            // 
            // lbplazo
            // 
            this.lbplazo.AutoSize = true;
            this.lbplazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplazo.ForeColor = System.Drawing.Color.White;
            this.lbplazo.Location = new System.Drawing.Point(65, 119);
            this.lbplazo.Name = "lbplazo";
            this.lbplazo.Size = new System.Drawing.Size(57, 20);
            this.lbplazo.TabIndex = 2;
            this.lbplazo.Text = "label2";
            // 
            // lbmonto
            // 
            this.lbmonto.AutoSize = true;
            this.lbmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmonto.ForeColor = System.Drawing.Color.White;
            this.lbmonto.Location = new System.Drawing.Point(65, 79);
            this.lbmonto.Name = "lbmonto";
            this.lbmonto.Size = new System.Drawing.Size(57, 20);
            this.lbmonto.TabIndex = 1;
            this.lbmonto.Text = "label2";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.White;
            this.lbnombre.Location = new System.Drawing.Point(65, 31);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(57, 20);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "label2";
            // 
            // gridcuotas
            // 
            this.gridcuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridcuotas.ContextMenuStrip = this.contextcuotas;
            this.gridcuotas.Location = new System.Drawing.Point(277, 294);
            this.gridcuotas.Name = "gridcuotas";
            this.gridcuotas.Size = new System.Drawing.Size(350, 212);
            this.gridcuotas.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuotas Registradas";
            // 
            // btagregarcuota
            // 
            this.btagregarcuota.BackColor = System.Drawing.Color.Blue;
            this.btagregarcuota.FlatAppearance.BorderSize = 0;
            this.btagregarcuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregarcuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregarcuota.ForeColor = System.Drawing.Color.White;
            this.btagregarcuota.Location = new System.Drawing.Point(741, 358);
            this.btagregarcuota.Name = "btagregarcuota";
            this.btagregarcuota.Size = new System.Drawing.Size(148, 42);
            this.btagregarcuota.TabIndex = 3;
            this.btagregarcuota.Text = "Agregar Cuota";
            this.btagregarcuota.UseVisualStyleBackColor = false;
            this.btagregarcuota.Click += new System.EventHandler(this.btagregarcuota_Click);
            // 
            // contextcuotas
            // 
            this.contextcuotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextcuotas.Name = "contextcuotas";
            this.contextcuotas.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frm_verCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 553);
            this.Controls.Add(this.btagregarcuota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridcuotas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_verCreditos";
            this.Text = "frm_verCreditos";
            this.Load += new System.EventHandler(this.frm_verCreditos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcuotas)).EndInit();
            this.contextcuotas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridcuotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btagregarcuota;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbmontoapagar;
        private System.Windows.Forms.Label lbinteres;
        private System.Windows.Forms.Label lbplazo;
        private System.Windows.Forms.Label lbmonto;
        private System.Windows.Forms.Label lbfechafin;
        private System.Windows.Forms.Label lbfechainicio;
        private System.Windows.Forms.Label lbmontocuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextcuotas;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}