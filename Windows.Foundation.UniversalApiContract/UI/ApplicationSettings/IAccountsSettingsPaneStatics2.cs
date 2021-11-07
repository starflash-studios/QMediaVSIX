// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (AccountsSettingsPane))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3525179330, 52749, 18511, 184, 232, 232, 35, 194, 21, 118, 94)]
  internal interface IAccountsSettingsPaneStatics2 : IAccountsSettingsPaneStatics
  {
    [RemoteAsync]
    IAsyncAction ShowManageAccountsAsync();

    [RemoteAsync]
    IAsyncAction ShowAddAccountAsync();
  }
}
