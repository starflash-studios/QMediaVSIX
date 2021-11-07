// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.BluetoothEventTriggeringMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>This enumeration represents a Bluetooth background event triggering mode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum BluetoothEventTriggeringMode
  {
    /// <summary>The triggering method is serial.</summary>
    Serial,
    /// <summary>The triggering mode is batch.</summary>
    Batch,
    /// <summary>The triggering mode is keep latest.</summary>
    KeepLatest,
  }
}
