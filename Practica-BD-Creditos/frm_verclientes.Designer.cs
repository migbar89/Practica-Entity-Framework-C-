namespace Practica_BD_Creditos
{
    partial class frm_verclientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btagregar = new System.Windows.Forms.Button();
            this.btcredito = new System.Windows.Forms.Button();
            this.ctbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCreditoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 26);
            // 
            // verCreditoToolStripMenuItem
            // 
            this.verCreditoToolStripMenuItem.Name = "verCreditoToolStripMenuItem";
            this.verCreditoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.verCreditoToolStripMenuItem.Text = "Ver Credito";
            this.verCreditoToolStripMenuItem.Click += new System.EventHandler(this.verCreditoToolStripMenuItem_Click);
            // 
            // btagregar
            // 
            this.btagregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btagregar.FlatAppearance.BorderSize = 0;
            this.btagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregar.Location = new System.Drawing.Point(806, 144);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(146, 55);
            this.btagregar.TabIndex = 1;
            this.btagregar.Text = "Agregar Cliente";
            this.btagregar.UseVisualStyleBackColor = false;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btcredito
            // 
            this.btcredito.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btcredito.FlatAppearance.BorderSize = 0;
            this.btcredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcredito.Location = new System.Drawing.Point(806, 255);
            this.btcredito.Name = "btcredito";
            this.btcredito.Size = new System.Drawing.Size(146, 74);
            this.btcredito.TabIndex = 2;
            this.btcredito.Text = "Agregar Credito";
            this.btcredito.UseVisualStyleBackColor = false;
            this.btcredito.Click += new System.EventHandler(this.btcredito_Click);
            // 
            // ctbusqueda
            // 
            this.ctbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctbusqueda.Location = new System.Drawing.Point(42, 112);
            this.ctbusqueda.Name = "ctbusqueda";
            this.ctbusqueda.Size = new System.Drawing.Size(175, 26);
            this.ctbusqueda.TabIndex = 3;
            this.ctbusqueda.TextChanged += new System.EventHandler(this.ctbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(304, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gestion de Creditos";
            // 
            // frm_verclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctbusqueda);
            this.Controls.Add(this.btcredito);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_verclientes";
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.frm_verclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Button btcredito;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verCreditoToolStripMenuItem;
        private System.Windows.Forms.TextBox ctbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

