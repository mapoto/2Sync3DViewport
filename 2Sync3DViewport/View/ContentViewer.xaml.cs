using HelixToolkit.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2Sync3DViewport.View
{
    /// <summary>
    /// Interaction logic for ContentViewer.xaml
    /// </summary>
    public partial class ContentViewer : UserControl, INotifyPropertyChanged
    {
        private string filePath;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FilePath
        {
            get => filePath;
            set
            {
                filePath = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundedFilePath"));
            }
        }
        public PerspectiveCamera Camera
        {
            get => viewPort3d.Camera as PerspectiveCamera;
            set => viewPort3d.Camera = value;
        }

        public ContentViewer()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                // Filter for 3D files
                openFileDialog.Filter = "3D Files (*.obj)|*.obj|All Files (*.*)|*.*";
                FilePath = openFileDialog.FileName;
                FilePathTextBox.Text = filePath;
                ModelVisual3D device3D = new ModelVisual3D();
                device3D.Content = Display3d(filePath);

                // Add to view port
                viewPort3d.Children.Add(device3D);

            }

        }

        private Model3D Display3d(string model)
        {
            Model3D device = null;
            try
            {
                //Adding a gesture here
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);

                //Import 3D model file
                ModelImporter import = new ModelImporter();

                //Load the 3D model file
                device = import.Load(model);
            }
            catch (Exception e)
            {
                // Handle exception in case can not find the 3D model file
                MessageBox.Show("Exception Error : " + e.StackTrace);
            }
            return device;
        }

        private void viewPort3d_Drop(object sender, DragEventArgs e)
        {
            FilePath = e.Data.ToString();
        }
    }
}
