// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1291226419, 58354, 18788, 184, 94, 148, 91, 79, 126, 47, 33)]
  [WebHostHidden]
  [ExclusiveTo(typeof (NotifyCollectionChangedEventArgs))]
  internal interface INotifyCollectionChangedEventArgs
  {
    NotifyCollectionChangedAction Action { get; }

    IBindableVector NewItems { get; }

    IBindableVector OldItems { get; }

    int NewStartingIndex { get; }

    int OldStartingIndex { get; }
  }
}
