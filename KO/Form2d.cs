using Arction.WinForms.Charting;
using Arction.WinForms.Charting.SeriesXY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KO
{
    public partial class Form2d : Form
    {
        private LightningChartUltimate lightingchart2 = null;
        private IntensityGridSeries heatMap = null;
        Params paramss;
        private const int MinY = 0;
        private const int MinX = 0;
        int rows;
        int columns;
        int MaxY;
        int MaxX;
        public Form2d(Params paramsss)
        {
            InitializeComponent();
            paramss = paramsss;
            rows = Convert.ToInt32(paramss.a2);
            columns = Convert.ToInt32(paramss.b2);
            MaxY = Convert.ToInt32(paramss.b2);
            MaxX = Convert.ToInt32(paramss.a2);

            CreateChart();
            GenerateData(columns, rows);
            FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        public void CreateChart()
        {
            lightingchart2 = new LightningChartUltimate();
            lightingchart2.Parent = this;
            lightingchart2.Dock = DockStyle.Fill;
            lightingchart2.ColorTheme = ColorTheme.LightGray;
            lightingchart2.BeginUpdate();
            lightingchart2.ViewXY.LegendBoxes[0].Visible = false;
            var axisX = lightingchart2.ViewXY.XAxes[0];
            var axisY = lightingchart2.ViewXY.YAxes[0];
            axisX.Title.Text = "A1";
            axisX.SetRange(MinX, MaxX);
            axisY.Title.Text = "A2";
            axisY.SetRange(MinY, MaxY);

            heatMap = new IntensityGridSeries(lightingchart2.ViewXY, axisX, axisY);
            
            heatMap.MouseInteraction = false;
            heatMap.PixelRendering = false;
            heatMap.SetRangesXY(MinX, MaxX, MinY, MaxY);
            heatMap.SetSize(columns, rows);

            if (heatMap.ValueRangePalette != null)
                heatMap.ValueRangePalette.Dispose();
            heatMap.ValueRangePalette = CreatePalette(heatMap);

            lightingchart2.ViewXY.IntensityGridSeries.Add(heatMap);
            lightingchart2.ViewXY.ZoomToFit();

            lightingchart2.EndUpdate();
        }

        private ValueRangePalette CreatePalette(IntensityGridSeries series)
        {
           
            var palette = new ValueRangePalette(series);

            foreach (var step in palette.Steps)
            {
                step.Dispose();
            }
            palette.Steps.Clear();

            Random rand = new Random();
            for (int i = 0; i < 8000; i += 300)
            {

                palette.Steps.Add(new PaletteStep(palette, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)), i));
            }
           
            palette.Type = PaletteType.Uniform;
            palette.MinValue = 0;

            return palette;
        }

        public void GenerateData(int columns, int rows)
        {
            var data = new IntensityPoint[columns, rows];

            lightingchart2.BeginUpdate();

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    data[i, j].Value = paramss.alpha * Math.Pow((i * i + paramss.beta * j - paramss.mu * paramss.V1), 2) + paramss.alpha1 * Math.Pow((paramss.beta1 * i + j * j - paramss.mu1 * paramss.V2), 2);
                }
            }

            // Add generated data as Heat Map data.
            heatMap.Data = data;

            // Call EndUpdate to enable rendering again.
            lightingchart2.EndUpdate();

        }

        private void Form_Closed(Object sender, FormClosedEventArgs e)
        {
            lightingchart2.Dispose();
            lightingchart2 = null;

            heatMap.Dispose();
            heatMap = null;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png files (*.png)|*.png|All files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                lightingchart2.SaveToFile(save.FileName);
            }
            MessageBox.Show(text: "График сохранен успешно", caption: "Информация", buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
        }
    }


}
