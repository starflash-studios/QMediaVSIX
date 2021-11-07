// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ContentThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior for when the content of a control is changing. This might be applied in addition to AddDeleteThemeTransition.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContentThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContentThemeTransition : Transition, IContentThemeTransition
  {
    /// <summary>Initializes a new instance of the ContentThemeTransition class.</summary>
    [MethodImpl]
    public extern ContentThemeTransition();

    /// <summary>Gets or sets the distance by which the target is translated in the horizontal direction when the transition is active.</summary>
    /// <returns>The horizontal offset translation, in pixels.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance by which the target is translated in the vertical direction when the transition is active.</summary>
    /// <returns>The vertical offset translation, in pixels.</returns>
    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the HorizontalOffset dependency property.</summary>
    /// <returns>The identifier for the HorizontalOffset dependency property.</returns>
    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalOffset dependency property.</summary>
    /// <returns>The identifier for the VerticalOffset dependency property.</returns>
    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }
  }
}
