// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [ExclusiveTo(typeof (NotifyCollectionChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3003924026, 57229, 17573, 154, 56, 122, 192, 208, 140, 230, 61)]
  [WebHostHidden]
  internal interface INotifyCollectionChangedEventArgsFactory
  {
    NotifyCollectionChangedEventArgs CreateInstanceWithAllParameters(
      NotifyCollectionChangedAction action,
      IBindableVector newItems,
      IBindableVector oldItems,
      int newIndex,
      int oldIndex,
      object baseInterface,
      out object innerInterface);
  }
}
