#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Security.Cryptography;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Controls;
using QMediaVSIX.Core.MediaSource;
using QMediaVSIX.Core.MediaSource.Hardware;

#endregion

namespace QMediaVSIX.ToolWindows; 

/// <summary>
/// Interaction logic for VolumeMixerToolWindowControl.
/// </summary>
public partial class VolumeMixerToolWindowControl {
    /// <summary>
    /// Initialises a new instance of the <see cref="VolumeMixerToolWindowControl"/> class.
    /// </summary>
    public VolumeMixerToolWindowControl() {
        InitializeComponent();

        _ = ThreadHelper.JoinableTaskFactory.RunAsync(async () => {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
            MediaSourceManager.Initialise();
            MediaDeviceManager.DeviceConnected += (S, _) => {
                Debug.WriteLine($"Looking {S}");
                MediaDeviceView MDV = new MediaDeviceView { Device = S };
                LV.Items.Add(MDV);
            };
            MediaDeviceManager.DeviceDisconnected += S => {
                foreach (object Item in LV.Items ) {
                    if (Item is MediaDeviceView MDV && MDV.Device?.Identifier == S.Identifier ) {
                        LV.Items.Remove(MDV);
                    }
                }
            };
            foreach ( (_, MediaDevice Dev) in MediaDeviceManager.Devices ) {
                Debug.WriteLine($"Pushing {Dev}");
                MediaDeviceView MDV = new MediaDeviceView { Device = Dev };
                LV.Items.Add(MDV);
            }
        });

        //VM = new VolumeMixerToolWindowViewModel();
        //DataContext = VM;
        //_ = ThreadHelper.JoinableTaskFactory.RunAsync(async () => {
        //    await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
        //    //Debug.WriteLine("Switched.");
        //    VM.Init();

        //    //MediaDeviceManager.DeviceConnected += MediaDeviceManager_DeviceConnected;
        //    //Debug.WriteLine("Checking devices...");
        //    //foreach ( (_, MediaDevice Dev) in MediaDeviceManager.Devices ) {
        //    //    Debug.WriteLine($"Already connected device: {Dev}.");
        //    //    if ( Dev.ToString().Contains("opera") ) {
        //    //        TestView.VM.SetDevice(Dev);
        //    //    }
        //    //}
        //    //Debug.WriteLine("Check complete.");
        //});
    }

    //public VolumeMixerToolWindowViewModel VM { get; }
    //public ObservableCollection<MediaDevice> Devices { get; } = new ObservableCollection<MediaDevice>();
}