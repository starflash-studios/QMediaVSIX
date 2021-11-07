// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Gaming.Input;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Represents programmatically generated gamepad input.</summary>
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Activatable(typeof (IInjectedInputGamepadInfoFactory), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class InjectedInputGamepadInfo : IInjectedInputGamepadInfo
  {
    /// <summary>Creates a new InjectedInputGamepadInfo object that is used to specify the gamepad input to inject based on the current state of the gamepad.</summary>
    /// <param name="reading">The current state of the gamepad.</param>
    [MethodImpl]
    public extern InjectedInputGamepadInfo(GamepadReading reading);

    /// <summary>Creates a new InjectedInputGamepadInfo object that is used to specify the gamepad input to inject.</summary>
    [MethodImpl]
    public extern InjectedInputGamepadInfo();

    /// <summary>Gets or sets the gamepad buttons used for input injection.</summary>
    /// <returns>One or more gamepad buttons used for input injection.</returns>
    public extern GamepadButtons Buttons { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the left stick on the X-axis.</summary>
    /// <returns>A value between -1.0 (pressed to the left) and 1.0 (pressed to the right).</returns>
    public extern double LeftThumbstickX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the left stick on the Y-axis.</summary>
    /// <returns>A value between -1.0 (pressed towards the user) and 1.0 (pressed away from the user).</returns>
    public extern double LeftThumbstickY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the left trigger.</summary>
    /// <returns>A value between 0.0 (not depressed) and 1.0 (fully depressed).</returns>
    public extern double LeftTrigger { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the right stick on the X-axis.</summary>
    /// <returns>A value between -1.0 (pressed to the left) and 1.0 (pressed to the right).</returns>
    public extern double RightThumbstickX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the right stick on the Y-axis.</summary>
    /// <returns>A value between -1.0 (pressed towards the user) and 1.0 (pressed away from the user).</returns>
    public extern double RightThumbstickY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position of the right trigger.</summary>
    /// <returns>A value between 0.0 (not depressed) and 1.0 (fully depressed).</returns>
    public extern double RightTrigger { [MethodImpl] get; [MethodImpl] set; }
  }
}
