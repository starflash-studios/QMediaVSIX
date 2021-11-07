// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents the return status of a WinRT GATT API related Async operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GattCommunicationStatus
  {
    /// <summary>The operation completed successfully.</summary>
    Success,
    /// <summary>No communication can be performed with the device, at this time.</summary>
    Unreachable,
    /// <summary>There was a GATT communication protocol error.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] ProtocolError,
    /// <summary>Access is denied.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] AccessDenied,
  }
}
