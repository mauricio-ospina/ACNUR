namespace WinAdministrator.Views.StepsFlowView
{
    partial class StepsFlowView
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
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.StepsFlowModuleGridControl = new DevExpress.XtraGrid.GridControl();
            this.StepsFlowModuleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StepsFlowModuleBarManager = new DevExpress.XtraBars.BarManager();
            this.StepsFlowModuleBar = new DevExpress.XtraBars.Bar();
            this.StepsFlowModuleXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
            this.StepsFlowModulePopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiStepsFlowModuleNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStepsFlowModuleEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStepsFlowModuleDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStepsFlowModuleRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBarManager)).BeginInit();

            this.SuspendLayout();
            // 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
            this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
            this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
            this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
            this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.stepsFlowViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stepsFlowViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.StepsFlow);
            this.dataLayoutControl1.DataSource = stepsFlowViewBindingSource;
            //
            //Create GridControls
            //
            DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
            parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
            //
            //StepsFlowModuleGridControl
            //
            this.StepsFlowModuleGridControl.MainView = this.StepsFlowModuleGridView;
            this.StepsFlowModuleGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StepsFlowModuleGridControl.Name = "StepsFlowModuleGridControl";
            this.StepsFlowModuleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StepsFlowModuleGridView});
            //
            //StepsFlowModuleGridView
            //
            this.StepsFlowModuleGridView.GridControl = this.StepsFlowModuleGridControl;
            this.StepsFlowModuleGridView.Name = "StepsFlowModuleGridView";
            this.StepsFlowModuleGridView.OptionsBehavior.Editable = false;
            this.StepsFlowModuleGridView.OptionsBehavior.ReadOnly = true;
            this.StepsFlowModuleGridView.OptionsView.ShowGroupPanel = false;
            //
            //StepsFlowModulePopulateColumnsParameters
            //
            DevExpress.XtraGrid.Extensions.PopulateColumnsParameters StepsFlowModulePopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();

            DevExpress.XtraGrid.Extensions.PopulateColumnParameters StepsFlowModuleUserStepsFlowModuleChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StepsFlowModuleUserStepsFlowModuleChildPopulateColumnParameters_NotVisible.FieldName = "StepsFlowModuleUser";
            StepsFlowModuleUserStepsFlowModuleChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
            StepsFlowModulePopulateColumnsParameters.CustomColumnParameters.Add(StepsFlowModuleUserStepsFlowModuleChildPopulateColumnParameters_NotVisible);

            DevExpress.XtraGrid.Extensions.PopulateColumnParameters IdStepFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            IdStepFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible.FieldName = "IdStepFlow";
            IdStepFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
            StepsFlowModulePopulateColumnsParameters.CustomColumnParameters.Add(IdStepFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible);

            DevExpress.XtraGrid.Extensions.PopulateColumnParameters IdModuleStepsFlowModuleChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            IdModuleStepsFlowModuleChildPopulateColumnParameters_NotVisible.FieldName = "IdModule";
            IdModuleStepsFlowModuleChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
            StepsFlowModulePopulateColumnsParameters.CustomColumnParameters.Add(IdModuleStepsFlowModuleChildPopulateColumnParameters_NotVisible);

            DevExpress.XtraGrid.Extensions.PopulateColumnParameters StepsFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            StepsFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible.FieldName = "StepsFlow";
            StepsFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
            StepsFlowModulePopulateColumnsParameters.CustomColumnParameters.Add(StepsFlowStepsFlowModuleChildPopulateColumnParameters_NotVisible);


            DevExpress.XtraGrid.Extensions.PopulateColumnParameters ModulesStepsFlowModuleChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ModulesStepsFlowModuleChildPopulateColumnParameters.FieldName = "ModulesStepsFlowModule";
            ModulesStepsFlowModuleChildPopulateColumnParameters.Path = "Modules.ModuleName";
            StepsFlowModulePopulateColumnsParameters.CustomColumnParameters.Add(ModulesStepsFlowModuleChildPopulateColumnParameters);

            this.StepsFlowModuleGridView.PopulateColumns(typeof(Acnur.App.Repository.Data.StepsFlowModule), StepsFlowModulePopulateColumnsParameters);
            //
            //StepsFlowModuleBindingSource
            //
            System.Windows.Forms.BindingSource StepsFlowModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            StepsFlowModuleBindingSource.DataSource = typeof(Acnur.App.Repository.Data.StepsFlowModule);
            this.StepsFlowModuleGridControl.DataSource = StepsFlowModuleBindingSource;
            //
            //StepsFlowModuleXtraUserControl
            //
            this.StepsFlowModuleXtraUserControl.Controls.Add(StepsFlowModuleGridControl);
            this.StepsFlowModuleXtraUserControl.Name = "StepsFlowModuleXtraUserControl";
            this.StepsFlowModuleXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100);
            //
            //StepsFlowModuleNew
            //
            this.bbiStepsFlowModuleNew.Caption = "New";
            this.bbiStepsFlowModuleNew.Name = "bbiStepsFlowModuleNew";
            this.bbiStepsFlowModuleNew.ImageUri.Uri = "New";
            this.bbiStepsFlowModuleNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.StepsFlowModuleBarManager.Items.Add(this.bbiStepsFlowModuleNew);
            this.StepsFlowModuleBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleNew));
            this.StepsFlowModulePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleNew));
            //
            //StepsFlowModuleEdit
            //
            this.bbiStepsFlowModuleEdit.Caption = "Edit";
            this.bbiStepsFlowModuleEdit.Name = "bbiStepsFlowModuleEdit";
            this.bbiStepsFlowModuleEdit.ImageUri.Uri = "Edit";
            this.bbiStepsFlowModuleEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.StepsFlowModuleBarManager.Items.Add(this.bbiStepsFlowModuleEdit);
            this.StepsFlowModuleBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleEdit));
            this.StepsFlowModulePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleEdit));
            //
            //StepsFlowModuleDelete
            //
            this.bbiStepsFlowModuleDelete.Caption = "Delete";
            this.bbiStepsFlowModuleDelete.Name = "bbiStepsFlowModuleDelete";
            this.bbiStepsFlowModuleDelete.ImageUri.Uri = "Delete";
            this.bbiStepsFlowModuleDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.StepsFlowModuleBarManager.Items.Add(this.bbiStepsFlowModuleDelete);
            this.StepsFlowModuleBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleDelete));
            this.StepsFlowModulePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleDelete));
            //
            //StepsFlowModuleRefresh
            //
            this.bbiStepsFlowModuleRefresh.Caption = "Refresh";
            this.bbiStepsFlowModuleRefresh.Name = "bbiStepsFlowModuleRefresh";
            this.bbiStepsFlowModuleRefresh.ImageUri.Uri = "Refresh";
            this.bbiStepsFlowModuleRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.StepsFlowModuleBarManager.Items.Add(this.bbiStepsFlowModuleRefresh);
            this.StepsFlowModuleBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleRefresh));
            this.StepsFlowModulePopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleRefresh));
            //
            //StepsFlowModuleBar
            //
            this.StepsFlowModuleBar.BarName = "StepsFlowModule";
            this.StepsFlowModuleBar.DockCol = 0;
            this.StepsFlowModuleBar.DockRow = 0;
            this.StepsFlowModuleBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.StepsFlowModuleBar.OptionsBar.AllowQuickCustomization = false;
            this.StepsFlowModuleBar.OptionsBar.DrawDragBorder = false;
            this.StepsFlowModuleBar.Text = "StepsFlowModule";
            //
            //StepsFlowModuleBarManager
            //
            this.StepsFlowModuleBarManager.AllowCustomization = false;
            this.StepsFlowModuleBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { this.StepsFlowModuleBar });
            this.StepsFlowModuleBarManager.Form = StepsFlowModuleXtraUserControl;
            this.StepsFlowModuleBarManager.MainMenu = this.StepsFlowModuleBar;
            // 
            // StepsFlowModulePopUpMenu
            // 
            this.StepsFlowModulePopUpMenu.Manager = this.StepsFlowModuleBarManager;
            this.StepsFlowModulePopUpMenu.Name = "StepsFlowModulePopUpMenu";
            //
            //StepsFlowModuleRetriveFieldParameters
            //
            DevExpress.XtraDataLayout.RetrieveFieldParameters StepsFlowModuleRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            StepsFlowModuleRetriveFieldParameters.FieldName = "StepsFlowModule";
            StepsFlowModuleRetriveFieldParameters.ControlForField = StepsFlowModuleXtraUserControl;
            StepsFlowModuleRetriveFieldParameters.CreateTabGroupForItem = true;
            parameters.CustomListParameters.Add(StepsFlowModuleRetriveFieldParameters);

            //
            //call RetrieveFields
            //
            this.dataLayoutControl1.RetrieveFields(parameters);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.StepsFlowViewModel);
            // 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "StepsFlow - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            //
            //StepsFlowView
            //
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "StepsFlowView";
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBarManager)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource stepsFlowViewBindingSource;
        private DevExpress.XtraGrid.GridControl StepsFlowModuleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView StepsFlowModuleGridView;
        private DevExpress.XtraBars.BarManager StepsFlowModuleBarManager;
        private DevExpress.XtraBars.Bar StepsFlowModuleBar;
        private DevExpress.XtraEditors.XtraUserControl StepsFlowModuleXtraUserControl;
        private DevExpress.XtraBars.PopupMenu StepsFlowModulePopUpMenu;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleNew;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleEdit;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleDelete;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleRefresh;

    }
}
