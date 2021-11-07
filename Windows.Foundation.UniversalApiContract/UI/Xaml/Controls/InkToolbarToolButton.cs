// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarToolButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a base class for all built-in and custom buttons on an InkToolbar.</summary>
  [Static(typeof (IInkToolbarToolButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarToolButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public class InkToolbarToolButton : RadioButton, IInkToolbarToolButton
  {
    /// <summary>Gets the type of built-in or custom tool associated with the InkToolbarToolButton.</summary>
    /// <returns>The type of tool.</returns>
    public extern InkToolbarTool ToolKind { [MethodImpl] get; }

    /// <summary>Gets or sets whether a glyph is shown on the InkToolbarToolButton to indicate the presence of an ink stroke configuration flyout.</summary>
    /// <returns>**true** if the glyph is shown; otherwise, **false**.</returns>
    public extern bool IsExtensionGlyphShown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsExtensionGlyphShown dependency property.</summary>
    /// <returns>The identifier for the IsExtensionGlyphShown dependency property.</returns>
    public static extern DependencyProperty IsExtensionGlyphShownProperty { [MethodImpl] get; }
  }
}
