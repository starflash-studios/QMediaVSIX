// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountProviderCommandInvokedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  /// <summary>Represents the method that's invoked when the user selects an account and a specific action in the account settings pane.</summary>
  /// <param name="command">The provider command that's done against the web account in the accounts pane.</param>
  [Guid(3084801319, 19599, 17117, 132, 218, 94, 196, 147, 171, 219, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void WebAccountProviderCommandInvokedHandler(WebAccountProviderCommand command);
}
