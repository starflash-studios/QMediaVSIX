// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewFullscreenStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3162058429, 25854, 19301, 160, 192, 144, 28, 226, 182, 134, 54)]
  [Deprecated("IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (ApplicationView))]
  internal interface IApplicationViewFullscreenStatics
  {
    [Deprecated("IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    bool TryUnsnapToFullscreen();
  }
}
