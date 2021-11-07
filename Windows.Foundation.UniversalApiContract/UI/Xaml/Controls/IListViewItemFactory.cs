// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewItem))]
  [Guid(4096853821, 40108, 17058, 130, 223, 15, 68, 144, 188, 78, 46)]
  internal interface IListViewItemFactory
  {
    ListViewItem CreateInstance(object baseInterface, out object innerInterface);
  }
}
