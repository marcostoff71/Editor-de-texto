﻿
namespace _005_editator_de_texto_forms
{
    partial class EditorDeTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorDeTexto));
            this.TextoPantalla = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gurdarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellecionarFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtLongitud = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLineas = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.atras = new System.Windows.Forms.ToolStripButton();
            this.pegar = new System.Windows.Forms.ToolStripButton();
            this.adelante = new System.Windows.Forms.ToolStripButton();
            this.tamanioFuente = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoPantalla
            // 
            this.TextoPantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoPantalla.Location = new System.Drawing.Point(23, 53);
            this.TextoPantalla.Name = "TextoPantalla";
            this.TextoPantalla.Size = new System.Drawing.Size(812, 355);
            this.TextoPantalla.TabIndex = 0;
            this.TextoPantalla.Text = "";
            this.TextoPantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextoPantalla_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.edicionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.gurdarComoToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // gurdarComoToolStripMenuItem
            // 
            this.gurdarComoToolStripMenuItem.Name = "gurdarComoToolStripMenuItem";
            this.gurdarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gurdarComoToolStripMenuItem.Text = "Gurdar Como";
            this.gurdarComoToolStripMenuItem.Click += new System.EventHandler(this.gurdarComoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar archivo";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellecionarFuenteToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // sellecionarFuenteToolStripMenuItem
            // 
            this.sellecionarFuenteToolStripMenuItem.Name = "sellecionarFuenteToolStripMenuItem";
            this.sellecionarFuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellecionarFuenteToolStripMenuItem.Text = "Sellecionar Fuente";
            this.sellecionarFuenteToolStripMenuItem.Click += new System.EventHandler(this.sellecionarFuenteToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem,
            this.adelanteToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.seleccionTodoToolStripMenuItem,
            this.borrarTodoToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            this.adelanteToolStripMenuItem.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // txtLongitud
            // 
            this.txtLongitud.AutoSize = true;
            this.txtLongitud.Location = new System.Drawing.Point(688, 412);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(13, 13);
            this.txtLongitud.TabIndex = 2;
            this.txtLongitud.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lineas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longitud:";
            // 
            // txtLineas
            // 
            this.txtLineas.AutoSize = true;
            this.txtLineas.Location = new System.Drawing.Point(822, 412);
            this.txtLineas.Name = "txtLineas";
            this.txtLineas.Size = new System.Drawing.Size(13, 13);
            this.txtLineas.TabIndex = 5;
            this.txtLineas.Text = "0";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // seleccionTodoToolStripMenuItem
            // 
            this.seleccionTodoToolStripMenuItem.Name = "seleccionTodoToolStripMenuItem";
            this.seleccionTodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seleccionTodoToolStripMenuItem.Text = "Seleccion Todo";
            this.seleccionTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionTodoToolStripMenuItem_Click);
            // 
            // borrarTodoToolStripMenuItem
            // 
            this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarTodoToolStripMenuItem.Text = "Borrar Todo";
            this.borrarTodoToolStripMenuItem.Click += new System.EventHandler(this.borrarTodoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atras,
            this.pegar,
            this.adelante,
            this.tamanioFuente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // atras
            // 
            this.atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atras.Image = ((System.Drawing.Image)(resources.GetObject("atras.Image")));
            this.atras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(23, 22);
            this.atras.Text = "Atras";
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // pegar
            // 
            this.pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pegar.Image = ((System.Drawing.Image)(resources.GetObject("pegar.Image")));
            this.pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegar.Name = "pegar";
            this.pegar.Size = new System.Drawing.Size(23, 22);
            this.pegar.Text = "pegar";
            this.pegar.Click += new System.EventHandler(this.pegar_Click);
            // 
            // adelante
            // 
            this.adelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adelante.Image = ((System.Drawing.Image)(resources.GetObject("adelante.Image")));
            this.adelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adelante.Name = "adelante";
            this.adelante.Size = new System.Drawing.Size(23, 22);
            this.adelante.Text = "Adelante";
            this.adelante.Click += new System.EventHandler(this.adelante_Click);
            // 
            // tamanioFuente
            // 
            this.tamanioFuente.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.tamanioFuente.Name = "tamanioFuente";
            this.tamanioFuente.Size = new System.Drawing.Size(121, 25);
            this.tamanioFuente.ToolTipText = "Sellecione la letra";
            this.tamanioFuente.SelectedIndexChanged += new System.EventHandler(this.Seleccione);
            // 
            // EditorDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 434);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtLineas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.TextoPantalla);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EditorDeTexto";
            this.Text = "Editor de texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextoPantalla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gurdarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label txtLongitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtLineas;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellecionarFuenteToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton atras;
        private System.Windows.Forms.ToolStripButton pegar;
        private System.Windows.Forms.ToolStripButton adelante;
        private System.Windows.Forms.ToolStripComboBox tamanioFuente;
    }
}

