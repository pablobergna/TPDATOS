namespace FrbaCommerce.Editar_Publicacion
{
    partial class Editar_Publicacion
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
            this.gb_buscar_publicacion = new System.Windows.Forms.GroupBox();
            this.dg_publicaciones = new System.Windows.Forms.DataGridView();
            this.gb_estado_inicial = new System.Windows.Forms.GroupBox();
            this.rb_finalizada = new System.Windows.Forms.RadioButton();
            this.rb_pausada = new System.Windows.Forms.RadioButton();
            this.rb_borrador = new System.Windows.Forms.RadioButton();
            this.rb_activa = new System.Windows.Forms.RadioButton();
            this.lst_visibilidad = new System.Windows.Forms.ListBox();
            this.lst_pool_rubros = new System.Windows.Forms.ListBox();
            this.rb_compra_inmediata = new System.Windows.Forms.RadioButton();
            this.rb_subasta = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_visibilidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_preguntas = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.gb_datos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sacar_rubro = new System.Windows.Forms.Button();
            this.btn_agregar_rubro = new System.Windows.Forms.Button();
            this.lst_rubros_actuales = new System.Windows.Forms.ListBox();
            this.gb_buscar_publicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_publicaciones)).BeginInit();
            this.gb_estado_inicial.SuspendLayout();
            this.gb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_buscar_publicacion
            // 
            this.gb_buscar_publicacion.Controls.Add(this.dg_publicaciones);
            this.gb_buscar_publicacion.Location = new System.Drawing.Point(12, 7);
            this.gb_buscar_publicacion.Name = "gb_buscar_publicacion";
            this.gb_buscar_publicacion.Size = new System.Drawing.Size(867, 234);
            this.gb_buscar_publicacion.TabIndex = 0;
            this.gb_buscar_publicacion.TabStop = false;
            this.gb_buscar_publicacion.Text = "Buscar Publicacion";
            // 
            // dg_publicaciones
            // 
            this.dg_publicaciones.AllowUserToOrderColumns = true;
            this.dg_publicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_publicaciones.Location = new System.Drawing.Point(30, 32);
            this.dg_publicaciones.Name = "dg_publicaciones";
            this.dg_publicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_publicaciones.Size = new System.Drawing.Size(822, 181);
            this.dg_publicaciones.TabIndex = 1;
            this.dg_publicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_publicaciones_CellContentClick);
            // 
            // gb_estado_inicial
            // 
            this.gb_estado_inicial.Controls.Add(this.rb_finalizada);
            this.gb_estado_inicial.Controls.Add(this.rb_pausada);
            this.gb_estado_inicial.Controls.Add(this.rb_borrador);
            this.gb_estado_inicial.Controls.Add(this.rb_activa);
            this.gb_estado_inicial.Location = new System.Drawing.Point(286, 319);
            this.gb_estado_inicial.Name = "gb_estado_inicial";
            this.gb_estado_inicial.Size = new System.Drawing.Size(115, 141);
            this.gb_estado_inicial.TabIndex = 38;
            this.gb_estado_inicial.TabStop = false;
            this.gb_estado_inicial.Text = "Estado de Publicacion";
            // 
            // rb_finalizada
            // 
            this.rb_finalizada.AutoSize = true;
            this.rb_finalizada.Location = new System.Drawing.Point(20, 112);
            this.rb_finalizada.Name = "rb_finalizada";
            this.rb_finalizada.Size = new System.Drawing.Size(72, 17);
            this.rb_finalizada.TabIndex = 3;
            this.rb_finalizada.TabStop = true;
            this.rb_finalizada.Text = "Finalizada";
            this.rb_finalizada.UseVisualStyleBackColor = true;
            this.rb_finalizada.CheckedChanged += new System.EventHandler(this.rb_finalizada_CheckedChanged);
            // 
            // rb_pausada
            // 
            this.rb_pausada.AutoSize = true;
            this.rb_pausada.Location = new System.Drawing.Point(20, 89);
            this.rb_pausada.Name = "rb_pausada";
            this.rb_pausada.Size = new System.Drawing.Size(67, 17);
            this.rb_pausada.TabIndex = 2;
            this.rb_pausada.TabStop = true;
            this.rb_pausada.Text = "Pausada";
            this.rb_pausada.UseVisualStyleBackColor = true;
            this.rb_pausada.CheckedChanged += new System.EventHandler(this.rb_pausada_CheckedChanged);
            // 
            // rb_borrador
            // 
            this.rb_borrador.AutoSize = true;
            this.rb_borrador.Location = new System.Drawing.Point(20, 42);
            this.rb_borrador.Name = "rb_borrador";
            this.rb_borrador.Size = new System.Drawing.Size(65, 17);
            this.rb_borrador.TabIndex = 1;
            this.rb_borrador.TabStop = true;
            this.rb_borrador.Text = "Borrador";
            this.rb_borrador.UseVisualStyleBackColor = true;
            this.rb_borrador.CheckedChanged += new System.EventHandler(this.rb_borrador_CheckedChanged);
            // 
            // rb_activa
            // 
            this.rb_activa.AutoSize = true;
            this.rb_activa.Location = new System.Drawing.Point(20, 66);
            this.rb_activa.Name = "rb_activa";
            this.rb_activa.Size = new System.Drawing.Size(55, 17);
            this.rb_activa.TabIndex = 0;
            this.rb_activa.TabStop = true;
            this.rb_activa.Text = "Activa";
            this.rb_activa.UseVisualStyleBackColor = true;
            this.rb_activa.CheckedChanged += new System.EventHandler(this.rb_activa_CheckedChanged);
            // 
            // lst_visibilidad
            // 
            this.lst_visibilidad.FormattingEnabled = true;
            this.lst_visibilidad.Location = new System.Drawing.Point(145, 393);
            this.lst_visibilidad.Name = "lst_visibilidad";
            this.lst_visibilidad.Size = new System.Drawing.Size(104, 95);
            this.lst_visibilidad.TabIndex = 37;
            this.lst_visibilidad.SelectedIndexChanged += new System.EventHandler(this.lst_visibilidad_SelectedIndexChanged);
            // 
            // lst_pool_rubros
            // 
            this.lst_pool_rubros.FormattingEnabled = true;
            this.lst_pool_rubros.Location = new System.Drawing.Point(481, 255);
            this.lst_pool_rubros.Name = "lst_pool_rubros";
            this.lst_pool_rubros.Size = new System.Drawing.Size(110, 238);
            this.lst_pool_rubros.TabIndex = 36;
            // 
            // rb_compra_inmediata
            // 
            this.rb_compra_inmediata.AutoSize = true;
            this.rb_compra_inmediata.Location = new System.Drawing.Point(225, 255);
            this.rb_compra_inmediata.Name = "rb_compra_inmediata";
            this.rb_compra_inmediata.Size = new System.Drawing.Size(110, 17);
            this.rb_compra_inmediata.TabIndex = 35;
            this.rb_compra_inmediata.TabStop = true;
            this.rb_compra_inmediata.Text = "Compra Inmediata";
            this.rb_compra_inmediata.UseVisualStyleBackColor = true;
            this.rb_compra_inmediata.CheckedChanged += new System.EventHandler(this.rb_compra_inmediata_CheckedChanged);
            // 
            // rb_subasta
            // 
            this.rb_subasta.AutoSize = true;
            this.rb_subasta.Location = new System.Drawing.Point(145, 255);
            this.rb_subasta.Name = "rb_subasta";
            this.rb_subasta.Size = new System.Drawing.Size(64, 17);
            this.rb_subasta.TabIndex = 34;
            this.rb_subasta.TabStop = true;
            this.rb_subasta.Text = "Subasta";
            this.rb_subasta.UseVisualStyleBackColor = true;
            this.rb_subasta.CheckedChanged += new System.EventHandler(this.rb_subasta_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Permitir Preguntas";
            // 
            // lbl_visibilidad
            // 
            this.lbl_visibilidad.AutoSize = true;
            this.lbl_visibilidad.Location = new System.Drawing.Point(79, 393);
            this.lbl_visibilidad.Name = "lbl_visibilidad";
            this.lbl_visibilidad.Size = new System.Drawing.Size(53, 13);
            this.lbl_visibilidad.TabIndex = 31;
            this.lbl_visibilidad.Text = "Visibilidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Precio";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(102, 283);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(35, 13);
            this.lbl_stock.TabIndex = 28;
            this.lbl_stock.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo Publicacion";
            // 
            // cmb_preguntas
            // 
            this.cmb_preguntas.FormattingEnabled = true;
            this.cmb_preguntas.Location = new System.Drawing.Point(144, 507);
            this.cmb_preguntas.Name = "cmb_preguntas";
            this.cmb_preguntas.Size = new System.Drawing.Size(43, 21);
            this.cmb_preguntas.TabIndex = 26;
            this.cmb_preguntas.SelectedIndexChanged += new System.EventHandler(this.cmb_preguntas_SelectedIndexChanged);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(145, 331);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(68, 20);
            this.txt_precio.TabIndex = 25;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(86, 38);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(620, 178);
            this.txt_descripcion.TabIndex = 24;
            this.txt_descripcion.Text = "";
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(145, 283);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(99, 20);
            this.txt_stock.TabIndex = 23;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(266, 509);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(191, 68);
            this.bt_guardar.TabIndex = 39;
            this.bt_guardar.Text = "Guardar Cambios";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // gb_datos
            // 
            this.gb_datos.Controls.Add(this.label3);
            this.gb_datos.Controls.Add(this.label2);
            this.gb_datos.Controls.Add(this.btn_sacar_rubro);
            this.gb_datos.Controls.Add(this.btn_agregar_rubro);
            this.gb_datos.Controls.Add(this.lst_rubros_actuales);
            this.gb_datos.Controls.Add(this.bt_guardar);
            this.gb_datos.Controls.Add(this.label8);
            this.gb_datos.Controls.Add(this.gb_estado_inicial);
            this.gb_datos.Controls.Add(this.lst_visibilidad);
            this.gb_datos.Controls.Add(this.txt_descripcion);
            this.gb_datos.Controls.Add(this.lst_pool_rubros);
            this.gb_datos.Controls.Add(this.rb_compra_inmediata);
            this.gb_datos.Controls.Add(this.rb_subasta);
            this.gb_datos.Controls.Add(this.label7);
            this.gb_datos.Controls.Add(this.lbl_visibilidad);
            this.gb_datos.Controls.Add(this.label5);
            this.gb_datos.Controls.Add(this.lbl_stock);
            this.gb_datos.Controls.Add(this.label1);
            this.gb_datos.Controls.Add(this.cmb_preguntas);
            this.gb_datos.Controls.Add(this.txt_precio);
            this.gb_datos.Controls.Add(this.txt_stock);
            this.gb_datos.Location = new System.Drawing.Point(12, 256);
            this.gb_datos.Name = "gb_datos";
            this.gb_datos.Size = new System.Drawing.Size(867, 599);
            this.gb_datos.TabIndex = 40;
            this.gb_datos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Rubros de la publicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Rubros disponibles";
            // 
            // btn_sacar_rubro
            // 
            this.btn_sacar_rubro.Location = new System.Drawing.Point(599, 384);
            this.btn_sacar_rubro.Name = "btn_sacar_rubro";
            this.btn_sacar_rubro.Size = new System.Drawing.Size(42, 53);
            this.btn_sacar_rubro.TabIndex = 42;
            this.btn_sacar_rubro.Text = "<<";
            this.btn_sacar_rubro.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_rubro
            // 
            this.btn_agregar_rubro.Location = new System.Drawing.Point(599, 300);
            this.btn_agregar_rubro.Name = "btn_agregar_rubro";
            this.btn_agregar_rubro.Size = new System.Drawing.Size(42, 55);
            this.btn_agregar_rubro.TabIndex = 41;
            this.btn_agregar_rubro.Text = ">>";
            this.btn_agregar_rubro.UseVisualStyleBackColor = true;
            this.btn_agregar_rubro.Click += new System.EventHandler(this.btn_agregar_rubro_Click);
            // 
            // lst_rubros_actuales
            // 
            this.lst_rubros_actuales.FormattingEnabled = true;
            this.lst_rubros_actuales.Location = new System.Drawing.Point(647, 254);
            this.lst_rubros_actuales.Name = "lst_rubros_actuales";
            this.lst_rubros_actuales.Size = new System.Drawing.Size(122, 238);
            this.lst_rubros_actuales.TabIndex = 40;
            // 
            // Editar_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 878);
            this.Controls.Add(this.gb_datos);
            this.Controls.Add(this.gb_buscar_publicacion);
            this.Name = "Editar_Publicacion";
            this.Text = "Editar Publicacion";
            this.Load += new System.EventHandler(this.Editar_Publicacion_Load);
            this.gb_buscar_publicacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_publicaciones)).EndInit();
            this.gb_estado_inicial.ResumeLayout(false);
            this.gb_estado_inicial.PerformLayout();
            this.gb_datos.ResumeLayout(false);
            this.gb_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_buscar_publicacion;
        private System.Windows.Forms.DataGridView dg_publicaciones;
        private System.Windows.Forms.GroupBox gb_estado_inicial;
        private System.Windows.Forms.RadioButton rb_pausada;
        private System.Windows.Forms.RadioButton rb_borrador;
        private System.Windows.Forms.RadioButton rb_activa;
        private System.Windows.Forms.ListBox lst_visibilidad;
        private System.Windows.Forms.ListBox lst_pool_rubros;
        private System.Windows.Forms.RadioButton rb_compra_inmediata;
        private System.Windows.Forms.RadioButton rb_subasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_visibilidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_preguntas;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.RadioButton rb_finalizada;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.GroupBox gb_datos;
        private System.Windows.Forms.ListBox lst_rubros_actuales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sacar_rubro;
        private System.Windows.Forms.Button btn_agregar_rubro;

    }
}