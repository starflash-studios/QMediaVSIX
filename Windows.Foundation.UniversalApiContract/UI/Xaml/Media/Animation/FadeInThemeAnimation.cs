// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.FadeInThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents the preconfigured opacity animation that applies to controls when they are first shown.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFadeInThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FadeInThemeAnimation : Timeline, IFadeInThemeAnimation
  {
    /// <summary>Initializes a new instance of the FadeInThemeAnimation class.</summary>
    [MethodImpl]
    public extern FadeInThemeAnimation();

    /// <summary>Gets or sets the reference name of the control element being targeted.</summary>
    /// <returns>The reference name. This is typically the **x:Name** of the relevant element as declared in XAML.</returns>
    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TargetName dependency property.</summary>
    /// <returns>The identifier for the TargetName dependency property.</returns>
    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }
  }
}
