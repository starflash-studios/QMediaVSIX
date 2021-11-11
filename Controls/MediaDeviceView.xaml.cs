#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using QMediaVSIX.Core.MediaSource.Hardware;

#endregion

namespace QMediaVSIX.Controls;

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