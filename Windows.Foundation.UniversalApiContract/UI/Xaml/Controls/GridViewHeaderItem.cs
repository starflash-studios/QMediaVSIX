// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.GridViewHeaderItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents items in the header for grouped data inside a GridView.</summary>
  [Composable(typeof (IGridViewHeaderItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class GridViewHeaderItem : ListViewBaseHeaderItem, IGridViewHeaderItem
  {
    /// <summary>Initializes a new instance of the GridViewHeaderItem class.</summary>
    [MethodImpl]
    public extern GridViewHeaderItem();
  }
}
