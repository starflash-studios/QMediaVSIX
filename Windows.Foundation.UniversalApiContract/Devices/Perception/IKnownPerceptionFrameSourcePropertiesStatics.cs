// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionFrameSourcePropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(1576127650, 504, 19079, 184, 89, 213, 229, 183, 225, 222, 71)]
  [ExclusiveTo(typeof (KnownPerceptionFrameSourceProperties))]
  internal interface IKnownPerceptionFrameSourcePropertiesStatics
  {
    string Id { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string PhysicalDeviceIds { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string FrameKind { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceModelVersion { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string EnclosureLocation { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
