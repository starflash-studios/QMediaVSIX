// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayPropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (DisplayProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1765272973, 12522, 19949, 130, 113, 69, 83, 255, 2, 246, 138)]
  [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IDisplayPropertiesStatics
  {
    DisplayOrientations CurrentOrientation { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DisplayOrientations NativeOrientation { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DisplayOrientations AutoRotationPreferences { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    event DisplayPropertiesEventHandler OrientationChanged;

    ResolutionScale ResolutionScale { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    float LogicalDpi { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event DisplayPropertiesEventHandler LogicalDpiChanged;

    bool StereoEnabled { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event DisplayPropertiesEventHandler StereoEnabledChanged;

    [RemoteAsync]
    [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

    event DisplayPropertiesEventHandler ColorProfileChanged;

    event DisplayPropertiesEventHandler DisplayContentsInvalidated;
  }
}
