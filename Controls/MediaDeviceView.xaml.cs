using QMediaVSIX.Core.MediaSource.Hardware;

namespace QMediaVSIX.Views;

public partial class MediaDeviceView {
    //IViewFor<MediaDeviceViewModel>
    public MediaDeviceView() {
        Debug.WriteLine("Initialising view...");
        InitializeComponent(); //TODO: Proper ViewModel -- ReactiveUI support???
        VM = new MediaDeviceViewModel();
        DataContext = VM;
        Debug.WriteLine($"DataContext: {DataContext}");
    }

    public MediaDeviceViewModel VM { get; }

    public MediaDevice? Device {
        get => VM.Device;
        set {
            VM.SetDevice(value ?? throw new ArgumentNullException(nameof(value)));
            RaisePropertyChanged(nameof(Device));
        }
    }

}