// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.PivotItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the container for an item in a Pivot control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPivotItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IPivotItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class PivotItem : ContentControl, IPivotItem
  {
    /// <summary>Initializes a new instance of the PivotItem type.</summary>
    [MethodImpl]
    public extern PivotItem();

    /// <summary>Gets or sets the header for the PivotItem.</summary>
    /// <returns>Returns Object.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }
  }
}
