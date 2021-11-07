// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SplitCloseThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents the preconfigured animation that conceals a target UI using a *split* animation.</summary>
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISplitCloseThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SplitCloseThemeAnimation : Timeline, ISplitCloseThemeAnimation
  {
    /// <summary>Initializes a new instance of the SplitCloseThemeAnimation class.</summary>
    [MethodImpl]
    public extern SplitCloseThemeAnimation();

    /// <summary>Gets or sets the identifying name of the UI element that will be clipped.</summary>
    /// <returns>The reference name. This is typically the **x:Name** of the relevant element as declared in XAML.</returns>
    public extern string OpenedTargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the UI element that will be clipped.</summary>
    /// <returns>The UI element that will be clipped.</returns>
    public extern DependencyObject OpenedTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifying name of the UI element that specifies the initial clip size.</summary>
    /// <returns>The reference name. This is typically the **x:Name** of the relevant element as declared in XAML.</returns>
    public extern string ClosedTargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the UI element that specifies the initial clip size.</summary>
    /// <returns>The UI element that specifies the initial clip size.</returns>
    public extern DependencyObject ClosedTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifying name of the UI element that will be translated. Typically this is a child/part of the element identified by OpenedTargetName.</summary>
    /// <returns>The name of the UI element that will be translated.</returns>
    public extern string ContentTargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the UI element that will be translated. Typically this is a child/part of the element identified by OpenedTargetName or OpenedTarget.</summary>
    /// <returns>The UI element that will be translated.</returns>
    public extern DependencyObject ContentTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the final size of the target UI element.</summary>
    /// <returns>The final size. If left unset, the value defaults to the size of the opened target.</returns>
    public extern double OpenedLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the initial size of the target element in the animation direction.</summary>
    /// <returns>The initial size of the target in pixels.</returns>
    public extern double ClosedLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an offset from the center of the *opened* target.</summary>
    /// <returns>An offset in pixels. The default is 0.</returns>
    public extern double OffsetFromCenter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines which direction the content should translate when the animation runs.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern AnimationDirection ContentTranslationDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the pixels to translate by when the animation runs.</summary>
    /// <returns>A distance in pixels.</returns>
    public extern double ContentTranslationOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the OpenedTargetName dependency property.</summary>
    /// <returns>The identifier for the OpenedTargetName dependency property.</returns>
    public static extern DependencyProperty OpenedTargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the OpenedTarget dependency property.</summary>
    /// <returns>The identifier for the OpenedTarget dependency property.</returns>
    public static extern DependencyProperty OpenedTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ClosedTargetName dependency property.</summary>
    /// <returns>The identifier for the ClosedTargetName dependency property.</returns>
    public static extern DependencyProperty ClosedTargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the ClosedTarget dependency property.</summary>
    /// <returns>The identifier for the ClosedTarget dependency property.</returns>
    public static extern DependencyProperty ClosedTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTargetName dependency property.</summary>
    /// <returns>The identifier for the ContentTargetName dependency property.</returns>
    public static extern DependencyProperty ContentTargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTarget dependency property.</summary>
    /// <returns>The identifier for the ContentTarget dependency property.</returns>
    public static extern DependencyProperty ContentTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the OpenedLength dependency property.</summary>
    /// <returns>The identifier for the OpenedLength dependency property.</returns>
    public static extern DependencyProperty OpenedLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ClosedLength dependency property.</summary>
    /// <returns>The identifier for the ClosedLength dependency property.</returns>
    public static extern DependencyProperty ClosedLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the OffsetFromCenter dependency property.</summary>
    /// <returns>The identifier for the OffsetFromCenter dependency property.</returns>
    public static extern DependencyProperty OffsetFromCenterProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTranslationDirection dependency property.</summary>
    /// <returns>The identifier for the ContentTranslationDirection dependency property.</returns>
    public static extern DependencyProperty ContentTranslationDirectionProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTranslationOffset dependency property.</summary>
    /// <returns>The identifier for the ContentTranslationOffset dependency property.</returns>
    public static extern DependencyProperty ContentTranslationOffsetProperty { [MethodImpl] get; }
  }
}
