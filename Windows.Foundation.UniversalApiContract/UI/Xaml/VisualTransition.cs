// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the visual behavior that occurs when the control transitions from one visual state to another.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContentProperty(Name = "Storyboard")]
  [Composable(typeof (IVisualTransitionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class VisualTransition : DependencyObject, IVisualTransition
  {
    /// <summary>Initializes a new instance of the VisualTransition class.</summary>
    [MethodImpl]
    public extern VisualTransition();

    /// <summary>Gets or sets the amount of time it takes to move from one state to another, and the time that any implicit transition animations should run as part of the transition behavior.</summary>
    /// <returns>The amount of time it takes to move from one state to another.</returns>
    public extern Duration GeneratedDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the easing function applied to the generated animations.</summary>
    /// <returns>An easing function implementation that is applied to the generated animations.</returns>
    public extern EasingFunctionBase GeneratedEasingFunction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the VisualState to transition to.</summary>
    /// <returns>The name of the VisualState to transition to.</returns>
    public extern string To { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the VisualState to transition from.</summary>
    /// <returns>The name of the VisualState to transition from.</returns>
    public extern string From { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Storyboard that runs when the transition occurs.</summary>
    /// <returns>The Storyboard that occurs when the transition occurs.</returns>
    public extern Storyboard Storyboard { [MethodImpl] get; [MethodImpl] set; }
  }
}
