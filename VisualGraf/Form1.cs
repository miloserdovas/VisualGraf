using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML;
using ClosedXML.Excel;
using DevExpress.XtraCharts;

namespace VisualGraf
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string filename = "";

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = xtraOpenFileDialog1.FileName;
                textEdit1.Text = "";
                textEdit1.Text = xtraOpenFileDialog1.SafeFileName;
            }
            labelControl2.Visible = true;
            btnGoGraf.Visible = true;
        }

        private void btnGoGraf_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();

            XLWorkbook workbook;
            using (workbook = new XLWorkbook(filename))
            {                
                var ws = workbook.Worksheets.First();
                var range1 = ws.Range("B1:B500");
                for (int i = 2; i < 500; i++)
                {                   
                    chartControl1.Series[0].Points.Add(new SeriesPoint(i, range1.Cell(i, 1).Value));
                }

                var range2 = ws.Range("C1:C500");
                for (int i = 2; i < 500; i++)
                {
                    chartControl1.Series[1].Points.Add(new SeriesPoint(i, range2.Cell(i, 1).Value));
                }

                var range3 = ws.Range("D1:D500");
                for (int i = 2; i < 500; i++)
                {
                    chartControl1.Series[2].Points.Add(new SeriesPoint(i, range3.Cell(i, 1).Value));
                }
                var range4 = ws.Range("E1:E500");
                for (int i = 2; i < 500; i++)
                {
                    chartControl1.Series[3].Points.Add(new SeriesPoint(i, range4.Cell(i, 1).Value));
                }
                var range5 = ws.Range("F1:G500");
                for (int i = 2; i < 500; i++)
                {
                    chartControl1.Series[4].Points.Add(new SeriesPoint(i, range5.Cell(i, 1).Value));
                }
                var range6 = ws.Range("G1:G500");
                for (int i = 2; i < 500; i++)
                {
                    chartControl1.Series[5].Points.Add(new SeriesPoint(i, range6.Cell(i, 1).Value));
                }
                var range7 = ws.Range("H1:H500");
                for (int i = 2; i < 500; i++)
                {
                    chartControl1.Series[6].Points.Add(new SeriesPoint(i, range7.Cell(i, 1).Value));
                }
            }

            splashScreenManager1.CloseWaitForm();

            chartControl1.Visible = true;
        }
    }
}
