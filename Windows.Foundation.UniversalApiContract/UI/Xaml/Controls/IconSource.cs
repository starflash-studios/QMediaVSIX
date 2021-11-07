// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the base class for an icon source.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IIconSourceFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IIconSourceStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public class IconSource : DependencyObject, IIconSource
  {
    /// <summary>Gets or sets a brush that describes the foreground color.</summary>
    /// <returns>The brush that paints the foreground of the control. The default is **null**, (a null brush) which is evaluated as Transparent for rendering. However, this value is typically set by a default system resource at runtime, which is tied to the active theme and other settings.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Foreground dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }
  }
}
