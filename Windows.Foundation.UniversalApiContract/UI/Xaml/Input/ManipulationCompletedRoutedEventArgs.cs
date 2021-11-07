// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs
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
  /// <summary>Provides data for the ManipulationCompleted event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ManipulationCompletedRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationCompletedRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the ManipulationCompletedRoutedEventArgs class.</summary>
    [MethodImpl]
    public extern ManipulationCompletedRoutedEventArgs();

    /// <summary>Gets the UIElement that is considered the container of the manipulation.</summary>
    /// <returns>The UIElement that is considered the container of the manipulation.</returns>
    public extern UIElement Container { [MethodImpl] get; }

    /// <summary>Gets the x- and y- screen coordinates of the touch input at completed position.</summary>
    /// <returns>The x- and y- screen coordinates of the touch input at completed position.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets whether the ManipulationCompleted event occurs during inertia.</summary>
    /// <returns>**true** if the ManipulationCompleted event occurs during inertia; **false** if the event occurs while the user's input device has contact with the element.</returns>
    public extern bool IsInertial { [MethodImpl] get; }

    /// <summary>Gets the overall changes since the beginning of the manipulation.</summary>
    /// <returns>The overall changes since the beginning of the manipulation.</returns>
    public extern ManipulationDelta Cumulative { [MethodImpl] get; }

    /// <summary>Gets the velocities that are used for the manipulation.</summary>
    /// <returns>The velocities that are used for the manipulation.</returns>
    public extern ManipulationVelocities Velocities { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. Setting to **true** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled; **false** to leave the routed event unhandled, which permits the event to potentially route further. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the PointerDeviceType for the pointer device involved in the manipulation.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }
  }
}
