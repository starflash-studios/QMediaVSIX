// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [Deprecated("ApplicationView static methods may be altered or unavailable for releases after Windows 8.1. Instead, use ApplicationView.GetForCurrentView to get an instance of ApplicationView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(17457926, 50227, 17637, 169, 242, 189, 132, 212, 3, 10, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationViewStatics
  {
    ApplicationViewState Value { [Deprecated("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    bool TryUnsnap();
  }
}
