// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IIsoSpeedControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (IsoSpeedControl))]
  [Guid(666288930, 9645, 20251, 170, 171, 82, 74, 179, 118, 202, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IIsoSpeedControl
  {
    bool Supported { get; }

    IVectorView<IsoSpeedPreset> SupportedPresets { [Deprecated("SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    IsoSpeedPreset Preset { [Deprecated("Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [RemoteAsync]
    [Deprecated("SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction SetPresetAsync(IsoSpeedPreset preset);
  }
}
