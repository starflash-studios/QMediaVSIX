// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.ICoreApplication3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Core
{
  [Guid(4276882745, 22923, 17671, 138, 103, 119, 38, 50, 88, 10, 87)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CoreApplication))]
  internal interface ICoreApplication3
  {
    [RemoteAsync]
    IAsyncOperation<AppRestartFailureReason> RequestRestartAsync(
      string launchArguments);

    [RemoteAsync]
    IAsyncOperation<AppRestartFailureReason> RequestRestartForUserAsync(
      User user,
      string launchArguments);
  }
}
