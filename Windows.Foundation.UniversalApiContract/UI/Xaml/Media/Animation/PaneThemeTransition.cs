// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PaneThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior for a panel UI transition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPaneThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaneThemeTransition : Transition, IPaneThemeTransition
  {
    /// <summary>Initializes a new instance of the PaneThemeTransition class.</summary>
    [MethodImpl]
    public extern PaneThemeTransition();

    /// <summary>Gets or sets the edge position to use for the transition.</summary>
    /// <returns>A value of the enumeration. The default is **Left**.</returns>
    public extern EdgeTransitionLocation Edge { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Edge dependency property.</summary>
    /// <returns>The identifier for the Edge dependency property.</returns>
    public static extern DependencyProperty EdgeProperty { [MethodImpl] get; }
  }
}
