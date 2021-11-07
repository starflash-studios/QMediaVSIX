// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Associates a command with a WebAccount in the account settings pane..</summary>
  [Muse(Version = 100859904)]
  [Activatable(typeof (IWebAccountCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.None)]
  public sealed class WebAccountCommand : IWebAccountCommand
  {
    /// <summary>Initializes a new instance of the WebAccountCommand class.</summary>
    /// <param name="webAccount">The web account to associate with the current command.</param>
    /// <param name="invoked">The delegate that handles the command.</param>
    /// <param name="actions">A bitmask of web account actions.</param>
    [MethodImpl]
    public extern WebAccountCommand(
      WebAccount webAccount,
      WebAccountCommandInvokedHandler invoked,
      SupportedWebAccountActions actions);

    /// <summary>Gets the web account that's associated with the current command.</summary>
    /// <returns>The web account.</returns>
    public extern WebAccount WebAccount { [MethodImpl] get; }

    /// <summary>Gets the delegate that's invoked when the user selects an account and a specific action in the account settings pane.</summary>
    /// <returns>The handler.</returns>
    public extern WebAccountCommandInvokedHandler Invoked { [MethodImpl] get; }

    /// <summary>Gets the actions that the command performs on the web account in the accounts pane.</summary>
    /// <returns>The actions for the web account.</returns>
    public extern SupportedWebAccountActions Actions { [MethodImpl] get; }
  }
}
