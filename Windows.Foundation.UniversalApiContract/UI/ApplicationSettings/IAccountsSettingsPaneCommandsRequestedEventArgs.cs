// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneCommandsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(996720793, 56089, 17872, 154, 191, 149, 211, 119, 60, 147, 48)]
  [ExclusiveTo(typeof (AccountsSettingsPaneCommandsRequestedEventArgs))]
  internal interface IAccountsSettingsPaneCommandsRequestedEventArgs
  {
    IVector<WebAccountProviderCommand> WebAccountProviderCommands { get; }

    IVector<WebAccountCommand> WebAccountCommands { get; }

    IVector<CredentialCommand> CredentialCommands { get; }

    IVector<SettingsCommand> Commands { get; }

    string HeaderText { get; set; }

    AccountsSettingsPaneEventDeferral GetDeferral();
  }
}
