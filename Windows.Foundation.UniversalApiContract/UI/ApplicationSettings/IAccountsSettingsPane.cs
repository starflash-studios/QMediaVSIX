// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPane
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2179634220, 20233, 17414, 165, 56, 131, 141, 155, 20, 183, 230)]
  [ExclusiveTo(typeof (AccountsSettingsPane))]
  internal interface IAccountsSettingsPane
  {
    event TypedEventHandler<AccountsSettingsPane, AccountsSettingsPaneCommandsRequestedEventArgs> AccountCommandsRequested;
  }
}
