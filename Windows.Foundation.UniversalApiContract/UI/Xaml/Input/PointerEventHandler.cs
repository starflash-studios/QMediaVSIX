// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.PointerEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents the method that will handle pointer message events such as PointerPressed.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [Guid(3828898089, 49156, 19407, 137, 112, 53, 148, 134, 227, 159, 136)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void PointerEventHandler(object sender, PointerRoutedEventArgs e);
}
