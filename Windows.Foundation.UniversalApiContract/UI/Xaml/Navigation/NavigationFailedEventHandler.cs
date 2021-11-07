// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigationFailedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Represents a method that will handle the WebView.NavigationFailed and Frame.NavigationFailed events.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1303070321, 4786, 17351, 184, 146, 155, 226, 220, 211, 232, 141)]
  [WebHostHidden]
  public delegate void NavigationFailedEventHandler(object sender, NavigationFailedEventArgs e);
}
