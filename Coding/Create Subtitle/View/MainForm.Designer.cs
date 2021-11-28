
namespace Create_Subtitle.Form
{
    partial class MainForm
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
        /// Required method for Designer support - do Segmentt modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtText = new DevExpress.XtraEditors.TextEdit();
            this.txtEndTime = new DevExpress.XtraEditors.TextEdit();
            this.txtStartTime = new DevExpress.XtraEditors.TextEdit();
            this.lblContent = new DevExpress.XtraEditors.LabelControl();
            this.lblTimeEnd = new DevExpress.XtraEditors.LabelControl();
            this.lblTimeStart = new DevExpress.XtraEditors.LabelControl();
            this.txtSegment = new DevExpress.XtraEditors.TextEdit();
            this.lblSegment = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.dgcMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSegment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tablePanel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl1.Size = new System.Drawing.Size(798, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.92F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 79.6F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel2.Controls.Add(this.lblPath);
            this.tablePanel2.Controls.Add(this.btnBrowse);
            this.tablePanel2.Controls.Add(this.txtPath);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(6, 6);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(786, 39);
            this.tablePanel2.TabIndex = 0;
            // 
            // lblPath
            // 
            this.tablePanel2.SetColumn(this.lblPath, 0);
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPath.Location = new System.Drawing.Point(3, 12);
            this.lblPath.Margin = new System.Windows.Forms.Padding(3);
            this.lblPath.Name = "lblPath";
            this.tablePanel2.SetRow(this.lblPath, 0);
            this.lblPath.Size = new System.Drawing.Size(72, 16);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "File path:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnBrowse, 2);
            this.btnBrowse.Location = new System.Drawing.Point(647, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.tablePanel2.SetRow(this.btnBrowse, 0);
            this.btnBrowse.Size = new System.Drawing.Size(136, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.tablePanel2.SetColumn(this.txtPath, 1);
            this.txtPath.Location = new System.Drawing.Point(81, 9);
            this.txtPath.Name = "txtPath";
            this.txtPath.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPath.Properties.Appearance.Options.UseFont = true;
            this.txtPath.Properties.ReadOnly = true;
            this.tablePanel2.SetRow(this.txtPath, 0);
            this.txtPath.Size = new System.Drawing.Size(560, 22);
            this.txtPath.TabIndex = 3;
            // 
            // flyoutPanelControl2
            // 
            this.flyoutPanelControl2.Controls.Add(this.groupControl2);
            this.flyoutPanelControl2.Controls.Add(this.groupControl1);
            this.flyoutPanelControl2.Controls.Add(this.separatorControl1);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flyoutPanelControl2.FlyoutPanel = null;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(468, 51);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(330, 517);
            this.flyoutPanelControl2.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnCreate);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 170);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 149);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Action";
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.Location = new System.Drawing.Point(2, 23);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(322, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Sub";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.tablePanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(326, 168);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Information";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 22.67F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37.33F)});
            this.tablePanel1.Controls.Add(this.txtText);
            this.tablePanel1.Controls.Add(this.txtEndTime);
            this.tablePanel1.Controls.Add(this.txtStartTime);
            this.tablePanel1.Controls.Add(this.lblContent);
            this.tablePanel1.Controls.Add(this.lblTimeEnd);
            this.tablePanel1.Controls.Add(this.lblTimeStart);
            this.tablePanel1.Controls.Add(this.txtSegment);
            this.tablePanel1.Controls.Add(this.lblSegment);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(2, 23);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F)});
            this.tablePanel1.Size = new System.Drawing.Size(322, 143);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtText
            // 
            this.tablePanel1.SetColumn(this.txtText, 1);
            this.txtText.Location = new System.Drawing.Point(125, 114);
            this.txtText.Name = "txtText";
            this.tablePanel1.SetRow(this.txtText, 3);
            this.txtText.Size = new System.Drawing.Size(194, 20);
            this.txtText.TabIndex = 7;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEndTime.Location = new System.Drawing.Point(125, 75);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEndTime.Properties.Appearance.Options.UseFont = true;
            this.txtEndTime.Size = new System.Drawing.Size(194, 22);
            this.txtEndTime.TabIndex = 6;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(125, 40);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtStartTime.Properties.Appearance.Options.UseFont = true;
            this.txtStartTime.Size = new System.Drawing.Size(194, 22);
            this.txtStartTime.TabIndex = 5;
            // 
            // lblContent
            // 
            this.lblContent.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContent.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lblContent, 0);
            this.lblContent.Location = new System.Drawing.Point(3, 115);
            this.lblContent.Name = "lblContent";
            this.tablePanel1.SetRow(this.lblContent, 3);
            this.lblContent.Size = new System.Drawing.Size(43, 15);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Content";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTimeEnd.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lblTimeEnd, 0);
            this.lblTimeEnd.Location = new System.Drawing.Point(3, 80);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.tablePanel1.SetRow(this.lblTimeEnd, 2);
            this.lblTimeEnd.Size = new System.Drawing.Size(53, 15);
            this.lblTimeEnd.TabIndex = 3;
            this.lblTimeEnd.Text = "Time End";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTimeStart.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lblTimeStart, 0);
            this.lblTimeStart.Location = new System.Drawing.Point(3, 45);
            this.lblTimeStart.Name = "lblTimeStart";
            this.tablePanel1.SetRow(this.lblTimeStart, 1);
            this.lblTimeStart.Size = new System.Drawing.Size(57, 15);
            this.lblTimeStart.TabIndex = 2;
            this.lblTimeStart.Text = "Time Start";
            // 
            // txtSegment
            // 
            this.txtSegment.Location = new System.Drawing.Point(125, 5);
            this.txtSegment.Name = "txtSegment";
            this.txtSegment.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSegment.Properties.Appearance.Options.UseFont = true;
            this.txtSegment.Size = new System.Drawing.Size(194, 22);
            this.txtSegment.TabIndex = 1;
            // 
            // lblSegment
            // 
            this.lblSegment.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSegment.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lblSegment, 0);
            this.lblSegment.Location = new System.Drawing.Point(3, 10);
            this.lblSegment.Name = "lblSegment";
            this.tablePanel1.SetRow(this.lblSegment, 0);
            this.lblSegment.Size = new System.Drawing.Size(51, 15);
            this.lblSegment.TabIndex = 0;
            this.lblSegment.Text = "Segment";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(165, 117);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(8, 8);
            this.separatorControl1.TabIndex = 0;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.dgcMain);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = null;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 51);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(468, 517);
            this.flyoutPanelControl1.TabIndex = 3;
            // 
            // dgcMain
            // 
            this.dgcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgcMain.Location = new System.Drawing.Point(2, 2);
            this.dgcMain.MainView = this.dgvMain;
            this.dgcMain.Name = "dgcMain";
            this.dgcMain.Size = new System.Drawing.Size(464, 513);
            this.dgcMain.TabIndex = 0;
            this.dgcMain.UseEmbeddedNavigator = true;
            this.dgcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMain});
            // 
            // dgvMain
            // 
            this.dgvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSegment,
            this.colStartTime,
            this.colEndTime,
            this.colText});
            this.dgvMain.GridControl = this.dgcMain;
            this.dgvMain.Name = "dgvMain";
            // 
            // colSegment
            // 
            this.colSegment.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.colSegment.AppearanceCell.Options.UseFont = true;
            this.colSegment.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.colSegment.AppearanceHeader.Options.UseFont = true;
            this.colSegment.Caption = "Segment";
            this.colSegment.FieldName = "Segment";
            this.colSegment.MinWidth = 10;
            this.colSegment.Name = "colSegment";
            this.colSegment.OptionsColumn.AllowEdit = false;
            this.colSegment.OptionsColumn.FixedWidth = true;
            this.colSegment.OptionsColumn.ReadOnly = true;
            this.colSegment.Visible = true;
            this.colSegment.VisibleIndex = 0;
            this.colSegment.Width = 60;
            // 
            // colStartTime
            // 
            this.colStartTime.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.colStartTime.AppearanceCell.Options.UseFont = true;
            this.colStartTime.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.colStartTime.AppearanceHeader.Options.UseFont = true;
            this.colStartTime.Caption = "Start Time";
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.OptionsColumn.AllowEdit = false;
            this.colStartTime.OptionsColumn.FixedWidth = true;
            this.colStartTime.OptionsColumn.ReadOnly = true;
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 1;
            this.colStartTime.Width = 80;
            // 
            // colEndTime
            // 
            this.colEndTime.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.colEndTime.AppearanceCell.Options.UseFont = true;
            this.colEndTime.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.colEndTime.AppearanceHeader.Options.UseFont = true;
            this.colEndTime.Caption = "End Time";
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.OptionsColumn.AllowEdit = false;
            this.colEndTime.OptionsColumn.FixedWidth = true;
            this.colEndTime.OptionsColumn.ReadOnly = true;
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 2;
            this.colEndTime.Width = 80;
            // 
            // colText
            // 
            this.colText.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F);
            this.colText.AppearanceCell.Options.UseFont = true;
            this.colText.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F);
            this.colText.AppearanceHeader.Options.UseFont = true;
            this.colText.Caption = "Text";
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.OptionsColumn.AllowEdit = false;
            this.colText.OptionsColumn.ReadOnly = true;
            this.colText.Visible = true;
            this.colText.VisibleIndex = 3;
            this.colText.Width = 219;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.flyoutPanelControl1);
            this.Controls.Add(this.flyoutPanelControl2);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Subtitle to Mp3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private System.Windows.Forms.Label lblPath;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit txtSegment;
        private DevExpress.XtraEditors.LabelControl lblSegment;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.TextEdit txtEndTime;
        private DevExpress.XtraEditors.TextEdit txtStartTime;
        private DevExpress.XtraEditors.LabelControl lblContent;
        private DevExpress.XtraEditors.LabelControl lblTimeEnd;
        private DevExpress.XtraEditors.LabelControl lblTimeStart;
        private DevExpress.XtraGrid.GridControl dgcMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMain;
        private DevExpress.XtraGrid.Columns.GridColumn colSegment;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraEditors.TextEdit txtText;
    }
}