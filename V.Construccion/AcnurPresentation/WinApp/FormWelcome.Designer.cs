namespace WinApp
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            this.LookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.GrcMenu = new DevExpress.XtraGrid.GridControl();
            this.CrvMenu = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColImageMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RiPictureMenu = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.BtnFinalize = new DevExpress.XtraEditors.SimpleButton();
            this.MemoDataPurchase = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiPictureMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDataPurchase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LookAndFeel
            // 
            this.LookAndFeel.LookAndFeel.SkinName = "Whiteprint";
            // 
            // GrcMenu
            // 
            this.GrcMenu.Location = new System.Drawing.Point(2, 2);
            this.GrcMenu.MainView = this.CrvMenu;
            this.GrcMenu.Name = "GrcMenu";
            this.GrcMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RiPictureMenu});
            this.GrcMenu.Size = new System.Drawing.Size(673, 330);
            this.GrcMenu.TabIndex = 6;
            this.GrcMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CrvMenu});
            // 
            // CrvMenu
            // 
            this.CrvMenu.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.CrvMenu.Appearance.CardCaption.ForeColor = System.Drawing.Color.SlateGray;
            this.CrvMenu.Appearance.CardCaption.Options.UseFont = true;
            this.CrvMenu.Appearance.CardCaption.Options.UseForeColor = true;
            this.CrvMenu.Appearance.CardCaption.Options.UseTextOptions = true;
            this.CrvMenu.Appearance.CardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.CrvMenu.CardCaptionFormat = "{1}";
            this.CrvMenu.CardWidth = 300;
            this.CrvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColName,
            this.ColImageMenu});
            this.CrvMenu.FocusedCardTopFieldIndex = 0;
            this.CrvMenu.GridControl = this.GrcMenu;
            this.CrvMenu.MaximumCardColumns = 3;
            this.CrvMenu.MaximumCardRows = 3;
            this.CrvMenu.Name = "CrvMenu";
            this.CrvMenu.OptionsBehavior.AutoHorzWidth = true;
            this.CrvMenu.OptionsBehavior.FieldAutoHeight = true;
            this.CrvMenu.OptionsView.ShowCardExpandButton = false;
            this.CrvMenu.OptionsView.ShowFieldCaptions = false;
            this.CrvMenu.OptionsView.ShowQuickCustomizeButton = false;
            this.CrvMenu.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // ColName
            // 
            this.ColName.AppearanceCell.Options.UseTextOptions = true;
            this.ColName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ColName.FieldName = "ModuleName";
            this.ColName.Name = "ColName";
            // 
            // ColImageMenu
            // 
            this.ColImageMenu.ColumnEdit = this.RiPictureMenu;
            this.ColImageMenu.CustomizationCaption = "{1}";
            this.ColImageMenu.FieldName = "Picture";
            this.ColImageMenu.Name = "ColImageMenu";
            this.ColImageMenu.OptionsColumn.ShowCaption = false;
            this.ColImageMenu.Visible = true;
            this.ColImageMenu.VisibleIndex = 0;
            // 
            // RiPictureMenu
            // 
            this.RiPictureMenu.AccessibleName = "";
            this.RiPictureMenu.CustomHeight = 110;
            this.RiPictureMenu.Name = "RiPictureMenu";
            this.RiPictureMenu.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RiPictureMenu.Click += new System.EventHandler(this.RiPictureMenu_Click);
            // 
            // BtnFinalize
            // 
            this.BtnFinalize.Appearance.Options.UseTextOptions = true;
            this.BtnFinalize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BtnFinalize.Location = new System.Drawing.Point(578, 346);
            this.BtnFinalize.Name = "BtnFinalize";
            this.BtnFinalize.Size = new System.Drawing.Size(97, 30);
            this.BtnFinalize.TabIndex = 7;
            this.BtnFinalize.Text = "Finalize";
            this.BtnFinalize.Click += new System.EventHandler(this.BtnFinalize_Click);
            // 
            // MemoDataPurchase
            // 
            this.MemoDataPurchase.Location = new System.Drawing.Point(2, 338);
            this.MemoDataPurchase.Name = "MemoDataPurchase";
            this.MemoDataPurchase.Size = new System.Drawing.Size(592, 159);
            this.MemoDataPurchase.TabIndex = 8;
            this.MemoDataPurchase.Visible = false;
            // 
            // FormWelcome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(678, 390);
            this.Controls.Add(this.MemoDataPurchase);
            this.Controls.Add(this.BtnFinalize);
            this.Controls.Add(this.GrcMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWelcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.GrcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiPictureMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDataPurchase.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel LookAndFeel;
        private DevExpress.XtraGrid.GridControl GrcMenu;
        private DevExpress.XtraGrid.Views.Card.CardView CrvMenu;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColImageMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit RiPictureMenu;
        private DevExpress.XtraEditors.SimpleButton BtnFinalize;
        private DevExpress.XtraEditors.MemoEdit MemoDataPurchase;


    }
}
