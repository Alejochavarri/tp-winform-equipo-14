namespace WindowsFormsApp
{
    partial class Form1
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFotoDer = new System.Windows.Forms.Button();
            this.btnFotoIzq = new System.Windows.Forms.Button();
            this.lblFotos = new System.Windows.Forms.Label();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 70);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(658, 186);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            this.dgvArticulos.DoubleClick += new System.EventHandler(this.dgvArticulos_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCatalogoToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // verCatalogoToolStripMenuItem
            // 
            this.verCatalogoToolStripMenuItem.Name = "verCatalogoToolStripMenuItem";
            this.verCatalogoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.verCatalogoToolStripMenuItem.Text = "Ver Catalogo";
            this.verCatalogoToolStripMenuItem.Click += new System.EventHandler(this.verCatalogoToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click_1);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(676, 70);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(231, 186);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 2;
            this.pbxArticulo.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(58, 38);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(190, 20);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(324, 274);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 19);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar selección";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(170, 274);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 19);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar seleccion";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 274);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregar.Size = new System.Drawing.Size(113, 19);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Cargar nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFotoDer
            // 
            this.btnFotoDer.Location = new System.Drawing.Point(850, 271);
            this.btnFotoDer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFotoDer.Name = "btnFotoDer";
            this.btnFotoDer.Size = new System.Drawing.Size(56, 19);
            this.btnFotoDer.TabIndex = 9;
            this.btnFotoDer.Text = "Next";
            this.btnFotoDer.UseVisualStyleBackColor = true;
            this.btnFotoDer.Click += new System.EventHandler(this.btnFotoDer_Click);
            // 
            // btnFotoIzq
            // 
            this.btnFotoIzq.Location = new System.Drawing.Point(676, 271);
            this.btnFotoIzq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFotoIzq.Name = "btnFotoIzq";
            this.btnFotoIzq.Size = new System.Drawing.Size(56, 19);
            this.btnFotoIzq.TabIndex = 10;
            this.btnFotoIzq.Text = "Prev";
            this.btnFotoIzq.UseVisualStyleBackColor = true;
            this.btnFotoIzq.Click += new System.EventHandler(this.btnFotoIzq_Click);
            // 
            // lblFotos
            // 
            this.lblFotos.AutoSize = true;
            this.lblFotos.Location = new System.Drawing.Point(767, 273);
            this.lblFotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(54, 13);
            this.lblFotos.TabIndex = 11;
            this.lblFotos.Text = "Foto 1 / 1";
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Location = new System.Drawing.Point(543, 274);
            this.btnDetalleArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(113, 19);
            this.btnDetalleArticulo.TabIndex = 12;
            this.btnDetalleArticulo.Text = "Detalle Articulo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 313);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.lblFotos);
            this.Controls.Add(this.btnFotoIzq);
            this.Controls.Add(this.btnFotoDer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCatalogoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFotoDer;
        private System.Windows.Forms.Button btnFotoIzq;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.Button btnDetalleArticulo;
    }
}

