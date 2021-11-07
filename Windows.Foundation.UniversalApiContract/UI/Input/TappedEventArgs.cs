// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.TappedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains event data for the Tapped event.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TappedEventArgs : ITappedEventArgs, ITappedEventArgs2
  {
    /// <summary>Gets the device type of the input source.</summary>
    /// <returns>The device type.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets the location of the touch, mouse, or pen/stylus contact.</summary>
    /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets the number of times the tap interaction was detected.</summary>
    /// <returns>The total number of taps.</returns>
    public extern uint TapCount { [MethodImpl] get; }

    /// <summary>Gets the number of contact points at the time the Tapped event is recognized.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint ContactCount { [MethodImpl] get; }
  }
}
