﻿
namespace TacticaReparaciones.DesktopApp.Pantallas
{
    partial class frmIngresos
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
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.glCorreoElectronico = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glCorreo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRegistroId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscarEmpresa = new FontAwesome.Sharp.IconButton();
            this.glContacto = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregarNuevInstrumento = new FontAwesome.Sharp.IconButton();
            this.gcInstrumentosDeEmpresa = new DevExpress.XtraGrid.GridControl();
            this.gvInstrumentosDeEmpresa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glTipoInstrumento = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.popupViewTipoInstrumentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glMarcaPopup = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.popupViewMarca = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.glPopupModelo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarIngreso = new FontAwesome.Sharp.IconButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.glTiposTrabajo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.glTipoTrabajo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalInstrumentos = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentosDeEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentosDeEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupViewTipoInstrumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcaPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupViewMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPopupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(54, 60);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nombre de Empresa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 124);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nombre de Contacto:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 179);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 17);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Correo Electrónico:";
            // 
            // glCorreoElectronico
            // 
            this.glCorreoElectronico.Location = new System.Drawing.Point(54, 202);
            this.glCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glCorreoElectronico.Name = "glCorreoElectronico";
            this.glCorreoElectronico.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glCorreoElectronico.Properties.Appearance.Options.UseFont = true;
            this.glCorreoElectronico.Properties.NullText = "";
            this.glCorreoElectronico.Properties.PopupView = this.glCorreo;
            this.glCorreoElectronico.Size = new System.Drawing.Size(420, 26);
            this.glCorreoElectronico.TabIndex = 5;
            // 
            // glCorreo
            // 
            this.glCorreo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRegistroId,
            this.colDireccion});
            this.glCorreo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glCorreo.Name = "glCorreo";
            this.glCorreo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glCorreo.OptionsView.ShowGroupPanel = false;
            this.glCorreo.OptionsView.ShowIndicator = false;
            // 
            // colRegistroId
            // 
            this.colRegistroId.Caption = "Id";
            this.colRegistroId.FieldName = "RegistroId";
            this.colRegistroId.Name = "colRegistroId";
            this.colRegistroId.OptionsColumn.AllowEdit = false;
            this.colRegistroId.OptionsColumn.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Correo";
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.OptionsColumn.AllowEdit = false;
            this.colDireccion.OptionsColumn.ReadOnly = true;
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 0;
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarEmpresa.IconColor = System.Drawing.Color.Black;
            this.btnBuscarEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEmpresa.IconSize = 30;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(724, 86);
            this.btnBuscarEmpresa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(43, 32);
            this.btnBuscarEmpresa.TabIndex = 7;
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            this.btnBuscarEmpresa.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // glContacto
            // 
            this.glContacto.EditValue = "";
            this.glContacto.Location = new System.Drawing.Point(54, 147);
            this.glContacto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glContacto.Name = "glContacto";
            this.glContacto.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glContacto.Properties.Appearance.Options.UseFont = true;
            this.glContacto.Properties.NullText = "";
            this.glContacto.Properties.PopupView = this.glContactos;
            this.glContacto.Properties.EditValueChanged += new System.EventHandler(this.glContacto_Properties_EditValueChanged);
            this.glContacto.Size = new System.Drawing.Size(654, 26);
            this.glContacto.TabIndex = 8;
            // 
            // glContactos
            // 
            this.glContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreContacto,
            this.colCargo,
            this.colContactoId});
            this.glContactos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glContactos.Name = "glContactos";
            this.glContactos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glContactos.OptionsView.ShowGroupPanel = false;
            this.glContactos.OptionsView.ShowIndicator = false;
            // 
            // colNombreContacto
            // 
            this.colNombreContacto.Caption = "Nombre";
            this.colNombreContacto.FieldName = "Nombre";
            this.colNombreContacto.Name = "colNombreContacto";
            this.colNombreContacto.OptionsColumn.AllowEdit = false;
            this.colNombreContacto.OptionsColumn.ReadOnly = true;
            this.colNombreContacto.Visible = true;
            this.colNombreContacto.VisibleIndex = 0;
            // 
            // colCargo
            // 
            this.colCargo.Caption = "Cargo";
            this.colCargo.FieldName = "Cargo";
            this.colCargo.Name = "colCargo";
            this.colCargo.OptionsColumn.AllowEdit = false;
            this.colCargo.OptionsColumn.ReadOnly = true;
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 1;
            // 
            // colContactoId
            // 
            this.colContactoId.Caption = "Contacto Id";
            this.colContactoId.FieldName = "ContactoId";
            this.colContactoId.Name = "colContactoId";
            this.colContactoId.OptionsColumn.AllowEdit = false;
            this.colContactoId.OptionsColumn.ReadOnly = true;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.EditValue = "";
            this.txtEmpresa.Location = new System.Drawing.Point(54, 83);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmpresa.Properties.Appearance.Options.UseFont = true;
            this.txtEmpresa.Properties.ReadOnly = true;
            this.txtEmpresa.Properties.UseReadOnlyAppearance = false;
            this.txtEmpresa.Size = new System.Drawing.Size(654, 30);
            this.txtEmpresa.TabIndex = 9;
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(819, 39);
            this.ctlEncabezadoPantalla1.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(54, 255);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(227, 17);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Seleccione uno o varios instrumentos";
            // 
            // btnAgregarNuevInstrumento
            // 
            this.btnAgregarNuevInstrumento.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevInstrumento.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarNuevInstrumento.IconColor = System.Drawing.Color.Black;
            this.btnAgregarNuevInstrumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarNuevInstrumento.IconSize = 30;
            this.btnAgregarNuevInstrumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarNuevInstrumento.Location = new System.Drawing.Point(547, 241);
            this.btnAgregarNuevInstrumento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregarNuevInstrumento.Name = "btnAgregarNuevInstrumento";
            this.btnAgregarNuevInstrumento.Size = new System.Drawing.Size(220, 32);
            this.btnAgregarNuevInstrumento.TabIndex = 15;
            this.btnAgregarNuevInstrumento.Text = "Nuevo Instrumento";
            this.btnAgregarNuevInstrumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevInstrumento.UseVisualStyleBackColor = true;
            this.btnAgregarNuevInstrumento.Click += new System.EventHandler(this.btnAgregarNuevInstrumento_Click);
            // 
            // gcInstrumentosDeEmpresa
            // 
            this.gcInstrumentosDeEmpresa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcInstrumentosDeEmpresa.Location = new System.Drawing.Point(54, 278);
            this.gcInstrumentosDeEmpresa.MainView = this.gvInstrumentosDeEmpresa;
            this.gcInstrumentosDeEmpresa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcInstrumentosDeEmpresa.Name = "gcInstrumentosDeEmpresa";
            this.gcInstrumentosDeEmpresa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.glTipoInstrumento,
            this.glMarcaPopup,
            this.glPopupModelo});
            this.gcInstrumentosDeEmpresa.Size = new System.Drawing.Size(713, 130);
            this.gcInstrumentosDeEmpresa.TabIndex = 16;
            this.gcInstrumentosDeEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInstrumentosDeEmpresa});
            // 
            // gvInstrumentosDeEmpresa
            // 
            this.gvInstrumentosDeEmpresa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion,
            this.colTipo,
            this.colMarca,
            this.colModelo});
            this.gvInstrumentosDeEmpresa.GridControl = this.gcInstrumentosDeEmpresa;
            this.gvInstrumentosDeEmpresa.Name = "gvInstrumentosDeEmpresa";
            this.gvInstrumentosDeEmpresa.OptionsView.ShowAutoFilterRow = true;
            this.gvInstrumentosDeEmpresa.OptionsView.ShowGroupPanel = false;
            this.gvInstrumentosDeEmpresa.OptionsView.ShowIndicator = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.MinWidth = 23;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 87;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.ColumnEdit = this.glTipoInstrumento;
            this.colTipo.FieldName = "TipoInstrumento.Descripcion";
            this.colTipo.MinWidth = 23;
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 87;
            // 
            // glTipoInstrumento
            // 
            this.glTipoInstrumento.AutoHeight = false;
            this.glTipoInstrumento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glTipoInstrumento.Name = "glTipoInstrumento";
            this.glTipoInstrumento.NullText = "";
            this.glTipoInstrumento.PopupView = this.popupViewTipoInstrumentos;
            this.glTipoInstrumento.ReadOnly = true;
            // 
            // popupViewTipoInstrumentos
            // 
            this.popupViewTipoInstrumentos.DetailHeight = 431;
            this.popupViewTipoInstrumentos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.popupViewTipoInstrumentos.Name = "popupViewTipoInstrumentos";
            this.popupViewTipoInstrumentos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.popupViewTipoInstrumentos.OptionsView.ShowGroupPanel = false;
            this.popupViewTipoInstrumentos.OptionsView.ShowIndicator = false;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.ColumnEdit = this.glMarcaPopup;
            this.colMarca.FieldName = "Marca.Descripcion";
            this.colMarca.MinWidth = 23;
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.OptionsColumn.ReadOnly = true;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 2;
            this.colMarca.Width = 87;
            // 
            // glMarcaPopup
            // 
            this.glMarcaPopup.AutoHeight = false;
            this.glMarcaPopup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glMarcaPopup.Name = "glMarcaPopup";
            this.glMarcaPopup.NullText = "";
            this.glMarcaPopup.PopupView = this.popupViewMarca;
            // 
            // popupViewMarca
            // 
            this.popupViewMarca.DetailHeight = 431;
            this.popupViewMarca.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.popupViewMarca.Name = "popupViewMarca";
            this.popupViewMarca.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.popupViewMarca.OptionsView.ShowGroupPanel = false;
            this.popupViewMarca.OptionsView.ShowIndicator = false;
            // 
            // colModelo
            // 
            this.colModelo.Caption = "Modelo";
            this.colModelo.ColumnEdit = this.glPopupModelo;
            this.colModelo.FieldName = "Modelo.Descripcion";
            this.colModelo.MinWidth = 23;
            this.colModelo.Name = "colModelo";
            this.colModelo.OptionsColumn.AllowEdit = false;
            this.colModelo.OptionsColumn.ReadOnly = true;
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 3;
            this.colModelo.Width = 87;
            // 
            // glPopupModelo
            // 
            this.glPopupModelo.AutoHeight = false;
            this.glPopupModelo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPopupModelo.Name = "glPopupModelo";
            this.glPopupModelo.NullText = "";
            this.glPopupModelo.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 431;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(54, 445);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 17);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Tipo de Trabajo:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(52, 516);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 17);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Comentarios";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(54, 614);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 17);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Prioridad:";
            // 
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.FlatAppearance.BorderSize = 0;
            this.btnGuardarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIngreso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarIngreso.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarIngreso.IconColor = System.Drawing.Color.Black;
            this.btnGuardarIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarIngreso.IconSize = 30;
            this.btnGuardarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarIngreso.Location = new System.Drawing.Point(547, 691);
            this.btnGuardarIngreso.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(220, 52);
            this.btnGuardarIngreso.TabIndex = 23;
            this.btnGuardarIngreso.Text = "Guardar Ingreso";
            this.btnGuardarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarIngreso.UseVisualStyleBackColor = true;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(54, 539);
            this.memoEdit1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(710, 59);
            this.memoEdit1.TabIndex = 24;
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = 1;
            this.trackBarControl1.Location = new System.Drawing.Point(54, 637);
            this.trackBarControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.AutoSize = false;
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "1";
            trackBarLabel1.Value = 1;
            trackBarLabel2.Label = "2";
            trackBarLabel2.Value = 2;
            trackBarLabel3.Label = "3";
            trackBarLabel3.Value = 3;
            trackBarLabel4.Label = "4";
            trackBarLabel4.Value = 4;
            trackBarLabel5.Label = "5";
            trackBarLabel5.Value = 5;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2,
            trackBarLabel3,
            trackBarLabel4,
            trackBarLabel5});
            this.trackBarControl1.Properties.Maximum = 5;
            this.trackBarControl1.Properties.Minimum = 1;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Size = new System.Drawing.Size(273, 52);
            this.trackBarControl1.TabIndex = 25;
            this.trackBarControl1.Value = 1;
            // 
            // glTiposTrabajo
            // 
            this.glTiposTrabajo.Location = new System.Drawing.Point(54, 468);
            this.glTiposTrabajo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.glTiposTrabajo.Name = "glTiposTrabajo";
            this.glTiposTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glTiposTrabajo.Properties.Appearance.Options.UseFont = true;
            this.glTiposTrabajo.Properties.NullText = "";
            this.glTiposTrabajo.Properties.PopupView = this.glTipoTrabajo;
            this.glTiposTrabajo.Size = new System.Drawing.Size(340, 26);
            this.glTiposTrabajo.TabIndex = 26;
            // 
            // glTipoTrabajo
            // 
            this.glTipoTrabajo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.glTipoTrabajo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.glTipoTrabajo.Name = "glTipoTrabajo";
            this.glTipoTrabajo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.glTipoTrabajo.OptionsView.ShowColumnHeaders = false;
            this.glTipoTrabajo.OptionsView.ShowGroupPanel = false;
            this.glTipoTrabajo.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "TipoTrabajoId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo de Trabajo";
            this.gridColumn2.FieldName = "Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // lblTotalInstrumentos
            // 
            this.lblTotalInstrumentos.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalInstrumentos.Appearance.Options.UseFont = true;
            this.lblTotalInstrumentos.Location = new System.Drawing.Point(54, 412);
            this.lblTotalInstrumentos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblTotalInstrumentos.Name = "lblTotalInstrumentos";
            this.lblTotalInstrumentos.Size = new System.Drawing.Size(7, 17);
            this.lblTotalInstrumentos.TabIndex = 27;
            this.lblTotalInstrumentos.Text = "0";
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 754);
            this.Controls.Add(this.lblTotalInstrumentos);
            this.Controls.Add(this.glTiposTrabajo);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.btnGuardarIngreso);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gcInstrumentosDeEmpresa);
            this.Controls.Add(this.btnAgregarNuevInstrumento);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.glContacto);
            this.Controls.Add(this.btnBuscarEmpresa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.glCorreoElectronico);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.glCorreoElectronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInstrumentosDeEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInstrumentosDeEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoInstrumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupViewTipoInstrumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glMarcaPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupViewMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPopupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTiposTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glTipoTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit glCorreoElectronico;
        private DevExpress.XtraGrid.Views.Grid.GridView glCorreo;
        private FontAwesome.Sharp.IconButton btnBuscarEmpresa;
        private DevExpress.XtraEditors.GridLookUpEdit glContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView glContactos;
        private DevExpress.XtraEditors.TextEdit txtEmpresa;
        private System.Windows.Forms.ToolTip toolTip1;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantallaPopupEmpresas;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla3;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colContactoId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroId;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private FontAwesome.Sharp.IconButton btnAgregarNuevInstrumento;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private FontAwesome.Sharp.IconButton btnGuardarIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gcInstrumentosDeEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInstrumentosDeEmpresa;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.GridLookUpEdit glTiposTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView glTipoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glTipoInstrumento;
        private DevExpress.XtraGrid.Views.Grid.GridView popupViewTipoInstrumentos;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glMarcaPopup;
        private DevExpress.XtraGrid.Views.Grid.GridView popupViewMarca;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit glPopupModelo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblTotalInstrumentos;
    }
}