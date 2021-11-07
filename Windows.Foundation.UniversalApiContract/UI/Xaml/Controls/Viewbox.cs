// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Viewbox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines a content decorator that can stretch and scale a single child to fill the available space.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Child")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IViewboxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class Viewbox : FrameworkElement, IViewbox
  {
    /// <summary>Initializes a new instance of the Viewbox class.</summary>
    [MethodImpl]
    public extern Viewbox();

    /// <summary>Gets or sets the single child element of a Viewbox element.</summary>
    /// <returns>The single child element of a Viewbox element.</returns>
    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Stretch mode, which determines how content fits into the available space.</summary>
    /// <returns>A Stretch mode, which determines how content fits in the available space. The default is **Uniform**.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the StretchDirection, which determines how scaling is applied to the contents of a Viewbox.</summary>
    /// <returns>A StretchDirection, which determines how scaling is applied to the contents of a Viewbox. The default is **Both**.</returns>
    public extern StretchDirection StretchDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the StretchDirection dependency property.</summary>
    /// <returns>The identifier for the StretchDirection dependency property.</returns>
    public static extern DependencyProperty StretchDirectionProperty { [MethodImpl] get; }
  }
}
