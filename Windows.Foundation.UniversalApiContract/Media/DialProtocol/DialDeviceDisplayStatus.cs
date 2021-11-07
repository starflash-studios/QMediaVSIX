// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDeviceDisplayStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>The possible statuses a DIAL device can have in the DIAL device picker. You can use these to adjust the sub-status and other visual attributes for a particular device in the picker.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DialDeviceDisplayStatus
  {
    /// <summary>The device is not connected.</summary>
    None,
    /// <summary>The device is attempting to connect.</summary>
    Connecting,
    /// <summary>The device is connected.</summary>
    Connected,
    /// <summary>The device is attempting to disconnect.</summary>
    Disconnecting,
    /// <summary>The device is disconnected.</summary>
    Disconnected,
    /// <summary>The device shows an error.</summary>
    Error,
  }
}
