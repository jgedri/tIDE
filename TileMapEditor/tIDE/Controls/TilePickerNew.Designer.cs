﻿namespace TileMapEditor.Controls
{
    partial class TilePickerNew
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
            System.Windows.Forms.Label m_labelCaption;
            this.m_comboBoxTileSheets = new System.Windows.Forms.ComboBox();
            this.m_tilePanel = new TileMapEditor.Controls.CustomPanel();
            this.m_horizontalScrollBar = new System.Windows.Forms.HScrollBar();
            this.m_verticalScrollBar = new System.Windows.Forms.VScrollBar();
            this.m_toolStrip = new System.Windows.Forms.ToolStrip();
            this.m_indexOrderButton = new System.Windows.Forms.ToolStripButton();
            this.m_mruOrderButton = new System.Windows.Forms.ToolStripButton();
            this.m_imageOrderButton = new System.Windows.Forms.ToolStripButton();
            m_labelCaption = new System.Windows.Forms.Label();
            this.m_tilePanel.SuspendLayout();
            this.m_toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_labelCaption
            // 
            m_labelCaption.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            m_labelCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            m_labelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            m_labelCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            m_labelCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            m_labelCaption.Location = new System.Drawing.Point(0, 0);
            m_labelCaption.Name = "m_labelCaption";
            m_labelCaption.Padding = new System.Windows.Forms.Padding(2);
            m_labelCaption.Size = new System.Drawing.Size(150, 20);
            m_labelCaption.TabIndex = 1;
            m_labelCaption.Text = "Tile Picker";
            m_labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_comboBoxTileSheets
            // 
            this.m_comboBoxTileSheets.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_comboBoxTileSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxTileSheets.FormattingEnabled = true;
            this.m_comboBoxTileSheets.Location = new System.Drawing.Point(0, 20);
            this.m_comboBoxTileSheets.Name = "m_comboBoxTileSheets";
            this.m_comboBoxTileSheets.Size = new System.Drawing.Size(150, 21);
            this.m_comboBoxTileSheets.TabIndex = 2;
            this.m_comboBoxTileSheets.SelectedIndexChanged += new System.EventHandler(this.OnSelectTileSheet);
            // 
            // m_tilePanel
            // 
            this.m_tilePanel.AutoScroll = true;
            this.m_tilePanel.BackgroundImage = global::TileMapEditor.Properties.Resources.ImageBackground;
            this.m_tilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_tilePanel.Controls.Add(this.m_horizontalScrollBar);
            this.m_tilePanel.Controls.Add(this.m_verticalScrollBar);
            this.m_tilePanel.Controls.Add(this.m_toolStrip);
            this.m_tilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tilePanel.Location = new System.Drawing.Point(0, 41);
            this.m_tilePanel.Margin = new System.Windows.Forms.Padding(0);
            this.m_tilePanel.Name = "m_tilePanel";
            this.m_tilePanel.Size = new System.Drawing.Size(150, 109);
            this.m_tilePanel.TabIndex = 3;
            this.m_tilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTilePanelPaint);
            this.m_tilePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnTilePanelMouseMove);
            this.m_tilePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTilePanelMouseDown);
            this.m_tilePanel.Resize += new System.EventHandler(this.OnTilePanelResize);
            this.m_tilePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnTilePanelMouseUp);
            this.m_tilePanel.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.OnDragGiveFeedback);
            // 
            // m_horizontalScrollBar
            // 
            this.m_horizontalScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_horizontalScrollBar.Location = new System.Drawing.Point(0, 65);
            this.m_horizontalScrollBar.Name = "m_horizontalScrollBar";
            this.m_horizontalScrollBar.Size = new System.Drawing.Size(131, 17);
            this.m_horizontalScrollBar.TabIndex = 2;
            this.m_horizontalScrollBar.Visible = false;
            this.m_horizontalScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OnHorizontalScroll);
            // 
            // m_verticalScrollBar
            // 
            this.m_verticalScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_verticalScrollBar.Location = new System.Drawing.Point(131, 0);
            this.m_verticalScrollBar.Name = "m_verticalScrollBar";
            this.m_verticalScrollBar.Size = new System.Drawing.Size(17, 82);
            this.m_verticalScrollBar.TabIndex = 1;
            this.m_verticalScrollBar.Visible = false;
            this.m_verticalScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.OnVerticalScroll);
            // 
            // m_toolStrip
            // 
            this.m_toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_indexOrderButton,
            this.m_mruOrderButton,
            this.m_imageOrderButton});
            this.m_toolStrip.Location = new System.Drawing.Point(0, 82);
            this.m_toolStrip.Name = "m_toolStrip";
            this.m_toolStrip.Size = new System.Drawing.Size(148, 25);
            this.m_toolStrip.TabIndex = 0;
            this.m_toolStrip.Text = "toolStrip1";
            // 
            // m_indexOrderButton
            // 
            this.m_indexOrderButton.Checked = true;
            this.m_indexOrderButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_indexOrderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_indexOrderButton.Image = global::TileMapEditor.Properties.Resources.TileOrderIndexed;
            this.m_indexOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_indexOrderButton.Name = "m_indexOrderButton";
            this.m_indexOrderButton.Size = new System.Drawing.Size(23, 22);
            this.m_indexOrderButton.Text = "Index Order";
            this.m_indexOrderButton.ToolTipText = "View tiles in index order";
            this.m_indexOrderButton.Click += new System.EventHandler(this.OnOrderIndexed);
            // 
            // m_mruOrderButton
            // 
            this.m_mruOrderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_mruOrderButton.Image = global::TileMapEditor.Properties.Resources.TileOrderMru;
            this.m_mruOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_mruOrderButton.Name = "m_mruOrderButton";
            this.m_mruOrderButton.Size = new System.Drawing.Size(23, 22);
            this.m_mruOrderButton.Text = "MRU Order";
            this.m_mruOrderButton.ToolTipText = "View tiles in order of the most recently used";
            this.m_mruOrderButton.Click += new System.EventHandler(this.OnOrderMru);
            // 
            // m_imageOrderButton
            // 
            this.m_imageOrderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_imageOrderButton.Image = global::TileMapEditor.Properties.Resources.TileOrderImage;
            this.m_imageOrderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_imageOrderButton.Name = "m_imageOrderButton";
            this.m_imageOrderButton.Size = new System.Drawing.Size(23, 22);
            this.m_imageOrderButton.Text = "Image Order";
            this.m_imageOrderButton.ToolTipText = "View tiles in order of their source image configuration";
            this.m_imageOrderButton.Click += new System.EventHandler(this.OnOrderImage);
            // 
            // TilePickerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_tilePanel);
            this.Controls.Add(this.m_comboBoxTileSheets);
            this.Controls.Add(m_labelCaption);
            this.Name = "TilePickerNew";
            this.m_tilePanel.ResumeLayout(false);
            this.m_tilePanel.PerformLayout();
            this.m_toolStrip.ResumeLayout(false);
            this.m_toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox m_comboBoxTileSheets;
        private CustomPanel m_tilePanel;
        private System.Windows.Forms.ToolStrip m_toolStrip;
        private System.Windows.Forms.ToolStripButton m_indexOrderButton;
        private System.Windows.Forms.ToolStripButton m_mruOrderButton;
        private System.Windows.Forms.ToolStripButton m_imageOrderButton;
        private System.Windows.Forms.VScrollBar m_verticalScrollBar;
        private System.Windows.Forms.HScrollBar m_horizontalScrollBar;
    }
}