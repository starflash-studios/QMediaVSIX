// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IAppListEntry3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (AppListEntry))]
  [Guid(1620701837, 64562, 18186, 188, 105, 75, 6, 26, 118, 239, 46)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAppListEntry3
  {
    [RemoteAsync]
    IAsyncOperation<bool> LaunchForUserAsync(User user);
  }
}
