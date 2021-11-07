// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ListViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3082502917, 15833, 17374, 168, 192, 196, 114, 240, 133, 188, 17)]
  internal interface IListViewItem
  {
    ListViewItemTemplateSettings TemplateSettings { get; }
  }
}
