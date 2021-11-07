// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionInfraredFrameSourcePropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Deprecated("KnownPerceptionInfraredFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1576127650, 504, 19079, 184, 89, 213, 229, 183, 225, 222, 73)]
  [ExclusiveTo(typeof (KnownPerceptionInfraredFrameSourceProperties))]
  internal interface IKnownPerceptionInfraredFrameSourcePropertiesStatics
  {
    string Exposure { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.Exposure may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.ExposureControl instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string AutoExposureEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.AutoExposureEnabled may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.ExposureControl.Auto instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string ExposureCompensation { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.ExposureCompensation may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.ExposureCompensationControl instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string ActiveIlluminationEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.ActiveIlluminationEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string AmbientSubtractionEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.AmbientSubtractionEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string StructureLightPatternEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.StructureLightPatternEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string InterleavedIlluminationEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.InterleavedIlluminationEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
