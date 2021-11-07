// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisementStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>This enumeration defines the advertisement status of a GattServiceProvider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GattServiceProviderAdvertisementStatus
  {
    /// <summary>The GATT service was created.</summary>
    Created,
    /// <summary>The GATT service is not advertising.</summary>
    Stopped,
    /// <summary>The GATT service advertising has started.</summary>
    Started,
    /// <summary>The GATT service was aborted.</summary>
    Aborted,
    /// <summary>Indicates that the system was successfully able to issue the advertisement request, but not all of the requested data could be included in the advertisement.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 524288)] StartedWithoutAllAdvertisementData,
  }
}
