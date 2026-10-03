namespace SISTEMA.Presentacion
{
    partial class frmGenerar
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl01 = new System.Windows.Forms.Panel();
            this.pnl02 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.btnAbrirarchivo = new System.Windows.Forms.Button();
            this.pctImagen2 = new System.Windows.Forms.PictureBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.pnlTitulo.SuspendLayout();
            this.pnl01.SuspendLayout();
            this.pnl02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(800, 54);
            this.pnlTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAR Y LEER CÓDIGO QR Y DE BARRA";
            // 
            // pnl01
            // 
            this.pnl01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.pnl01.Controls.Add(this.pctImagen);
            this.pnl01.Controls.Add(this.btnGuardar);
            this.pnl01.Controls.Add(this.txtTexto);
            this.pnl01.Controls.Add(this.label2);
            this.pnl01.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl01.Location = new System.Drawing.Point(0, 54);
            this.pnl01.Name = "pnl01";
            this.pnl01.Size = new System.Drawing.Size(456, 396);
            this.pnl01.TabIndex = 1;
            // 
            // pnl02
            // 
            this.pnl02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl02.Controls.Add(this.txtTexto2);
            this.pnl02.Controls.Add(this.pctImagen2);
            this.pnl02.Controls.Add(this.btnAbrirarchivo);
            this.pnl02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl02.Location = new System.Drawing.Point(456, 54);
            this.pnl02.Name = "pnl02";
            this.pnl02.Size = new System.Drawing.Size(344, 396);
            this.pnl02.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(32, 45);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(391, 22);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Location = new System.Drawing.Point(32, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(391, 57);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pctImagen
            // 
            this.pctImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagen.Location = new System.Drawing.Point(32, 89);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(391, 217);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctImagen.TabIndex = 3;
            this.pctImagen.TabStop = false;
            // 
            // btnAbrirarchivo
            // 
            this.btnAbrirarchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.btnAbrirarchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirarchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirarchivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirarchivo.Location = new System.Drawing.Point(60, 10);
            this.btnAbrirarchivo.Name = "btnAbrirarchivo";
            this.btnAbrirarchivo.Size = new System.Drawing.Size(247, 57);
            this.btnAbrirarchivo.TabIndex = 3;
            this.btnAbrirarchivo.Text = "Abrir archivo";
            this.btnAbrirarchivo.UseVisualStyleBackColor = false;
            this.btnAbrirarchivo.Click += new System.EventHandler(this.btnAbrirarchivo_Click);
            // 
            // pctImagen2
            // 
            this.pctImagen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagen2.Location = new System.Drawing.Point(60, 91);
            this.pctImagen2.Name = "pctImagen2";
            this.pctImagen2.Size = new System.Drawing.Size(247, 215);
            this.pctImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctImagen2.TabIndex = 4;
            this.pctImagen2.TabStop = false;
            // 
            // txtTexto2
            // 
            this.txtTexto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto2.Location = new System.Drawing.Point(60, 325);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.ReadOnly = true;
            this.txtTexto2.Size = new System.Drawing.Size(247, 22);
            this.txtTexto2.TabIndex = 5;
            // 
            // frmGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl02);
            this.Controls.Add(this.pnl01);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnl01.ResumeLayout(false);
            this.pnl01.PerformLayout();
            this.pnl02.ResumeLayout(false);
            this.pnl02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl01;
        private System.Windows.Forms.Panel pnl02;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrirarchivo;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.PictureBox pctImagen2;
    }
}