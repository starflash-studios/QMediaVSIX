// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents the preconfigured animation that applies to potential drop target elements.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDropTargetItemThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DropTargetItemThemeAnimation : Timeline, IDropTargetItemThemeAnimation
  {
    /// <summary>Initializes a new instance of the DropTargetItemThemeAnimation class.</summary>
    [MethodImpl]
    public extern DropTargetItemThemeAnimation();

    /// <summary>Gets or sets the reference name of the control element being targeted.</summary>
    /// <returns>The reference name. This is typically the **x:Name** of the relevant element as declared in XAML.</returns>
    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TargetName dependency property.</summary>
    /// <returns>The identifier for the TargetName dependency property.</returns>
    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }
  }
}
