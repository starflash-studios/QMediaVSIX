// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IconElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the base class for an icon UI element.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IIconElementFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IIconElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class IconElement : FrameworkElement, IIconElement
  {
    /// <summary>Gets or sets a brush that describes the foreground color.</summary>
    /// <returns>The brush that paints the foreground of the control. The default is **null**, (a null brush) which is evaluated as Transparent for rendering. However, this value is typically set by a default system resource at runtime, which is tied to the active theme and other settings.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Foreground dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }
  }
}
