// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs
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
  /// <summary>Provides data for the ManipulationInertiaStarting event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ManipulationInertiaStartingRoutedEventArgs : 
    RoutedEventArgs,
    IManipulationInertiaStartingRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the ManipulationInertiaStartingRoutedEventArgs class.</summary>
    [MethodImpl]
    public extern ManipulationInertiaStartingRoutedEventArgs();

    /// <summary>Gets the UIElement that is considered the container of the manipulation.</summary>
    /// <returns>The UIElement that is considered the container of the manipulation.</returns>
    public extern UIElement Container { [MethodImpl] get; }

    /// <summary>Get or sets the rate of slowdown of expansion inertial movement.</summary>
    /// <returns>The rate of slowdown of expansion inertial movement</returns>
    public extern InertiaExpansionBehavior ExpansionBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets information about the rotation information associated with the manipulation for this event occurrence.</summary>
    /// <returns>Manipulation rotation information.</returns>
    public extern InertiaRotationBehavior RotationBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets information about the translation information associated with the manipulation for this event occurrence.</summary>
    /// <returns>Manipulation translation information.</returns>
    public extern InertiaTranslationBehavior TranslationBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the PointerDeviceType for the pointer device involved in the manipulation.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets the most recent changes of the current manipulation, as a ManipulationDelta.</summary>
    /// <returns>The most recent changes of the current manipulation.</returns>
    public extern ManipulationDelta Delta { [MethodImpl] get; }

    /// <summary>Gets the overall changes since the beginning of the manipulation.</summary>
    /// <returns>The overall changes since the beginning of the manipulation.</returns>
    public extern ManipulationDelta Cumulative { [MethodImpl] get; }

    /// <summary>Gets the rates of the most recent changes to the manipulation.</summary>
    /// <returns>The rates of the most recent changes to the manipulation.</returns>
    public extern ManipulationVelocities Velocities { [MethodImpl] get; }
  }
}
