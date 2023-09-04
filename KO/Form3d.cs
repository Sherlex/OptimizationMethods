using Arction.WinForms.Charting;
using Arction.WinForms.Charting.Series3D;
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
    public partial class Form3d : Form
    {
        Params paramss;
        private LightningChartUltimate lightningChartUltimate1 = null;
        private SurfaceGridSeries3D surfaceGrid = null;
        int rows;
        int columns;
        private const int minX = 0;
        private const int maxX = 400;
        private const int minZ = 0;
        private const int maxZ = 400;
        public Form3d(Params paramsss)
        {
            InitializeComponent();
            paramss = paramsss;
            columns = Convert.ToInt32(paramss.a2) * 4;
            rows = Convert.ToInt32(paramss.b2) * 4;
            CreateChart();
            GenerateData(columns, rows);
            FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        public void CreateChart()
        {
            lightningChartUltimate1 = new LightningChartUltimate();

            lightningChartUltimate1.Parent = this;
            lightningChartUltimate1.Dock = DockStyle.Fill;
            lightningChartUltimate1.ColorTheme = ColorTheme.LightGray;
            
            lightningChartUltimate1.BeginUpdate();

            lightningChartUltimate1.ActiveView = ActiveView.View3D;

            lightningChartUltimate1.View3D.YAxisPrimary3D.SetRange(0, 5000);

            lightningChartUltimate1.View3D.LegendBox.Layout = LegendBoxLayout.Vertical;

            surfaceGrid = new SurfaceGridSeries3D(lightningChartUltimate1.View3D, Axis3DBinding.Primary, Axis3DBinding.Primary, Axis3DBinding.Primary);
            surfaceGrid.Title.Text = "3D";
            surfaceGrid.RangeMinX = minX;
            surfaceGrid.RangeMaxX = maxX;
            surfaceGrid.RangeMinZ = minZ;
            surfaceGrid.RangeMaxZ = maxZ;
            surfaceGrid.SizeX = columns;
            surfaceGrid.SizeZ = rows;
            surfaceGrid.ColorSaturation = 100;
            var axisX = lightningChartUltimate1.View3D.XAxisPrimary3D;
            var axisY = lightningChartUltimate1.View3D.YAxisPrimary3D;
            var axisZ = lightningChartUltimate1.View3D.ZAxisPrimary3D;
            axisX.Title.Text = "A1";
            axisZ.Title.Text = "A2";
            axisY.Title.Text = "Количество целевого компонента";

            ValueRangePalette palette = CreatePalette(surfaceGrid);
            surfaceGrid.ContourPalette = palette;

            surfaceGrid.WireframeType = SurfaceWireframeType3D.WireframePalettedByY;
            surfaceGrid.ContourLineType = ContourLineType3D.ColorLineByY;
            surfaceGrid.ContourLineWidth = 1;

            lightningChartUltimate1.View3D.SurfaceGridSeries3D.Add(surfaceGrid);

            lightningChartUltimate1.EndUpdate();
        }

        private ValueRangePalette CreatePalette(SurfaceGridSeries3D surfaceGrid)
        {
            Random rand = new Random();
            var palette = new ValueRangePalette(surfaceGrid);
            foreach (var step in palette.Steps)
            {
                step.Dispose();
            }
            palette.Steps.Clear();

            palette.Steps.Add(new PaletteStep(palette, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)), 0));
            palette.Steps.Add(new PaletteStep(palette, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)), 1000));
            palette.Steps.Add(new PaletteStep(palette, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)), 2000));
            palette.Steps.Add(new PaletteStep(palette, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)), 3000));
            palette.Steps.Add(new PaletteStep(palette, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)), 4000));
            palette.Type = PaletteType.Gradient;
            palette.MinValue = 0;
            return palette;
        }

        public void GenerateData(int columns, int rows)
        {
            double data = 0;
            lightningChartUltimate1.BeginUpdate();

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    data = paramss.alpha * Math.Pow((i * i + paramss.beta * j - paramss.mu * paramss.V1), 2) + paramss.alpha1 * Math.Pow((paramss.beta1 * i + j * j - paramss.mu1 * paramss.V2), 2);
                    surfaceGrid.Data[i, j].Y = data;
                }
            }

            surfaceGrid.InvalidateData();
            lightningChartUltimate1.EndUpdate();
        }

        private void Form_Closed(Object sender, FormClosedEventArgs e)
        {
           
            lightningChartUltimate1.Dispose();
            lightningChartUltimate1 = null;

           
            surfaceGrid.Dispose();
            surfaceGrid = null;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png files (*.png)|*.png|All files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                lightningChartUltimate1.SaveToFile(save.FileName);
            }
            MessageBox.Show(text: "График сохранен успешно", caption: "Информация", buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
        }
    }
}