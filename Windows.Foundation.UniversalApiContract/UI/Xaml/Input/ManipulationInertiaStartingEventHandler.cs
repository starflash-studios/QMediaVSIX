// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationInertiaStartingEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents the method that will handle the ManipulationInertiaStarting event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3550307106, 31900, 18459, 130, 123, 200, 178, 217, 187, 111, 199)]
  public delegate void ManipulationInertiaStartingEventHandler(
    object sender,
    ManipulationInertiaStartingRoutedEventArgs e);
}
