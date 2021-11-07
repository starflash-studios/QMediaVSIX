// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SelectionChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle the SelectionChanged event.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">The event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3785380690, 23200, 17098, 156, 217, 6, 138, 20, 219, 110, 104)]
  [WebHostHidden]
  public delegate void SelectionChangedEventHandler(object sender, SelectionChangedEventArgs e);
}
