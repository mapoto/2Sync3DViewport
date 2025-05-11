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
//using 2Sync3DViewport.ViewModel;
namespace _2Sync3DViewport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ContentViewModel contentViewModel { get; set; }

        public MainWindow()
        {
            //InitializeComponent();


            //var leftCamera = ContentViewerlLeft.Camera;
            //var rightCamera = ContentViewerlRight.Camera;

            //// Listen for changes in the left camera and update the right camera
            //leftCamera.Changed += (s, e) =>
            //{
            //    ContentViewerlRight.Camera.Position = leftCamera.Position;
            //    ContentViewerlRight.Camera.LookDirection = leftCamera.LookDirection;
            //    ContentViewerlRight.Camera.UpDirection = leftCamera.UpDirection;
            //};

            //// Optionally, synchronize the other way around if needed
            //rightCamera.Changed += (s, e) =>
            //{
            //    ContentViewerlLeft.Camera.Position = rightCamera.Position;
            //    ContentViewerlLeft.Camera.LookDirection = rightCamera.LookDirection;
            //    ContentViewerlLeft.Camera.UpDirection = rightCamera.UpDirection;
            //};

        }

    }
}
