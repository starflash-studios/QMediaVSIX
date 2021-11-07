// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITreeViewListFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (TreeViewList))]
  [Guid(680485426, 16850, 18167, 177, 245, 105, 28, 98, 82, 100, 183)]
  internal interface ITreeViewListFactory
  {
    TreeViewList CreateInstance(object baseInterface, out object innerInterface);
  }
}
