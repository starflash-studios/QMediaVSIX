// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountProviderCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Associates a provider command with a WebAccountProvider in the account settings pane.</summary>
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.None)]
  [Activatable(typeof (IWebAccountProviderCommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  public sealed class WebAccountProviderCommand : IWebAccountProviderCommand
  {
    /// <summary>Initializes a new instance of the WebAccountProviderCommand class.</summary>
    /// <param name="webAccountProvider">The web account provider.</param>
    /// <param name="invoked">The delegate that handles the provider command.</param>
    [MethodImpl]
    public extern WebAccountProviderCommand(
      WebAccountProvider webAccountProvider,
      WebAccountProviderCommandInvokedHandler invoked);

    /// <summary>Gets the web account provider that's associated with the current command.</summary>
    /// <returns>The web account provider.</returns>
    public extern WebAccountProvider WebAccountProvider { [MethodImpl] get; }

    /// <summary>Gets the delegate that's invoked when the user selects an account and a specific action in the accounts pane.</summary>
    /// <returns>The handler.</returns>
    public extern WebAccountProviderCommandInvokedHandler Invoked { [MethodImpl] get; }
  }
}
