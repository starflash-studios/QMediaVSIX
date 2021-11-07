// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IStartScreenManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.StartScreen
{
  [Guid(1243466699, 9961, 20148, 137, 51, 133, 158, 182, 236, 219, 41)]
  [ExclusiveTo(typeof (StartScreenManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IStartScreenManager
  {
    User User { get; }

    bool SupportsAppListEntry(AppListEntry appListEntry);

    [RemoteAsync]
    IAsyncOperation<bool> ContainsAppListEntryAsync(AppListEntry appListEntry);

    IAsyncOperation<bool> RequestAddAppListEntryAsync(AppListEntry appListEntry);
  }
}
