// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePickerDisplayStatusOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Indicates what you'd like the device picker to show about a given device. Used with the SetDisplayStatus method on the DevicePicker object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum DevicePickerDisplayStatusOptions : uint
  {
    /// <summary>Picker should show nothing, or no changes.</summary>
    None = 0,
    /// <summary>Picker should display progress.</summary>
    ShowProgress = 1,
    /// <summary>Picker should display a disconnect button.</summary>
    ShowDisconnectButton = 2,
    /// <summary>Picker should display a retry button.</summary>
    ShowRetryButton = 4,
  }
}
