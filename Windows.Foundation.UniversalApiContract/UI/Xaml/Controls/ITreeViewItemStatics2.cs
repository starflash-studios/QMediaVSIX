// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItemStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewItem))]
  [WebHostHidden]
  [Guid(2830074611, 55299, 23589, 180, 141, 174, 14, 115, 177, 109, 142)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ITreeViewItemStatics2
  {
    DependencyProperty HasUnrealizedChildrenProperty { get; }

    DependencyProperty ItemsSourceProperty { get; }
  }
}
