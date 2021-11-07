// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(367381484, 40463, 18101, 188, 63, 155, 246, 83, 231, 75, 94)]
  [ExclusiveTo(typeof (ApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IApplicationView4
  {
    ApplicationViewMode ViewMode { get; }

    bool IsViewModeSupported(ApplicationViewMode viewMode);

    [RemoteAsync]
    [Overload("TryEnterViewModeAsync")]
    IAsyncOperation<bool> TryEnterViewModeAsync(ApplicationViewMode viewMode);

    [RemoteAsync]
    [Overload("TryEnterViewModeWithPreferencesAsync")]
    IAsyncOperation<bool> TryEnterViewModeAsync(
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);

    [RemoteAsync]
    IAsyncOperation<bool> TryConsolidateAsync();
  }
}
