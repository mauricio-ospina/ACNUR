﻿// ***********************************************************************
// Assembly         : WinApp
// Author           : Christian ospina
// Created          : 03-18-2016
//
// Last Modified By : Christian ospina
// Last Modified On : 03-21-2016
// ***********************************************************************
// <copyright file="ControlFileUpLoad.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace WinApp
{
    using DevExpress.XtraEditors.Controls;
    using System;
    using System.Data;

    /// <summary>
    /// Class ControlFileUpLoad.
    /// </summary>
    /// <seealso cref="DevExpress.XtraEditors.XtraUserControl" />
    public partial class ControlFileUpLoad : DevExpress.XtraEditors.XtraUserControl
    {
        public bool Flat { get; set; }

        /// <summary>
        /// The table
        /// </summary>
        DataTable tbl;

        /// <summary>
        /// The helper
        /// </summary>
        UploadHelper helper;

        /// <summary>
        /// Gets the current file.
        /// </summary>
        /// <value>The current file.</value>
        public UploadedFile CurrentFile
        {
            get { return helper == null ? null : helper.CurrentFile; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlFileUpLoad"/> class.
        /// </summary>
        public ControlFileUpLoad()
        {
            InitializeComponent();
            DataTable table = CreateTable();
            GrcFiles.DataSource = table;
            helper = new UploadHelper(table);
            helper.CurrentFileChanged += helper_CurrentFileChanged;
            RIButtonFiles.ButtonClick += RIButtonFiles_ButtonClick;
        }

        /// <summary>
        /// Handles the CurrentFileChanged event of the helper control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void helper_CurrentFileChanged(object sender, EventArgs e)
        {
            UpdateHyperLink();
        }

        /// <summary>
        /// Creates the table.
        /// </summary>
        /// <returns>DataTable.</returns>
        public DataTable CreateTable()
        {
            tbl = new DataTable();
            tbl.Columns.Add("FileName", typeof(string));
            tbl.Columns.Add("FileSize", typeof(int));
            tbl.Columns.Add("FileContent", typeof(object));
            return tbl;
        }

        /// <summary>
        /// Updates the hyper link.
        /// </summary>
        void UpdateHyperLink()
        {
            if (helper.CurrentFile == null)
            {
                HplFileTemp.Enabled = false;
                HplFileTemp.Text = "No file chosen";
            }
            else
            {
                HplFileTemp.Enabled = true;
                HplFileTemp.Text = String.Format("{0} ({1})", CurrentFile.FullPath, CurrentFile.FileSize);
            }
        }

        /// <summary>
        /// Gets the focused file.
        /// </summary>
        /// <returns>UploadedFile.</returns>
        UploadedFile GetFocusedFile()
        {
            DataRow dataRow = GrvFiles.GetFocusedDataRow();

            if (dataRow == null)
            {
                return null;
            }

            return new UploadedFile((byte[])dataRow["FileContent"], (string)dataRow["FileName"]);
        }

        /// <summary>
        /// Handles the ButtonClick event of the RIButtonFiles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ButtonPressedEventArgs"/> instance containing the event data.</param>
        void RIButtonFiles_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!Flat)
            {
                switch (e.Button.Index)
                {
                    case 0:
                        Flat = true;
                        UploadedFile file = GetFocusedFile();
                        if (file != null)
                            file.OpenFile();

                        break;
                    case 1:
                        helper.PostNewFile(GrvFiles.GetFocusedDataSourceRowIndex());
                        GrvFiles.UpdateCurrentRow();
                        break;
                    case 2:
                        Flat = true;
                        DataRow dataRow = GrvFiles.GetFocusedDataRow();
                        if (null != dataRow)
                        {
                            helper.DataSource.Rows.Remove(dataRow);
                            GrvFiles.UpdateCurrentRow();
                        }
                        break;
                }
            }
            else
                Flat = false;
        }

        /// <summary>
        /// Handles the Click event of the btOpenFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btOpenFile_Click(object sender, EventArgs e)
        {
            helper.ChooseFile();
        }

        /// <summary>
        /// Handles the Click event of the btUploadFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btUploadFile_Click(object sender, EventArgs e)
        {
            helper.UploadFile();
        }
    }
}
