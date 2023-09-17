namespace WindowsFormsApp
{
    partial class ModificarArticulo
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
            this.txtNImagen = new System.Windows.Forms.TextBox();
            this.lblNImagen = new System.Windows.Forms.Label();
            this.chbxModificarImg = new System.Windows.Forms.CheckBox();
            this.chbxAgregarImg = new System.Windows.Forms.CheckBox();
            this.lblModificarImg = new System.Windows.Forms.Label();
            this.lblAgregarImg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblCodigoArt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvPrevisualizacion = new System.Windows.Forms.ListView();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxUrlImagen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbxDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbxImagen = new System.Windows.Forms.CheckBox();
            this.btnVisualizarArticulo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNImagen
            // 
            this.txtNImagen.Location = new System.Drawing.Point(200, 467);
            this.txtNImagen.Margin = new System.Windows.Forms.Padding(4);
            this.txtNImagen.Name = "txtNImagen";
            this.txtNImagen.Size = new System.Drawing.Size(224, 22);
            this.txtNImagen.TabIndex = 117;
            this.txtNImagen.Visible = false;
            // 
            // lblNImagen
            // 
            this.lblNImagen.AutoSize = true;
            this.lblNImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNImagen.Location = new System.Drawing.Point(25, 469);
            this.lblNImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNImagen.Name = "lblNImagen";
            this.lblNImagen.Size = new System.Drawing.Size(147, 20);
            this.lblNImagen.TabIndex = 116;
            this.lblNImagen.Text = "Numero de imagen:";
            this.lblNImagen.Visible = false;
            // 
            // chbxModificarImg
            // 
            this.chbxModificarImg.AutoSize = true;
            this.chbxModificarImg.Location = new System.Drawing.Point(371, 443);
            this.chbxModificarImg.Margin = new System.Windows.Forms.Padding(4);
            this.chbxModificarImg.Name = "chbxModificarImg";
            this.chbxModificarImg.Size = new System.Drawing.Size(18, 17);
            this.chbxModificarImg.TabIndex = 115;
            this.chbxModificarImg.UseVisualStyleBackColor = true;
            this.chbxModificarImg.Visible = false;
            this.chbxModificarImg.CheckedChanged += new System.EventHandler(this.chbxModificarImg_CheckedChanged);
            // 
            // chbxAgregarImg
            // 
            this.chbxAgregarImg.AutoSize = true;
            this.chbxAgregarImg.Location = new System.Drawing.Point(216, 443);
            this.chbxAgregarImg.Margin = new System.Windows.Forms.Padding(4);
            this.chbxAgregarImg.Name = "chbxAgregarImg";
            this.chbxAgregarImg.Size = new System.Drawing.Size(18, 17);
            this.chbxAgregarImg.TabIndex = 114;
            this.chbxAgregarImg.UseVisualStyleBackColor = true;
            this.chbxAgregarImg.Visible = false;
            this.chbxAgregarImg.CheckedChanged += new System.EventHandler(this.chbxAgregarImg_CheckedChanged);
            // 
            // lblModificarImg
            // 
            this.lblModificarImg.AutoSize = true;
            this.lblModificarImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblModificarImg.Location = new System.Drawing.Point(343, 412);
            this.lblModificarImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificarImg.Name = "lblModificarImg";
            this.lblModificarImg.Size = new System.Drawing.Size(78, 20);
            this.lblModificarImg.TabIndex = 113;
            this.lblModificarImg.Text = "Modificar";
            this.lblModificarImg.Visible = false;
            // 
            // lblAgregarImg
            // 
            this.lblAgregarImg.AutoSize = true;
            this.lblAgregarImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAgregarImg.Location = new System.Drawing.Point(201, 412);
            this.lblAgregarImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarImg.Name = "lblAgregarImg";
            this.lblAgregarImg.Size = new System.Drawing.Size(68, 20);
            this.lblAgregarImg.TabIndex = 112;
            this.lblAgregarImg.Text = "Agregar";
            this.lblAgregarImg.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(28, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 111;
            this.label8.Text = "Imagen:";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(492, 307);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(160, 139);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 110;
            this.pbImagen.TabStop = false;
            // 
            // lblCodigoArt
            // 
            this.lblCodigoArt.AutoSize = true;
            this.lblCodigoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCodigoArt.Location = new System.Drawing.Point(27, 23);
            this.lblCodigoArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoArt.Name = "lblCodigoArt";
            this.lblCodigoArt.Size = new System.Drawing.Size(77, 25);
            this.lblCodigoArt.TabIndex = 109;
            this.lblCodigoArt.Text = "Articulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 101;
            this.label7.Text = "PRE-CARGA";
            // 
            // lvPrevisualizacion
            // 
            this.lvPrevisualizacion.HideSelection = false;
            this.lvPrevisualizacion.Location = new System.Drawing.Point(463, 98);
            this.lvPrevisualizacion.Margin = new System.Windows.Forms.Padding(4);
            this.lvPrevisualizacion.Name = "lvPrevisualizacion";
            this.lvPrevisualizacion.RightToLeftLayout = true;
            this.lvPrevisualizacion.Size = new System.Drawing.Size(221, 153);
            this.lvPrevisualizacion.TabIndex = 100;
            this.lvPrevisualizacion.UseCompatibleStateImageBehavior = false;
            this.lvPrevisualizacion.View = System.Windows.Forms.View.List;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(177, 165);
            this.tbxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(249, 22);
            this.tbxPrecio.TabIndex = 88;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // tbxUrlImagen
            // 
            this.tbxUrlImagen.Location = new System.Drawing.Point(177, 373);
            this.tbxUrlImagen.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUrlImagen.Name = "tbxUrlImagen";
            this.tbxUrlImagen.Size = new System.Drawing.Size(249, 22);
            this.tbxUrlImagen.TabIndex = 91;
            this.tbxUrlImagen.Leave += new System.EventHandler(this.tbxUrlImagen_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 99;
            this.label9.Text = "UrlImagen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Marca:";
            // 
            // rtbxDescripcion
            // 
            this.rtbxDescripcion.Location = new System.Drawing.Point(177, 291);
            this.rtbxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxDescripcion.Name = "rtbxDescripcion";
            this.rtbxDescripcion.Size = new System.Drawing.Size(249, 61);
            this.rtbxDescripcion.TabIndex = 92;
            this.rtbxDescripcion.Text = "";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(177, 258);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(249, 24);
            this.cbxMarca.TabIndex = 90;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(177, 210);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(249, 24);
            this.cbxCategoria.TabIndex = 89;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(177, 119);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(249, 22);
            this.tbxNombre.TabIndex = 87;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(177, 74);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(249, 22);
            this.tbxCodigo.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Codigo:";
            // 
            // chbxImagen
            // 
            this.chbxImagen.AutoSize = true;
            this.chbxImagen.Location = new System.Drawing.Point(143, 375);
            this.chbxImagen.Margin = new System.Windows.Forms.Padding(4);
            this.chbxImagen.Name = "chbxImagen";
            this.chbxImagen.Size = new System.Drawing.Size(18, 17);
            this.chbxImagen.TabIndex = 108;
            this.chbxImagen.UseVisualStyleBackColor = true;
            this.chbxImagen.CheckedChanged += new System.EventHandler(this.chbxImagen_CheckedChanged);
            // 
            // btnVisualizarArticulo
            // 
            this.btnVisualizarArticulo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVisualizarArticulo.Location = new System.Drawing.Point(463, 258);
            this.btnVisualizarArticulo.Name = "btnVisualizarArticulo";
            this.btnVisualizarArticulo.Size = new System.Drawing.Size(221, 36);
            this.btnVisualizarArticulo.TabIndex = 118;
            this.btnVisualizarArticulo.Text = "Visualizar Articulo";
            this.btnVisualizarArticulo.UseVisualStyleBackColor = false;
            this.btnVisualizarArticulo.Click += new System.EventHandler(this.btnVisualizarArticulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(29, 526);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 38);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.BackColor = System.Drawing.Color.LightGreen;
            this.btnModificarArticulo.Location = new System.Drawing.Point(483, 510);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(182, 54);
            this.btnModificarArticulo.TabIndex = 120;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = false;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 577);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVisualizarArticulo);
            this.Controls.Add(this.txtNImagen);
            this.Controls.Add(this.lblNImagen);
            this.Controls.Add(this.chbxModificarImg);
            this.Controls.Add(this.chbxAgregarImg);
            this.Controls.Add(this.lblModificarImg);
            this.Controls.Add(this.lblAgregarImg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblCodigoArt);
            this.Controls.Add(this.chbxImagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvPrevisualizacion);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxUrlImagen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbxDescripcion);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarArticulo";
            this.Load += new System.EventHandler(this.ModificarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNImagen;
        private System.Windows.Forms.Label lblNImagen;
        private System.Windows.Forms.CheckBox chbxModificarImg;
        private System.Windows.Forms.CheckBox chbxAgregarImg;
        private System.Windows.Forms.Label lblModificarImg;
        private System.Windows.Forms.Label lblAgregarImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblCodigoArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvPrevisualizacion;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxUrlImagen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbxDescripcion;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbxImagen;
        private System.Windows.Forms.Button btnVisualizarArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarArticulo;
    }
}