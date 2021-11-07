// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.AccountsSettingsPane
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Provides methods to show the accounts pane and also to enable the app to register callbacks when the accounts flyout is about to be displayed.</summary>
  [Static(typeof (IAccountsSettingsPaneStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAccountsSettingsPaneStatics3), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAccountsSettingsPaneStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class AccountsSettingsPane : IAccountsSettingsPane
  {
    /// <summary>Occurs when the user opens the accounts pane. Handling this event lets the app initialize the accounts commands and pause its UI until the user closes the pane.</summary>
    public extern event TypedEventHandler<AccountsSettingsPane, AccountsSettingsPaneCommandsRequestedEventArgs> AccountCommandsRequested;

    /// <summary>Displays the manage accounts screen for the specified user.</summary>
    /// <param name="user">The user whose accounts will be accessed.</param>
    /// <returns>Represents the asynchronous action. You usually don't access this IAsyncAction return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowManageAccountsForUserAsync(User user);

    /// <summary>Displays the add accounts screen for the specified user.</summary>
    /// <param name="user">The user who will add an account.</param>
    /// <returns>Represents the asynchronous action. You usually don't access this IAsyncAction return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAddAccountForUserAsync(User user);

    /// <summary>Displays the manage accounts screen.</summary>
    /// <returns>Represents the asynchronous action. You usually don't access this IAsyncAction return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowManageAccountsAsync();

    /// <summary>Displays the add accounts screen.</summary>
    /// <returns>Represents the asynchronous action. You usually don't access this IAsyncAction return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAddAccountAsync();

    /// <summary>Gets an AccountsSettingsPane object that is associated with the current app view (that is, with CoreWindow ).</summary>
    /// <returns>The account settings pane.</returns>
    [MethodImpl]
    public static extern AccountsSettingsPane GetForCurrentView();

    /// <summary>Displays the account settings pane.</summary>
    [MethodImpl]
    public static extern void Show();
  }
}
