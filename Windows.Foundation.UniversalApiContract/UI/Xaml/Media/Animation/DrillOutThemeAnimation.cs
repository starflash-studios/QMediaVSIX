// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DrillOutThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents a preconfigured animation that runs when a user navigates backward in a logical hierarchy, like from a detail page to a master page.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDrillOutThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class DrillOutThemeAnimation : Timeline, IDrillOutThemeAnimation
  {
    /// <summary>Initializes a new instance of the DrillOutThemeAnimation class.</summary>
    [MethodImpl]
    public extern DrillOutThemeAnimation();

    /// <summary>Gets or sets the name of the element that is animating into view.</summary>
    /// <returns>The name of the element that is animating into view.</returns>
    public extern string EntranceTargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the element that is animating into view, such as a master page.</summary>
    /// <returns>The element that is animating into view, such as a master page.</returns>
    public extern DependencyObject EntranceTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets of sets the name of the element that is animating out of view.</summary>
    /// <returns>The name of the element that is animating out of view.</returns>
    public extern string ExitTargetName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the element that is animating out of view, such as a detail page.</summary>
    /// <returns>The element that is animating out of view, such as a detail page.</returns>
    public extern DependencyObject ExitTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the EntranceTargetName dependency property.</summary>
    /// <returns>The identifier for the EntranceTargetName dependency property.</returns>
    public static extern DependencyProperty EntranceTargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the EntranceTarget dependency property.</summary>
    /// <returns>The identifier for the EntranceTarget dependency property.</returns>
    public static extern DependencyProperty EntranceTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ExitTargetName dependency property.</summary>
    /// <returns>The identifier for the ExitTargetName dependency property.</returns>
    public static extern DependencyProperty ExitTargetNameProperty { [MethodImpl] get; }

    /// <summary>Identifies the ExitTarget dependency property.</summary>
    /// <returns>The identifier for the ExitTarget dependency property.</returns>
    public static extern DependencyProperty ExitTargetProperty { [MethodImpl] get; }
  }
}
