// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.MouseCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Supports the ability to determine the capabilities of any connected mouse devices.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MouseCapabilities : IMouseCapabilities
  {
    /// <summary>Initializes a new instance of the MouseCapabilities class.</summary>
    [MethodImpl]
    public extern MouseCapabilities();

    /// <summary>Gets a value that indicates whether a mouse device is detected.</summary>
    /// <returns>The number of mouse devices detected. Typically 0 or 1.</returns>
    public extern int MousePresent { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether any of the mice connected to the computer have a scroll wheel that rolls up and down (usually for vertical scrolling).</summary>
    /// <returns>The number of vertical wheels detected. Typically 0 or 1.</returns>
    public extern int VerticalWheelPresent { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether any of the mice connected to the computer have a scroll wheel that tilts left and right (usually for horizontal scrolling).</summary>
    /// <returns>The number of horizontal wheels detected. Typically 0 or 1.</returns>
    public extern int HorizontalWheelPresent { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether any of the mice connected to the computer has swapped left and right buttons.</summary>
    /// <returns>A value indicating whether any of the mice connected to the computer has swapped left and right buttons.</returns>
    public extern int SwapButtons { [MethodImpl] get; }

    /// <summary>Gets a value representing the number of buttons on the mouse. If multiple mice are present, it returns the number of buttons of the mouse which has maximum number of buttons.</summary>
    /// <returns>A value representing the number of buttons on the mouse. If multiple mice are present, it returns the number of buttons of the mouse which has maximum number of buttons.</returns>
    public extern uint NumberOfButtons { [MethodImpl] get; }
  }
}
