namespace Concesionaria
{
    partial class FrmAbmBici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmBici));
            this.BarraBotones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnAceptar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.txt_NumeroCuadro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAltaMarca = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmb_CodMarca = new System.Windows.Forms.ComboBox();
            this.txt_Talle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraBotones.SuspendLayout();
            this.Grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraBotones
            // 
            this.BarraBotones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.BarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar,
            this.btnAceptar,
            this.btnCancelar,
            this.btnAbrir,
            this.btnImprimir,
            this.btnSalir});
            this.BarraBotones.Location = new System.Drawing.Point(0, 0);
            this.BarraBotones.Name = "BarraBotones";
            this.BarraBotones.Size = new System.Drawing.Size(490, 39);
            this.BarraBotones.TabIndex = 15;
            this.BarraBotones.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(36, 36);
            this.btnNuevo.Text = "toolStripButton1";
            this.btnNuevo.ToolTipText = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.ToolTipText = "Modificar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 36);
            this.btnEliminar.Text = "toolStripButton3";
            this.btnEliminar.ToolTipText = "Eliminar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(36, 36);
            this.btnAceptar.Text = "Grabar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(36, 36);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(36, 36);
            this.btnImprimir.Text = "toolStripButton1";
            this.btnImprimir.ToolTipText = "Imprimir";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(36, 36);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Grupo
            // 
            this.Grupo.Controls.Add(this.txt_NumeroCuadro);
            this.Grupo.Controls.Add(this.label4);
            this.Grupo.Controls.Add(this.txt_Color);
            this.Grupo.Controls.Add(this.label3);
            this.Grupo.Controls.Add(this.label2);
            this.Grupo.Controls.Add(this.btnAltaMarca);
            this.Grupo.Controls.Add(this.txtCodigo);
            this.Grupo.Controls.Add(this.cmb_CodMarca);
            this.Grupo.Controls.Add(this.txt_Talle);
            this.Grupo.Controls.Add(this.label1);
            this.Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo.Location = new System.Drawing.Point(12, 57);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(461, 150);
            this.Grupo.TabIndex = 16;
            this.Grupo.TabStop = false;
            this.Grupo.Text = "Información ";
            // 
            // txt_NumeroCuadro
            // 
            this.txt_NumeroCuadro.Location = new System.Drawing.Point(95, 112);
            this.txt_NumeroCuadro.Name = "txt_NumeroCuadro";
            this.txt_NumeroCuadro.Size = new System.Drawing.Size(299, 22);
            this.txt_NumeroCuadro.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nro Cuadro";
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(95, 85);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(299, 22);
            this.txt_Color.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Talle";
            // 
            // btnAltaMarca
            // 
            this.btnAltaMarca.Image = global::Concesionaria.Properties.Resources.page_add;
            this.btnAltaMarca.Location = new System.Drawing.Point(400, 30);
            this.btnAltaMarca.Name = "btnAltaMarca";
            this.btnAltaMarca.Size = new System.Drawing.Size(40, 28);
            this.btnAltaMarca.TabIndex = 20;
            this.btnAltaMarca.UseVisualStyleBackColor = true;
            this.btnAltaMarca.Click += new System.EventHandler(this.btnAltaMarca_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(238, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(57, 22);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Visible = false;
            // 
            // cmb_CodMarca
            // 
            this.cmb_CodMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CodMarca.FormattingEnabled = true;
            this.cmb_CodMarca.Location = new System.Drawing.Point(95, 30);
            this.cmb_CodMarca.Name = "cmb_CodMarca";
            this.cmb_CodMarca.Size = new System.Drawing.Size(299, 24);
            this.cmb_CodMarca.TabIndex = 19;
            // 
            // txt_Talle
            // 
            this.txt_Talle.Location = new System.Drawing.Point(95, 57);
            this.txt_Talle.Name = "txt_Talle";
            this.txt_Talle.Size = new System.Drawing.Size(299, 22);
            this.txt_Talle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // FrmAbmBici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 241);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.BarraBotones);
            this.Name = "FrmAbmBici";
            this.Text = "Formulario de bicicletas";
            this.Load += new System.EventHandler(this.FrmAbmBici_Load);
            this.BarraBotones.ResumeLayout(false);
            this.BarraBotones.PerformLayout();
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BarraBotones;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnAceptar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txt_Talle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumeroCuadro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAltaMarca;
        private System.Windows.Forms.ComboBox cmb_CodMarca;
    }
}