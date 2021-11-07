// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.RepositionThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Reacts to layout moves when no context is set and a trigger of *move* is passed.</summary>
  [Static(typeof (IRepositionThemeTransitionStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RepositionThemeTransition : 
    Transition,
    IRepositionThemeTransition,
    IRepositionThemeTransition2
  {
    /// <summary>Initializes a new instance of the RepositionThemeTransition class.</summary>
    [MethodImpl]
    public extern RepositionThemeTransition();

    /// <summary>Gets or sets a value that determines whether the transition staggers rendering of multiple items, or renders all items at once.</summary>
    /// <returns>**true** if the animation staggers rendering of multiple items. **false** if the animation renders all items at once. The default is **true**.</returns>
    public extern bool IsStaggeringEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsStaggeringEnabled dependency property.</summary>
    /// <returns>The identifier for the IsStaggeringEnabled dependency property.</returns>
    public static extern DependencyProperty IsStaggeringEnabledProperty { [MethodImpl] get; }
  }
}
