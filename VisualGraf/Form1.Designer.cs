namespace VisualGraf
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series15 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView15 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series16 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView16 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series17 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView17 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series18 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView18 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series19 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView19 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series20 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView20 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series21 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView21 = new DevExpress.XtraCharts.LineSeriesView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGoGraf = new DevExpress.XtraEditors.SimpleButton();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::VisualGraf.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView21)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Выбирете файл:";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.labelControl1);
            this.stackPanel1.Controls.Add(this.btnBrowse);
            this.stackPanel1.Controls.Add(this.textEdit1);
            this.stackPanel1.Controls.Add(this.separatorControl1);
            this.stackPanel1.Controls.Add(this.labelControl2);
            this.stackPanel1.Controls.Add(this.btnGoGraf);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(965, 31);
            this.stackPanel1.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(106, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 22);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Обзор...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(175, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(162, 22);
            this.textEdit1.TabIndex = 4;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(343, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(75, 23);
            this.separatorControl1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(424, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Построить график:";
            this.labelControl2.Visible = false;
            // 
            // btnGoGraf
            // 
            this.btnGoGraf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoGraf.ImageOptions.Image")));
            this.btnGoGraf.Location = new System.Drawing.Point(542, 4);
            this.btnGoGraf.Name = "btnGoGraf";
            this.btnGoGraf.Size = new System.Drawing.Size(22, 22);
            this.btnGoGraf.TabIndex = 3;
            this.btnGoGraf.Visible = false;
            this.btnGoGraf.Click += new System.EventHandler(this.btnGoGraf_Click);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            // 
            // chartControl1
            // 
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.EnableAxisXScrolling = true;
            xyDiagram3.EnableAxisXZooming = true;
            xyDiagram3.EnableAxisYScrolling = true;
            xyDiagram3.EnableAxisYZooming = true;
            xyDiagram3.RuntimePaneResize = true;
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.chartControl1.Location = new System.Drawing.Point(0, 31);
            this.chartControl1.Name = "chartControl1";
            series15.Name = "Клеть 1";
            series15.View = lineSeriesView15;
            series16.Name = "Клеть 2";
            series16.View = lineSeriesView16;
            series17.Name = "Клеть 3";
            series17.View = lineSeriesView17;
            series18.Name = "Клеть 4";
            series18.View = lineSeriesView18;
            series19.Name = "Клеть 5";
            series19.View = lineSeriesView19;
            series20.Name = "Клеть 6";
            series20.View = lineSeriesView20;
            series21.Name = "Клеть 7";
            series21.View = lineSeriesView21;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series15,
        series16,
        series17,
        series18,
        series19,
        series20,
        series21};
            this.chartControl1.Size = new System.Drawing.Size(965, 491);
            this.chartControl1.TabIndex = 3;
            this.chartControl1.Visible = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 522);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.stackPanel1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGoGraf;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}

