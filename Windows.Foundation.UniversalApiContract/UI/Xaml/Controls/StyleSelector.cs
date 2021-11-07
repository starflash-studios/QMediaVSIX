// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.StyleSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Enables custom item style selection logic as a function of the content data and its specific item container.</summary>
  [Composable(typeof (IStyleSelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public class StyleSelector : IStyleSelector, IStyleSelectorOverrides
  {
    /// <summary>Initializes a new instance of the StyleSelector class.</summary>
    [MethodImpl]
    public extern StyleSelector();

    /// <summary>Returns a specific Style based on custom logic.</summary>
    /// <param name="item">The content.</param>
    /// <param name="container">The element to which the style is applied.</param>
    /// <returns>An application-specific style to apply; may also return null.</returns>
    [MethodImpl]
    public extern Style SelectStyle(object item, DependencyObject container);

    [MethodImpl]
    extern Style IStyleSelectorOverrides.SelectStyleCore(
      object item,
      DependencyObject container);
  }
}
