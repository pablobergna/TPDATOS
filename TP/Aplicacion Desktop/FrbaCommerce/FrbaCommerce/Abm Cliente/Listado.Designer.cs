﻿namespace FrbaCommerce.Abm_Cliente
{
    partial class Listado
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
            this.tabUsuarios = new System.Windows.Forms.TabControl();
            this.tabPageCliente = new System.Windows.Forms.TabPage();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEmpresa = new System.Windows.Forms.TabPage();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.lnkLimpiarEmp = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMailEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCUITEmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHabilitarEmp = new System.Windows.Forms.Button();
            this.btnInhabilitarEmp = new System.Windows.Forms.Button();
            this.btnBajaEmp = new System.Windows.Forms.Button();
            this.btnModificarEmp = new System.Windows.Forms.Button();
            this.btnCrearEmp = new System.Windows.Forms.Button();
            this.dataGridEmpresa = new System.Windows.Forms.DataGridView();
            this.txtEmpRazon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.tabUsuarios.SuspendLayout();
            this.tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.tabPageEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tabPageCliente);
            this.tabUsuarios.Controls.Add(this.tabPageEmpresa);
            this.tabUsuarios.Controls.Add(this.tabPageAdmin);
            this.tabUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUsuarios.Location = new System.Drawing.Point(12, 15);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.SelectedIndex = 0;
            this.tabUsuarios.Size = new System.Drawing.Size(710, 488);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Tag = "";
            // 
            // tabPageCliente
            // 
            this.tabPageCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCliente.Controls.Add(this.btnHabilitar);
            this.tabPageCliente.Controls.Add(this.btnInhabilitar);
            this.tabPageCliente.Controls.Add(this.linkLabel1);
            this.tabPageCliente.Controls.Add(this.label8);
            this.tabPageCliente.Controls.Add(this.btnEliminar);
            this.tabPageCliente.Controls.Add(this.btnModificar);
            this.tabPageCliente.Controls.Add(this.btnCrear);
            this.tabPageCliente.Controls.Add(this.btnBuscar);
            this.tabPageCliente.Controls.Add(this.dataGridClientes);
            this.tabPageCliente.Controls.Add(this.txtMail);
            this.tabPageCliente.Controls.Add(this.label5);
            this.tabPageCliente.Controls.Add(this.txtDocumento);
            this.tabPageCliente.Controls.Add(this.label4);
            this.tabPageCliente.Controls.Add(this.cmbTipoDoc);
            this.tabPageCliente.Controls.Add(this.label3);
            this.tabPageCliente.Controls.Add(this.txtApellido);
            this.tabPageCliente.Controls.Add(this.label2);
            this.tabPageCliente.Controls.Add(this.txtNombre);
            this.tabPageCliente.Controls.Add(this.label1);
            this.tabPageCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCliente.Location = new System.Drawing.Point(4, 25);
            this.tabPageCliente.Name = "tabPageCliente";
            this.tabPageCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCliente.Size = new System.Drawing.Size(702, 459);
            this.tabPageCliente.TabIndex = 0;
            this.tabPageCliente.Text = "Usuarios Cliente";
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Location = new System.Drawing.Point(421, 387);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(125, 30);
            this.btnHabilitar.TabIndex = 52;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(288, 387);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(125, 30);
            this.btnInhabilitar.TabIndex = 51;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(572, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 17);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Limpiar Campos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Seleccione el filtro y presione Buscar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(554, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 30);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Dar de Baja";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(155, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 30);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(22, 387);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(125, 30);
            this.btnCrear.TabIndex = 46;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(542, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AllowUserToResizeRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(21, 124);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(660, 245);
            this.dataGridClientes.TabIndex = 44;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(542, 43);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 23);
            this.txtMail.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Correo Electronico";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(402, 86);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 23);
            this.txtDocumento.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Numero de documento";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(151, 86);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(74, 24);
            this.cmbTipoDoc.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo de Documento";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(300, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(77, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 23);
            this.txtNombre.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // tabPageEmpresa
            // 
            this.tabPageEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageEmpresa.Controls.Add(this.btnBuscarEmp);
            this.tabPageEmpresa.Controls.Add(this.lnkLimpiarEmp);
            this.tabPageEmpresa.Controls.Add(this.label10);
            this.tabPageEmpresa.Controls.Add(this.txtMailEmp);
            this.tabPageEmpresa.Controls.Add(this.label9);
            this.tabPageEmpresa.Controls.Add(this.txtCUITEmp);
            this.tabPageEmpresa.Controls.Add(this.label7);
            this.tabPageEmpresa.Controls.Add(this.btnHabilitarEmp);
            this.tabPageEmpresa.Controls.Add(this.btnInhabilitarEmp);
            this.tabPageEmpresa.Controls.Add(this.btnBajaEmp);
            this.tabPageEmpresa.Controls.Add(this.btnModificarEmp);
            this.tabPageEmpresa.Controls.Add(this.btnCrearEmp);
            this.tabPageEmpresa.Controls.Add(this.dataGridEmpresa);
            this.tabPageEmpresa.Controls.Add(this.txtEmpRazon);
            this.tabPageEmpresa.Controls.Add(this.label6);
            this.tabPageEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmpresa.Name = "tabPageEmpresa";
            this.tabPageEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmpresa.Size = new System.Drawing.Size(702, 459);
            this.tabPageEmpresa.TabIndex = 1;
            this.tabPageEmpresa.Text = "Usuarios Empresa";
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.Location = new System.Drawing.Point(591, 101);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(88, 30);
            this.btnBuscarEmp.TabIndex = 65;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // lnkLimpiarEmp
            // 
            this.lnkLimpiarEmp.AutoSize = true;
            this.lnkLimpiarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLimpiarEmp.Location = new System.Drawing.Point(570, 24);
            this.lnkLimpiarEmp.Name = "lnkLimpiarEmp";
            this.lnkLimpiarEmp.Size = new System.Drawing.Size(109, 17);
            this.lnkLimpiarEmp.TabIndex = 64;
            this.lnkLimpiarEmp.TabStop = true;
            this.lnkLimpiarEmp.Text = "Limpiar Campos";
            this.lnkLimpiarEmp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLimpiarEmp_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(279, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Seleccione el filtro y presione Buscar";
            // 
            // txtMailEmp
            // 
            this.txtMailEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailEmp.Location = new System.Drawing.Point(148, 105);
            this.txtMailEmp.Name = "txtMailEmp";
            this.txtMailEmp.Size = new System.Drawing.Size(129, 23);
            this.txtMailEmp.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Correo electronico";
            // 
            // txtCUITEmp
            // 
            this.txtCUITEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUITEmp.Location = new System.Drawing.Point(330, 66);
            this.txtCUITEmp.Name = "txtCUITEmp";
            this.txtCUITEmp.Size = new System.Drawing.Size(129, 23);
            this.txtCUITEmp.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "CUIT";
            // 
            // btnHabilitarEmp
            // 
            this.btnHabilitarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarEmp.Location = new System.Drawing.Point(421, 413);
            this.btnHabilitarEmp.Name = "btnHabilitarEmp";
            this.btnHabilitarEmp.Size = new System.Drawing.Size(125, 30);
            this.btnHabilitarEmp.TabIndex = 58;
            this.btnHabilitarEmp.Text = "Habilitar";
            this.btnHabilitarEmp.UseVisualStyleBackColor = true;
            this.btnHabilitarEmp.Click += new System.EventHandler(this.btnHabilitarEmp_Click);
            // 
            // btnInhabilitarEmp
            // 
            this.btnInhabilitarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitarEmp.Location = new System.Drawing.Point(288, 413);
            this.btnInhabilitarEmp.Name = "btnInhabilitarEmp";
            this.btnInhabilitarEmp.Size = new System.Drawing.Size(125, 30);
            this.btnInhabilitarEmp.TabIndex = 57;
            this.btnInhabilitarEmp.Text = "Inhabilitar";
            this.btnInhabilitarEmp.UseVisualStyleBackColor = true;
            this.btnInhabilitarEmp.Click += new System.EventHandler(this.btnInhabilitarEmp_Click);
            // 
            // btnBajaEmp
            // 
            this.btnBajaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaEmp.Location = new System.Drawing.Point(554, 413);
            this.btnBajaEmp.Name = "btnBajaEmp";
            this.btnBajaEmp.Size = new System.Drawing.Size(125, 30);
            this.btnBajaEmp.TabIndex = 56;
            this.btnBajaEmp.Text = "Dar de Baja";
            this.btnBajaEmp.UseVisualStyleBackColor = true;
            this.btnBajaEmp.Click += new System.EventHandler(this.btnBajaEmp_Click);
            // 
            // btnModificarEmp
            // 
            this.btnModificarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEmp.Location = new System.Drawing.Point(155, 413);
            this.btnModificarEmp.Name = "btnModificarEmp";
            this.btnModificarEmp.Size = new System.Drawing.Size(125, 30);
            this.btnModificarEmp.TabIndex = 55;
            this.btnModificarEmp.Text = "Modificar";
            this.btnModificarEmp.UseVisualStyleBackColor = true;
            this.btnModificarEmp.Click += new System.EventHandler(this.btnModificarEmp_Click);
            // 
            // btnCrearEmp
            // 
            this.btnCrearEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmp.Location = new System.Drawing.Point(22, 413);
            this.btnCrearEmp.Name = "btnCrearEmp";
            this.btnCrearEmp.Size = new System.Drawing.Size(125, 30);
            this.btnCrearEmp.TabIndex = 54;
            this.btnCrearEmp.Text = "Crear";
            this.btnCrearEmp.UseVisualStyleBackColor = true;
            this.btnCrearEmp.Click += new System.EventHandler(this.btnCrearEmp_Click);
            // 
            // dataGridEmpresa
            // 
            this.dataGridEmpresa.AllowUserToAddRows = false;
            this.dataGridEmpresa.AllowUserToDeleteRows = false;
            this.dataGridEmpresa.AllowUserToResizeRows = false;
            this.dataGridEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpresa.Location = new System.Drawing.Point(21, 150);
            this.dataGridEmpresa.MultiSelect = false;
            this.dataGridEmpresa.Name = "dataGridEmpresa";
            this.dataGridEmpresa.ReadOnly = true;
            this.dataGridEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresa.Size = new System.Drawing.Size(658, 257);
            this.dataGridEmpresa.TabIndex = 53;
            // 
            // txtEmpRazon
            // 
            this.txtEmpRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpRazon.Location = new System.Drawing.Point(116, 63);
            this.txtEmpRazon.Name = "txtEmpRazon";
            this.txtEmpRazon.Size = new System.Drawing.Size(161, 23);
            this.txtEmpRazon.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Razon Social";
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(702, 459);
            this.tabPageAdmin.TabIndex = 2;
            this.tabPageAdmin.Text = "Administradores";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.tabUsuarios);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.tabUsuarios.ResumeLayout(false);
            this.tabPageCliente.ResumeLayout(false);
            this.tabPageCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.tabPageEmpresa.ResumeLayout(false);
            this.tabPageEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsuarios;
        private System.Windows.Forms.TabPage tabPageCliente;
        private System.Windows.Forms.TabPage tabPageEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnHabilitarEmp;
        private System.Windows.Forms.Button btnInhabilitarEmp;
        private System.Windows.Forms.Button btnBajaEmp;
        private System.Windows.Forms.Button btnModificarEmp;
        private System.Windows.Forms.Button btnCrearEmp;
        private System.Windows.Forms.DataGridView dataGridEmpresa;
        private System.Windows.Forms.TextBox txtEmpRazon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCUITEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.LinkLabel lnkLimpiarEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMailEmp;
        private System.Windows.Forms.Label label9;


    }
}