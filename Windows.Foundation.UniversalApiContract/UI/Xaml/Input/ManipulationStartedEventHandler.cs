// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationStartedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents the method that will handle ManipulationStarted and related events.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4169352696, 57507, 19426, 185, 12, 220, 32, 230, 216, 190, 176)]
  [WebHostHidden]
  public delegate void ManipulationStartedEventHandler(
    object sender,
    ManipulationStartedRoutedEventArgs e);
}
