// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the method that will handle the ViewChangeStarted and ViewChangeCompleted events.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [Guid(531174941, 23923, 17659, 129, 172, 209, 201, 56, 73, 25, 212)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void SemanticZoomViewChangedEventHandler(
    object sender,
    SemanticZoomViewChangedEventArgs e);
}
