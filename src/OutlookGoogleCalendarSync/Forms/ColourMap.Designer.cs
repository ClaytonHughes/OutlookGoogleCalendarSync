﻿namespace OutlookGoogleCalendarSync.Forms {
    partial class ColourMap {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourMap));
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.colourGridView = new System.Windows.Forms.DataGridView();
            this.OutlookColour = new OutlookGoogleCalendarSync.Extensions.DataGridViewOutlookColourComboBoxColumn();
            this.GoogleColour = new OutlookGoogleCalendarSync.Extensions.DataGridViewGoogleColourComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.colourGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(405, 293);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "OK";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(324, 293);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(12, 12);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(468, 110);
            this.txtInfo.TabIndex = 9;
            this.txtInfo.TabStop = false;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // colourGridView
            // 
            this.colourGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colourGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutlookColour,
            this.GoogleColour});
            this.colourGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.colourGridView.Location = new System.Drawing.Point(12, 128);
            this.colourGridView.Name = "colourGridView";
            this.colourGridView.Size = new System.Drawing.Size(468, 159);
            this.colourGridView.TabIndex = 0;
            this.colourGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.colourGridView_CellClick);
            this.colourGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.colourGridView_CellEndEdit);
            this.colourGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.colourGridView_CellEnter);
            this.colourGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.colourGridView_CellFormatting);
            this.colourGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.colourGridView_CellPainting);
            this.colourGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.colourGridView_CellValueChanged);
            this.colourGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.colourGridView_CurrentCellDirtyStateChanged);
            this.colourGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.colourGridView_DataError);
            this.colourGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.colourGridView_EditingControlShowing);
            // 
            // OutlookColour
            // 
            this.OutlookColour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutlookColour.DividerWidth = 2;
            this.OutlookColour.FillWeight = 50F;
            this.OutlookColour.HeaderText = "Outlook Category";
            this.OutlookColour.Name = "OutlookColour";
            this.OutlookColour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OutlookColour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GoogleColour
            // 
            this.GoogleColour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GoogleColour.FillWeight = 50F;
            this.GoogleColour.HeaderText = "Google Colour";
            this.GoogleColour.Name = "GoogleColour";
            this.GoogleColour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GoogleColour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColourMap
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(492, 324);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.colourGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(508, 362);
            this.Name = "ColourMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Colour Mapping";
            ((System.ComponentModel.ISupportInitialize)(this.colourGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView colourGridView;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtInfo;
        private Extensions.DataGridViewOutlookColourComboBoxColumn OutlookColour;
        private Extensions.DataGridViewGoogleColourComboBoxColumn GoogleColour;
    }
}