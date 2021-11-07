// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Provides the animated transition behavior for an edge UI transition. </summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IEdgeUIThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EdgeUIThemeTransition : Transition, IEdgeUIThemeTransition
  {
    /// <summary>Initializes a new instance of the EdgeUIThemeTransition class.</summary>
    [MethodImpl]
    public extern EdgeUIThemeTransition();

    /// <summary>Gets or sets the edge position to use for the transition.</summary>
    /// <returns>A value of the enumeration. The default is **Top**.</returns>
    public extern EdgeTransitionLocation Edge { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Edge dependency property.</summary>
    /// <returns>The identifier for the Edge dependency property.</returns>
    public static extern DependencyProperty EdgeProperty { [MethodImpl] get; }
  }
}
