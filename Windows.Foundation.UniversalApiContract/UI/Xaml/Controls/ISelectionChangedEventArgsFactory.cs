// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISelectionChangedEventArgsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SelectionChangedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(296269493, 10288, 17687, 132, 205, 85, 36, 200, 184, 139, 69)]
  internal interface ISelectionChangedEventArgsFactory
  {
    SelectionChangedEventArgs CreateInstanceWithRemovedItemsAndAddedItems(
      IVector<object> removedItems,
      IVector<object> addedItems,
      object baseInterface,
      out object innerInterface);
  }
}
