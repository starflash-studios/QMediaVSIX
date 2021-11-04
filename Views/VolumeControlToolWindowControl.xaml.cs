using System.Windows;
using System.Windows.Controls;

namespace QMediaVSIX.Views {
    /// <summary> Interaction logic for VolumeControlToolWindowControl. </summary>
    public partial class VolumeControlToolWindowControl {
        /// <summary> Initialises a new instance of the <see cref="VolumeControlToolWindowControl"/> class. </summary>
        public VolumeControlToolWindowControl() {
            InitializeComponent();
        }

        /// <summary> Handles click on the button by displaying a message box. </summary>
        /// <param name="Sender">The event sender.</param>
        /// <param name="E">The event args.</param>
        void Button1_Click(object Sender, RoutedEventArgs E) {
            MessageBox.Show($"Invoked '{ToString()}'", "VolumeControlToolWindow");
        }
    }
}