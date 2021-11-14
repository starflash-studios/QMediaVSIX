#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Windows;

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

    void Context_HideOnce_Click( object Sender, RoutedEventArgs E ) {
        Debug.WriteLine($"Attempting to hide {Device} for this session.");
    }

    void Context_HideToggle_Click( object Sender, RoutedEventArgs E ) {
        Debug.WriteLine($"Attempting to add {Device} to the hidden devices section.");
    }
}