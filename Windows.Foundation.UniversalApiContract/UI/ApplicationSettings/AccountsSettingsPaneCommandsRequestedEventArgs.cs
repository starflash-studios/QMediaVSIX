// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Provides data for the AccountCommandsRequested event.</summary>
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AccountsSettingsPaneCommandsRequestedEventArgs : 
    IAccountsSettingsPaneCommandsRequestedEventArgs,
    IAccountsSettingsPaneCommandsRequestedEventArgs2
  {
    /// <summary>Gets the WebAccountProviderCommand collection for the account settings pane.</summary>
    /// <returns>The web account provider command collection.</returns>
    public extern IVector<WebAccountProviderCommand> WebAccountProviderCommands { [MethodImpl] get; }

    /// <summary>Gets the WebAccountCommand collection for the account settings pane.</summary>
    /// <returns>The web account collection.</returns>
    public extern IVector<WebAccountCommand> WebAccountCommands { [MethodImpl] get; }

    /// <summary>Gets the CredentialCommand collection for the account settings pane.</summary>
    /// <returns>The credential commands.</returns>
    public extern IVector<CredentialCommand> CredentialCommands { [MethodImpl] get; }

    /// <summary>Gets the SettingsCommand collection for the account settings pane.</summary>
    /// <returns>The settings commands.</returns>
    public extern IVector<SettingsCommand> Commands { [MethodImpl] get; }

    /// <summary>Gets or sets the header text for the account settings pane.</summary>
    /// <returns>The header text.</returns>
    public extern string HeaderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the deferral object for the AccountCommandsRequested event.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern AccountsSettingsPaneEventDeferral GetDeferral();

    /// <summary>Gets the user for the account settings pane.</summary>
    /// <returns>The user to whom the account settings apply.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
