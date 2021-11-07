// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.SelectorItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Provides a base class for item types in a selection control.</summary>
  [Static(typeof (ISelectorItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (ISelectorItemFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class SelectorItem : ContentControl, ISelectorItem
  {
    /// <summary>Provides base class initialization behavior for SelectorItem -derived classes.</summary>
    [MethodImpl]
    protected extern SelectorItem();

    /// <summary>Gets or sets a value that indicates whether the item is selected in a selector.</summary>
    /// <returns>**true** if the item is selected; otherwise, **false**.</returns>
    public extern bool IsSelected { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsSelected dependency property.</summary>
    /// <returns>The identifier for the IsSelected dependency property.</returns>
    public static extern DependencyProperty IsSelectedProperty { [MethodImpl] get; }
  }
}
