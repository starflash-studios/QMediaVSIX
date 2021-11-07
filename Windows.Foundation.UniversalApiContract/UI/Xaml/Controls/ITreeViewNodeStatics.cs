// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewNodeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewNode))]
  [Guid(1568831230, 57809, 19297, 158, 129, 199, 251, 24, 154, 41, 128)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  internal interface ITreeViewNodeStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty DepthProperty { get; }

    DependencyProperty IsExpandedProperty { get; }

    DependencyProperty HasChildrenProperty { get; }
  }
}
