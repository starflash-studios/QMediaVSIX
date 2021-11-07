// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarMenuButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar button that invokes a menu of tools, defined by the host app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IInkToolbarMenuButtonStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Composable(typeof (IInkToolbarMenuButtonFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarMenuButton : ToggleButton, IInkToolbarMenuButton
  {
    /// <summary>Gets the type of menu button.</summary>
    /// <returns>The type of menu button.</returns>
    public extern InkToolbarMenuKind MenuKind { [MethodImpl] get; }

    /// <summary>Gets or sets whether an extension glyph is shown on the menu button.</summary>
    /// <returns>**true** if the glyph is shown. Otherwise, **false**.</returns>
    public extern bool IsExtensionGlyphShown { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsExtensionGlyphShown dependency property.</summary>
    /// <returns>The identifier for the IsExtensionGlyphShown dependency property.</returns>
    public static extern DependencyProperty IsExtensionGlyphShownProperty { [MethodImpl] get; }
  }
}
