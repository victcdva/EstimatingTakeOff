using System;
using Apitron.PDF.Kit;
using Apitron.PDF.Kit.FixedLayout;
using Apitron.PDF.Kit.FixedLayout.Resources;
using Apitron.PDF.Kit.FixedLayout.Resources.Fonts;
using Apitron.PDF.Kit.FixedLayout.Resources.XObjects;
using Apitron.PDF.Kit.Interactive.Annotations;
using Apitron.PDF.Kit.Styles;
using Apitron.PDF.Kit.Styles.Appearance;

namespace EstimatingTakeOff
{
    using System.ComponentModel;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using Apitron.PDF.Rasterizer;
    using Apitron.PDF.Rasterizer.Configuration;
    using Apitron.PDF.Rasterizer.Navigation;
    
    using System.Text;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Input;
    using Page = Apitron.PDF.Rasterizer.Page;
    using Rectangle = Apitron.PDF.Rasterizer.Rectangle;
    using Fluent;
    using Microsoft.Win32;


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf, *.PDF)|*.pdf;*.PDF",
                RestoreDirectory = true,
                Title = "Open PDF file"
            };

            bool? dialogResult = dialog.ShowDialog(this);

            if(dialogResult.Value)
            {

            }
            
            
        }
    }
}
