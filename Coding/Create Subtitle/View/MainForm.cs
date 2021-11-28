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

            List<SrtContent> content = new List<SrtContent>();
            var segment = 1;
            for (int item = 0; item < fileContent.Length; item++)
            {
                if (segment.ToString() == fileContent[item])
                {
                    content.Add(new SrtContent
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

        private void BindData(List<SrtContent> list)
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

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}