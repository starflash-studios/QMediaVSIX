// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IWebUIActivationStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.WebUI
{
  [Guid(2443949702, 6901, 17477, 180, 159, 148, 89, 244, 15, 200, 222)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (WebUIApplication))]
  internal interface IWebUIActivationStatics3
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
