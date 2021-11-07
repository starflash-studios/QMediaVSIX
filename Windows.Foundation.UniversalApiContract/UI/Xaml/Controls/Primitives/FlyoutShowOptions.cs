// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.FlyoutShowOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the options used to show a flyout.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Composable(typeof (IFlyoutShowOptionsFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class FlyoutShowOptions : IFlyoutShowOptions
  {
    /// <summary>Initializes a new instance of the FlyoutShowOptions class.</summary>
    [MethodImpl]
    public extern FlyoutShowOptions();

    /// <summary>Gets or sets the position where the flyout opens.</summary>
    /// <returns>The position where the flyout opens.</returns>
    public extern IReference<Point> Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a rectangular area that the flyout tries to not overlap.</summary>
    /// <returns>The rectangular area that the flyout tries to not overlap.</returns>
    public extern IReference<Rect> ExclusionRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the flyout behaves when opened.</summary>
    /// <returns>A value of the enumeration that indicates how the flyout behaves when opened.</returns>
    public extern FlyoutShowMode ShowMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates where the flyout is placed in relation to it's target element.</summary>
    /// <returns>A value of the enumeration that indicates where the flyout is placed in relation to it's target element.</returns>
    public extern FlyoutPlacementMode Placement { [MethodImpl] get; [MethodImpl] set; }
  }
}
