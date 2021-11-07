// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.AdaptiveTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents a declarative rule that applies visual states based on window properties.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IAdaptiveTriggerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAdaptiveTriggerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class AdaptiveTrigger : StateTriggerBase, IAdaptiveTrigger
  {
    /// <summary>Initializes a new instance of the AdaptiveTrigger class</summary>
    [MethodImpl]
    public extern AdaptiveTrigger();

    /// <summary>Gets or sets the minimum window width at which the VisualState should be applied.</summary>
    /// <returns>The minimum window width (in effective pixels) at which the VisualState should be applied.</returns>
    public extern double MinWindowWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum window height at which the VisualState should be applied.</summary>
    /// <returns>The minimum window height (in effective pixels) at which the VisualState should be applied.</returns>
    public extern double MinWindowHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the MinWindowWidth dependency property.</summary>
    /// <returns>The identifier for the MinWindowWidth dependency property.</returns>
    public static extern DependencyProperty MinWindowWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinWindowHeight dependency property.</summary>
    /// <returns>The identifier for the MinWindowHeight dependency property.</returns>
    public static extern DependencyProperty MinWindowHeightProperty { [MethodImpl] get; }
  }
}
