namespace PaletteUpgradeTool.UI
{
    partial class PaletteUpgradeTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteUpgradeTool));
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUpgrade = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krtbOutput = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.krtbInput = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tmrDetectModification = new System.Windows.Forms.Timer(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelKryptonPaletteUpgradeTool = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.klblStatus);
            this.kpnlBackground.Controls.Add(this.kbtnClose);
            this.kpnlBackground.Controls.Add(this.kbtnExport);
            this.kpnlBackground.Controls.Add(this.kbtnUpgrade);
            this.kpnlBackground.Controls.Add(this.krtbOutput);
            this.kpnlBackground.Controls.Add(this.kryptonLabel3);
            this.kpnlBackground.Controls.Add(this.kbtnBrowse);
            this.kpnlBackground.Controls.Add(this.krtbInput);
            this.kpnlBackground.Controls.Add(this.kryptonLabel2);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(800, 434);
            this.kpnlBackground.TabIndex = 0;
            // 
            // klblStatus
            // 
            this.klblStatus.Location = new System.Drawing.Point(12, 391);
            this.klblStatus.Name = "klblStatus";
            this.klblStatus.Size = new System.Drawing.Size(330, 30);
            this.klblStatus.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.klblStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblStatus.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblStatus.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblStatus.TabIndex = 11;
            this.klblStatus.Values.Text = "You must specify a valid input file.";
            // 
            // kbtnClose
            // 
            this.kbtnClose.Location = new System.Drawing.Point(698, 396);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 25);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnClose.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnClose.TabIndex = 10;
            this.kbtnClose.Values.Text = "C&lose";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // kbtnExport
            // 
            this.kbtnExport.Enabled = false;
            this.kbtnExport.Location = new System.Drawing.Point(698, 337);
            this.kbtnExport.Name = "kbtnExport";
            this.kbtnExport.Size = new System.Drawing.Size(90, 25);
            this.kbtnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExport.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnExport.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnExport.TabIndex = 8;
            this.kbtnExport.Values.Text = "E&xport";
            this.kbtnExport.Click += new System.EventHandler(this.kbtnExport_Click);
            // 
            // kbtnUpgrade
            // 
            this.kbtnUpgrade.Enabled = false;
            this.kbtnUpgrade.Location = new System.Drawing.Point(698, 290);
            this.kbtnUpgrade.Name = "kbtnUpgrade";
            this.kbtnUpgrade.Size = new System.Drawing.Size(90, 25);
            this.kbtnUpgrade.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUpgrade.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnUpgrade.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnUpgrade.TabIndex = 7;
            this.kbtnUpgrade.Values.Text = "&Upgrade";
            this.kbtnUpgrade.Click += new System.EventHandler(this.kbtnUpgrade_Click);
            // 
            // krtbOutput
            // 
            this.krtbOutput.Location = new System.Drawing.Point(12, 281);
            this.krtbOutput.Name = "krtbOutput";
            this.krtbOutput.Size = new System.Drawing.Size(679, 96);
            this.krtbOutput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbOutput.TabIndex = 6;
            this.krtbOutput.Text = "";
            this.krtbOutput.TextChanged += new System.EventHandler(this.krtbOutput_TextChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 249);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(158, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel3.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Output Palette File";
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Location = new System.Drawing.Point(698, 183);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(90, 25);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnBrowse.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnBrowse.TabIndex = 4;
            this.kbtnBrowse.Values.Text = "&Browse";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // krtbInput
            // 
            this.krtbInput.Location = new System.Drawing.Point(12, 147);
            this.krtbInput.Name = "krtbInput";
            this.krtbInput.ReadOnly = true;
            this.krtbInput.Size = new System.Drawing.Size(679, 96);
            this.krtbInput.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtbInput.TabIndex = 3;
            this.krtbInput.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 115);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(144, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Input Palette File";
            // 
            // tmrDetectModification
            // 
            this.tmrDetectModification.Enabled = true;
            this.tmrDetectModification.Interval = 250;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.labelKryptonPaletteUpgradeTool);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 100);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // labelKryptonPaletteUpgradeTool
            // 
            this.labelKryptonPaletteUpgradeTool.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.labelKryptonPaletteUpgradeTool.Location = new System.Drawing.Point(12, 53);
            this.labelKryptonPaletteUpgradeTool.Name = "labelKryptonPaletteUpgradeTool";
            this.labelKryptonPaletteUpgradeTool.Size = new System.Drawing.Size(244, 28);
            this.labelKryptonPaletteUpgradeTool.StateCommon.ShortText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKryptonPaletteUpgradeTool.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.labelKryptonPaletteUpgradeTool.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelKryptonPaletteUpgradeTool.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelKryptonPaletteUpgradeTool.TabIndex = 1;
            this.labelKryptonPaletteUpgradeTool.Values.Text = "Palette Upgrade Tool";
            // 
            // PaletteUpgradeTool
            // 
            this.AcceptButton = this.kbtnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaletteUpgradeTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palette Upgrade Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaletteUpgradeTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnExport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnUpgrade;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbOutput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox krtbInput;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnClose;
        private System.Windows.Forms.Timer tmrDetectModification;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelKryptonPaletteUpgradeTool;
    }
}