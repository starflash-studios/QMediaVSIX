// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountCommandInvokedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Represents the method that's invoked when the user selects an account and a specific action in the account settings pane.</summary>
  /// <param name="command">The command that's done against the web account in the accounts pane.</param>
  /// <param name="args">The data for the command.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(518448217, 5893, 19098, 181, 153, 160, 195, 214, 146, 25, 115)]
  public delegate void WebAccountCommandInvokedHandler(
    WebAccountCommand command,
    WebAccountInvokedArgs args);
}
