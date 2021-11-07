// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (AccountsSettingsPane))]
  [Guid(138478680, 41658, 19567, 180, 172, 72, 245, 20, 51, 18, 22)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAccountsSettingsPaneStatics3
  {
    [RemoteAsync]
    IAsyncAction ShowManageAccountsForUserAsync(User user);

    [RemoteAsync]
    IAsyncAction ShowAddAccountForUserAsync(User user);
  }
}
