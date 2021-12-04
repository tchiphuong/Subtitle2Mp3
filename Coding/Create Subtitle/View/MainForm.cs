using Create_Subtitle.DTO;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Subtitle.Form
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        Boolean tokenModify = false;
        Boolean play = false;
        SubtitleDto dto = new SubtitleDto();
        public MainForm()
        {
            InitializeComponent();


            this.dgvMain.RowClick += DgvMain_RowClick;

            ControlNavigator navigator = dgcMain.EmbeddedNavigator;
            navigator.Buttons.BeginUpdate();
            try
            {
                navigator.Buttons.Append.Visible = false;
                navigator.Buttons.Remove.Visible = false;
                navigator.Buttons.EndEdit.Visible = false;
                navigator.Buttons.CancelEdit.Visible = false;
            }
            finally
            {
                navigator.Buttons.EndUpdate();
            }
            LoadToken();
            LoadCombobox();
        }

        private void DgvMain_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.txtSegment.Text = (sender as GridView).GetFocusedRowCellValue("Segment").ToString();
            this.txtStartTime.Text = (sender as GridView).GetFocusedRowCellValue("StartTime").ToString();
            this.txtEndTime.Text = (sender as GridView).GetFocusedRowCellValue("EndTime").ToString();
            this.txtText.Text = (sender as GridView).GetFocusedRowCellValue("Text").ToString();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            this.openFileDialog1.Filter = "Subtitle File (*.srt)|*.srt|" + "All files (*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Subtitle File";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName.Replace(@"\\", @"\");
            this.txtPath.Text = path;
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ParseSRT(path);
            }
        }
        private void ParseSRT(string srtFilePath)
        {
            var fileContent = File.ReadAllLines(srtFilePath);
            if (fileContent.Length <= 0)
                return;

            List<SubtitleDto> content = new List<SubtitleDto>();
            var segment = 1;
            for (int item = 0; item < fileContent.Length; item++)
            {
                if (segment.ToString() == fileContent[item])
                {
                    content.Add(new SubtitleDto
                    {
                        Segment = segment.ToString(),
                        StartTime = fileContent[item + 1].Substring(0, fileContent[item + 1].LastIndexOf("-->")).Trim(),
                        EndTime = fileContent[item + 1].Substring(fileContent[item + 1].LastIndexOf("-->") + 3).Trim(),
                        Text = fileContent[item + 2].Replace("<i>","").Replace("</i>","").Replace(".","").Replace("?","").Replace("!", "").Replace("- ", "").Replace("\"", "")

                    });
                    // The block numbers of SRT like 1, 2, 3, ... and so on
                    segment++;
                    // Iterate one block at a time
                    item += 3;
                }
            }
            BindData(content);
        }

        private void BindData(List<SubtitleDto> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Segment", typeof(int));
            dt.Columns.Add("StartTime", typeof(string));
            dt.Columns.Add("EndTime", typeof(string));
            dt.Columns.Add("Text", typeof(string));

            foreach (var item in list)
            {
                dt.Rows.Add(
                    item.Segment,
                    item.StartTime,
                    item.EndTime,
                    item.Text
                    );
            }
            this.dgcMain.DataSource = dt;
        }

        private void LoadToken()
        {
            this.txtToken.ReadOnly = true;
            string token = "kkSwFaK15Za0cRbny9r2Dmquc9XlaE10";
            this.txtToken.Text = token;
        }

        private void LoadCombobox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Rows.Add("banmai", "Ban Mai");
            dt.Rows.Add("banmaiace", "Ban Mai (Ace)");
            dt.Rows.Add("thuminh", "Thu Minh");
            dt.Rows.Add("thuminhace", "Thu Minh (Ace)");
            cboVoice.Properties.DataSource = dt;
            cboVoice.Properties.DisplayMember = "Value";
            cboVoice.Properties.ValueMember = "Code";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            dto.Voice = cboVoice.EditValue.ToString();
            dto.Token = this.txtToken.Text;
        }

        private void cboVoice_EditValueChanged(object sender, EventArgs e)
        {
            cboVoice.Properties.DisplayMember = "Value";
            cboVoice.Properties.ValueMember = "Code";
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            if (tokenModify == false)
            {
                this.txtToken.ReadOnly = false;
                tokenModify = true;
                this.btnToken.ImageOptions.Image = global::Create_Subtitle.Properties.Resources.save_16;
            }
            else
            {
                this.txtToken.ReadOnly = true;
                tokenModify = false;
                this.btnToken.ImageOptions.Image = global::Create_Subtitle.Properties.Resources.edit_16;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (play == false)
            {
                play = true;
                this.btnPlay.Text = "Pause";
                this.btnPlay.ImageOptions.Image = global::Create_Subtitle.Properties.Resources.pause_32;
                this.btnPlay.Appearance.BackColor = System.Drawing.Color.MistyRose;
            }
            else
            {
                play = false;
                this.btnPlay.Text = "Play";
                this.btnPlay.ImageOptions.Image = global::Create_Subtitle.Properties.Resources.play_32;
                this.btnPlay.Appearance.BackColor = System.Drawing.Color.White;
            }
        }
    }
}