// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.ITaskbarManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Shell
{
  [Guid(2269710873, 6873, 18932, 178, 232, 134, 115, 141, 197, 172, 64)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (TaskbarManager))]
  internal interface ITaskbarManager
  {
    bool IsSupported { get; }

    bool IsPinningAllowed { get; }

    [RemoteAsync]
    IAsyncOperation<bool> IsCurrentAppPinnedAsync();

    [RemoteAsync]
    IAsyncOperation<bool> IsAppListEntryPinnedAsync(AppListEntry appListEntry);

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinCurrentAppAsync();

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinAppListEntryAsync(AppListEntry appListEntry);
  }
}
