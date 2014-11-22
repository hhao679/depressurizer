﻿namespace Depressurizer {
    partial class DlgAutoCat {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstAutoCats = new System.Windows.Forms.ListBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdRename = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.ttHelp = new Depressurizer.Lib.ExtToolTip();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAutoCats
            // 
            this.lstAutoCats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAutoCats.FormattingEnabled = true;
            this.lstAutoCats.HorizontalScrollbar = true;
            this.lstAutoCats.IntegralHeight = false;
            this.lstAutoCats.Location = new System.Drawing.Point(6, 19);
            this.lstAutoCats.Name = "lstAutoCats";
            this.lstAutoCats.Size = new System.Drawing.Size(171, 235);
            this.lstAutoCats.TabIndex = 0;
            this.lstAutoCats.SelectedIndexChanged += new System.EventHandler(this.lstAutoCats_SelectedIndexChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelete.Location = new System.Drawing.Point(6, 311);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(171, 23);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdRename
            // 
            this.cmdRename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRename.Location = new System.Drawing.Point(6, 285);
            this.cmdRename.Name = "cmdRename";
            this.cmdRename.Size = new System.Drawing.Size(171, 23);
            this.cmdRename.TabIndex = 2;
            this.cmdRename.Text = "Rename";
            this.cmdRename.UseVisualStyleBackColor = true;
            this.cmdRename.Click += new System.EventHandler(this.cmdRename_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCreate.Location = new System.Drawing.Point(6, 259);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(171, 23);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Create";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.cmdCreate);
            this.grpList.Controls.Add(this.lstAutoCats);
            this.grpList.Controls.Add(this.cmdRename);
            this.grpList.Controls.Add(this.cmdDelete);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Location = new System.Drawing.Point(0, 0);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(184, 341);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "AutoCat List";
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdSave.Location = new System.Drawing.Point(453, 351);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(141, 23);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save All Changes";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(357, 351);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(90, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(4, 4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grpList);
            this.splitContainer.Panel1MinSize = 125;
            this.splitContainer.Panel2MinSize = 400;
            this.splitContainer.Size = new System.Drawing.Size(590, 341);
            this.splitContainer.SplitterDistance = 184;
            this.splitContainer.TabIndex = 7;
            // 
            // ttHelp
            // 
            this.ttHelp.UseFading = false;
            // 
            // DlgAutoCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(599, 384);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.MinimumSize = new System.Drawing.Size(615, 400);
            this.Name = "DlgAutoCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit AutoCats";
            this.Load += new System.EventHandler(this.DlgAutoCat_Load);
            this.grpList.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAutoCats;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdRename;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Lib.ExtToolTip ttHelp;
    }
}