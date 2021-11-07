// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewBaseHeaderItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides the infrastructure for the ListViewHeaderItem and GridViewHeaderItem classes.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IListViewBaseHeaderItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ListViewBaseHeaderItem : ContentControl, IListViewBaseHeaderItem
  {
  }
}
