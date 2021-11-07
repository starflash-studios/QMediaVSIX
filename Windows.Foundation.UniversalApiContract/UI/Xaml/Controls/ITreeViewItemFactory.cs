// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TreeViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Guid(1319315249, 22157, 19725, 173, 253, 61, 141, 197, 170, 93, 136)]
  internal interface ITreeViewItemFactory
  {
    TreeViewItem CreateInstance(object baseInterface, out object innerInterface);
  }
}
