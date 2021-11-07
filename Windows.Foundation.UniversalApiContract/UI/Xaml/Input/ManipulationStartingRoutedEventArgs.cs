// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides data for the ManipulationStarting, event.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ManipulationStartingRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationStartingRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the ManipulationStartingRoutedEventArgs class.</summary>
    [MethodImpl]
    public extern ManipulationStartingRoutedEventArgs();

    /// <summary>Gets or sets which types of manipulations are possible.</summary>
    /// <returns>One of the enumeration values. The default is **All**.</returns>
    public extern ManipulationModes Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the UIElement that is considered the container of the manipulation.</summary>
    /// <returns>The UIElement that is considered the container of the manipulation.</returns>
    public extern UIElement Container { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object that describes the pivot for a single-point manipulation.</summary>
    /// <returns>An object that describes the pivot for a single-point manipulation.</returns>
    public extern ManipulationPivot Pivot { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that marks the routed event as handled. Setting to **true** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled; **false** to leave the routed event unhandled, which permits the event to potentially route further. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
