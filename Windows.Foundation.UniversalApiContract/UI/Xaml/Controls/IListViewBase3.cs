// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3009724469, 2579, 16495, 163, 251, 243, 14, 125, 220, 169, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewBase))]
  [WebHostHidden]
  internal interface IListViewBase3
  {
    ListViewReorderMode ReorderMode { get; set; }
  }
}
