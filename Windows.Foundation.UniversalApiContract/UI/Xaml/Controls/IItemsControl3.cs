// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControl3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemsControl))]
  [WebHostHidden]
  [Guid(1345025161, 44772, 19939, 162, 171, 25, 90, 194, 12, 66, 18)]
  internal interface IItemsControl3
  {
    DependencyObject GroupHeaderContainerFromItemContainer(
      DependencyObject itemContainer);
  }
}
