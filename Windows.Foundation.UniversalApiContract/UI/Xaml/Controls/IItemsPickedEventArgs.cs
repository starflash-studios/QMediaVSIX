// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsPickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4183530156, 42529, 18574, 145, 86, 142, 227, 17, 101, 190, 4)]
  [ExclusiveTo(typeof (ItemsPickedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsPickedEventArgs
  {
    IVector<object> AddedItems { get; }

    IVector<object> RemovedItems { get; }
  }
}
