// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.HyperlinkButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a button control that functions as a hyperlink.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IHyperlinkButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IHyperlinkButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class HyperlinkButton : ButtonBase, IHyperlinkButton
  {
    /// <summary>Initializes a new instance of the HyperlinkButton class.</summary>
    [MethodImpl]
    public extern HyperlinkButton();

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) to navigate to when the HyperlinkButton is clicked.</summary>
    /// <returns>The Uniform Resource Identifier (URI) to navigate to when the HyperlinkButton is clicked.</returns>
    public extern Uri NavigateUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the NavigateUri dependency property.</summary>
    /// <returns>The identifier for the NavigateUri dependency property.</returns>
    public static extern DependencyProperty NavigateUriProperty { [MethodImpl] get; }
  }
}
