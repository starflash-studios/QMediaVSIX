// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.ICortanaActionableInsights
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Services.Cortana
{
  [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (CortanaActionableInsights))]
  [Guid(2501822129, 64643, 22637, 139, 132, 36, 82, 200, 152, 22, 37)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ICortanaActionableInsights
  {
    User User { [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")] get; }

    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<bool> IsAvailableAsync();

    [Overload("ShowInsightsForImageAsync")]
    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    IAsyncAction ShowInsightsForImageAsync(IRandomAccessStreamReference imageStream);

    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("ShowInsightsForImageWithOptionsAsync")]
    IAsyncAction ShowInsightsForImageAsync(
      IRandomAccessStreamReference imageStream,
      CortanaActionableInsightsOptions options);

    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [Overload("ShowInsightsForTextAsync")]
    [RemoteAsync]
    IAsyncAction ShowInsightsForTextAsync(string text);

    [Overload("ShowInsightsForTextWithOptionsAsync")]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncAction ShowInsightsForTextAsync(
      string text,
      CortanaActionableInsightsOptions options);

    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [Overload("ShowInsightsAsync")]
    IAsyncAction ShowInsightsAsync(DataPackage datapackage);

    [RemoteAsync]
    [Deprecated("CortanaActionableInsights is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    [Overload("ShowInsightsWithOptionsAsync")]
    IAsyncAction ShowInsightsAsync(
      DataPackage datapackage,
      CortanaActionableInsightsOptions options);
  }
}
