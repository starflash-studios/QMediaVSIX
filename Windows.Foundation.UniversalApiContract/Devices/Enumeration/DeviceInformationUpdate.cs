// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformationUpdate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Contains updated properties for a DeviceInformation object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceInformationUpdate : IDeviceInformationUpdate, IDeviceInformationUpdate2
  {
    /// <summary>The DeviceInformation ID of the updated device.</summary>
    /// <returns>The DeviceInformation ID of the updated device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>The changed properties in a update to a DeviceInformation object.</summary>
    /// <returns>The changed properties.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }

    /// <summary>Gets the type of device for the updated device.</summary>
    /// <returns>The type of device.</returns>
    public extern DeviceInformationKind Kind { [MethodImpl] get; }
  }
}
