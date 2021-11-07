// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ManipulationStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains event data for the ManipulationStarted event.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ManipulationStartedEventArgs : 
    IManipulationStartedEventArgs,
    IManipulationStartedEventArgs2
  {
    /// <summary>Gets the device type of the input source.</summary>
    /// <returns>The device type.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets the location of the pointer associated with the manipulation for the last manipulation event.</summary>
    /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets values that indicate the accumulated transformation deltas (translation, rotation, scale) for a manipulation before the ManipulationStarted event.</summary>
    /// <returns>The accumulated transformation values up to the ManipulationStarted event.</returns>
    public extern ManipulationDelta Cumulative { [MethodImpl] get; }

    /// <summary>Gets the number of contact points at the time the ManipulationStarted event is recognized.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint ContactCount { [MethodImpl] get; }
  }
}
