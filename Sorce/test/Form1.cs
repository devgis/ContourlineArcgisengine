using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.GeoAnalyst;
using ESRI.ArcGIS.DataSourcesRaster;
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFeatureLayer pFeatureLayer =axMapControl1.get_Layer(0) as IFeatureLayer;
            IRaster pOutRaster = CreateRaster(pFeatureLayer);
            CreateContour(pOutRaster);
        }

        private void CreateContour(IRaster pOutRaster)
        {
            ISurfaceOp pSurfaceOp = new RasterSurfaceOp() as ISurfaceOp;
            object odbase = 0;
            IFeatureClass pOutLineFC = pSurfaceOp.Contour(pOutRaster as IGeoDataset, .1, ref odbase) as IFeatureClass;
            IFeatureLayer pFLayercontour = new FeatureLayerClass();
            pFLayercontour.FeatureClass = pOutLineFC;
            pFLayercontour.Name = "等值线";
            ILayer pLayercontour = pFLayercontour as ILayer;
            axMapControl1.AddLayer(pLayercontour);

        }

        private IRaster CreateRaster(IFeatureLayer pFeatureLayer)
        {
            IInterpolationOp pInterpolationOp = new RasterInterpolationOpClass();
            IGeoDataset pInputDataset = (IGeoDataset)pFeatureLayer.FeatureClass;
            IRasterRadius pRadius = new RasterRadiusClass();
            object o1 = Type.Missing;
            pRadius.SetVariable(12, ref o1);
            //设置高程字段
            IFeatureClassDescriptor pFCDescriptor = new FeatureClassDescriptor() as IFeatureClassDescriptor;
            pFCDescriptor.Create(pFeatureLayer.FeatureClass, null, "samp");
            double dCellSize = 0.01364;//像元大小
            object oCell = dCellSize;
            IRasterAnalysisEnvironment pEnv = (IRasterAnalysisEnvironment)pInterpolationOp;
            pEnv.SetCellSize(esriRasterEnvSettingEnum.esriRasterEnvValue, ref oCell);
            IRaster pOutRaster = null;
            object o2 = Type.Missing;
            pOutRaster = pInterpolationOp.IDW(pFCDescriptor as IGeoDataset, 2, pRadius, ref o2) as IRaster;
            IRasterLayer pOutRasterLayer = new RasterLayerClass();
            pOutRasterLayer.CreateFromRaster(pOutRaster);
            pOutRasterLayer.Name = "栅格图像";
            axMapControl1.AddLayer(pOutRasterLayer);
            axMapControl1.Refresh();
            return pOutRaster;
        }

    }
}