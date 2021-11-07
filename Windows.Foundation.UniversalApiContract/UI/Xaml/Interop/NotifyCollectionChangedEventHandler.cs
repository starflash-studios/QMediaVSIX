// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.NotifyCollectionChangedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Represents the method that will handle the CollectionChanged event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [Guid(3390092156, 62338, 17809, 133, 87, 94, 36, 150, 82, 121, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void NotifyCollectionChangedEventHandler(
    object sender,
    NotifyCollectionChangedEventArgs e);
}
