using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISorterProject;
using Task5.Tools;
using DevExpress.XtraCharts;
using Task5.Database;

namespace Task5.Forms
{
    public partial class StatisticsForm : Form
    {
        private ThreadParameters[] _threadParameters;

        public StatisticsForm(ThreadParameters[] threadParam)
        {
            _threadParameters = threadParam;

            InitializeComponent();

            chartControl.Titles.Add(new ChartTitle() { Text = "Статистика сортування" });
            chartControl.Legend.AlignmentVertical = LegendAlignmentVertical.BottomOutside;
            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            chartControl.Legend.Direction = LegendDirection.LeftToRight;

            InitTabControl();
        }

        private void InitTabControl()
        {
            tcInfo.TabPages.Clear();

            for (int i = 0; i < _threadParameters.Length; i++)
            {
                CustomTabPage tabPage = new CustomTabPage();

                tabPage.Text = _threadParameters[i].SortMethod.ToString();
                tabPage.AutoScroll = true;

                tabPage.TabPageControl.SorterName = _threadParameters[i].SortMethod.ToString();
                tabPage.TabPageControl.SwapCount = _threadParameters[i].SortMethod.SwapCount.ToString();
                tabPage.TabPageControl.ElementsCount = _threadParameters[i].ArrayForSorting.Length.ToString();
                tabPage.TabPageControl.SortingTime = string.Format("{0:00}:{1:00}:{2:00}",
                    _threadParameters[i].SortMethod.SortingTime.Hours, _threadParameters[i].SortMethod.SortingTime.Minutes,
                    _threadParameters[i].SortMethod.SortingTime.Seconds);

                tabPage.TabPageControl.RatioTimeSizeButton.Click += RatioTimeSizeButton_Click;
                tabPage.TabPageControl.SortingTimeTxtLabel.Click += SortingTimeTxtLabel_Click;

                tcInfo.TabPages.Add(tabPage);
            }
        }
        private void RatioTimeSizeButton_Click(object sender, EventArgs e)
        {
            chartControl.Series.Clear();

            Series series1 = new Series("Sorting time", ViewType.SplineArea);

            using (Database.SortersVisualizerDBEntities context = new Database.SortersVisualizerDBEntities())
            {
                if (!context.Database.Exists())
                {
                    MessageBox.Show("Database doesn't exist.", "Database",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Close();
                }

                string sorterName = _threadParameters[tcInfo.SelectedIndex].SortMethod.ToString();
                int arraySize = _threadParameters[tcInfo.SelectedIndex].ArrayForSorting.Length;                

                var sortedArrays = (from item in context.SortedArrays
                                    where item.vcSorterName == sorterName
                                    orderby item.iSortedArrayId descending
                                    select item).ToArray();

                var arrays = sortedArrays.Where(item => item.vcSortedArrayContent.Split(new Char[] { ' ' }).Length == arraySize).ToArray();

                for (int i = 0; i < arrays.Length && i < 16; i++) // 16 - manual limit, temporary decision
                {
                    series1.Points.Add(new SeriesPoint(i + 1, arrays[i].fSortingTime));
                }
            }

            // Add the series to the chart.
            chartControl.Series.Add(series1);

            // Access the view-type-specific options of the series.
            ((SplineAreaSeriesView)series1.View).LineTensionPercent = 90;
            ((SplineAreaSeriesView)series1.View).ColorEach = true;
            ((SplineAreaSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((SplineAreaSeriesView)series1.View).FillStyle.FillMode = FillMode.Hatch;
            HatchFillOptions hatchFillOptions = ((SplineAreaSeriesView)series1.View).FillStyle.Options as HatchFillOptions;
            hatchFillOptions.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Sphere;

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;

            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Alignment = StringAlignment.Center;
            diagram.AxisY.Title.Text = "Секунди";

            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisX.Title.Alignment = StringAlignment.Center;
            diagram.AxisX.Title.Text = "Номер сортувальника";

            //Set title for chart
            chartControl.Titles[0].Text = "Статистика для масива з розміром " + _threadParameters[tcInfo.SelectedIndex].ArrayForSorting.Length;
        }
        private void SortingTimeTxtLabel_Click(object sender, EventArgs e)
        {
            if (_threadParameters == null)
            {
                MessageBox.Show("Відсутній результат сортування", "Побудова графіка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            chartControl.Series.Clear();

            Series series1 = new Series("Series 1", ViewType.Line);

            for (int i = 0; i < _threadParameters.Length; i++)
            {
                series1.Points.Add(new SeriesPoint(_threadParameters[i].SortMethod.ToString(), _threadParameters[i].SortMethod.SortingTime.TotalSeconds));
            }

            // Add the series to the chart.
            chartControl.Series.Add(series1);

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Auto;

            // Access the view-type-specific options of the series.
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Circle;
            ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Solid;
            ((LineSeriesView)series1.View).LineMarkerOptions.BorderVisible = true;
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).ColorEach = true;

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;

            // Access the type-specific options of the diagram.
            diagram.EnableAxisXZooming = true;

            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Alignment = StringAlignment.Center;
            diagram.AxisY.Title.Text = "Секунди";

            //Set title for chart
            chartControl.Titles[0].Text = "Час сортування";
        }
    }
}
