// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothCacheMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Indicates whether applicable Bluetooth API methods should operate on values cached in the system, or whether they should retrieve those values from the Bluetooth device. See **Remarks**.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothCacheMode
  {
    /// <summary>Use values cached in the system.</summary>
    Cached,
    /// <summary>Retrieve values from the Bluetooth device.</summary>
    Uncached,
  }
}
