// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides data for the ManipulationStarted event.</summary>
  [Composable(typeof (IManipulationStartedRoutedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class ManipulationStartedRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationStartedRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the ManipulationStartedRoutedEventArgs class.</summary>
    [MethodImpl]
    public extern ManipulationStartedRoutedEventArgs();

    /// <summary>Gets the UIElement that is considered the container of the manipulation.</summary>
    /// <returns>The UIElement that is considered the container of the manipulation.</returns>
    public extern UIElement Container { [MethodImpl] get; }

    /// <summary>Gets the point from which the manipulation originated.</summary>
    /// <returns>The point from which the manipulation originated.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. Setting to **true** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled; **false** to leave the routed event unhandled, which permits the event to potentially route further. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the PointerDeviceType for the pointer device involved in the manipulation.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets the overall changes since the beginning of the manipulation.</summary>
    /// <returns>The overall changes since the beginning of the manipulation.</returns>
    public extern ManipulationDelta Cumulative { [MethodImpl] get; }

    /// <summary>Completes the manipulation without inertia.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
