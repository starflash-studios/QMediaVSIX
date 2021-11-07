// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothMajorClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Indicates the Major Class code of the device, which is the general family of device with which the device is associated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothMajorClass
  {
    /// <summary>Used when a more specific Major Class code is not suitable.</summary>
    Miscellaneous,
    /// <summary>A computer. Example devices are desktop, notebook, PDA and organizer.</summary>
    Computer,
    /// <summary>A phone. Example devices are cellular, cordless, pay phone and modem.</summary>
    Phone,
    /// <summary>A LAN or network Access Point.</summary>
    NetworkAccessPoint,
    /// <summary>An audio or video device. Example devices are headset, speaker, stereo, video display and VCR.</summary>
    AudioVideo,
    /// <summary>A peripheral device. Examples are mouse, joystick and keyboard.</summary>
    Peripheral,
    /// <summary>An imaging device. Examples are printer, scanner, camera and display.</summary>
    Imaging,
    /// <summary>A wearable device.</summary>
    Wearable,
    /// <summary>A toy.</summary>
    Toy,
    /// <summary>A health device. An example is a heart rate monitor.</summary>
    Health,
  }
}
