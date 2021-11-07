// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.BackClickEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle a BackClick event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [Guid(4204511775, 39058, 18478, 171, 246, 235, 45, 96, 125, 50, 222)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void BackClickEventHandler(object sender, BackClickEventArgs e);
}
