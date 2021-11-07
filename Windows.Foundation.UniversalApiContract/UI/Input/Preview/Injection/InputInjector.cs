// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InputInjector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Represents the virtual input device for sending the input data.</summary>
  [Static(typeof (IInputInjectorStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IInputInjectorStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class InputInjector : IInputInjector, IInputInjector2
  {
    [MethodImpl]
    public extern void InjectKeyboardInput(IIterable<InjectedInputKeyboardInfo> input);

    [MethodImpl]
    public extern void InjectMouseInput(IIterable<InjectedInputMouseInfo> input);

    /// <summary>Initializes a virtual touch device that can synthesize input events and provide corresponding input data to the system.</summary>
    /// <param name="visualMode">The type of visual feedback displayed for touch input injection.</param>
    [MethodImpl]
    public extern void InitializeTouchInjection(InjectedInputVisualizationMode visualMode);

    [MethodImpl]
    public extern void InjectTouchInput(IIterable<InjectedInputTouchInfo> input);

    /// <summary>Shuts down the virtual touch device created with InitializeTouchInjection.</summary>
    [MethodImpl]
    public extern void UninitializeTouchInjection();

    /// <summary>Initializes a virtual pen device that can synthesize input events and provide corresponding input data to the system.</summary>
    /// <param name="visualMode">The visual feedback mode for pen input injection.</param>
    [MethodImpl]
    public extern void InitializePenInjection(InjectedInputVisualizationMode visualMode);

    /// <summary>Sends programmatically generated pen input to the system.</summary>
    /// <param name="input">The pen input specified by InjectedInputPenInfo.</param>
    [MethodImpl]
    public extern void InjectPenInput(InjectedInputPenInfo input);

    /// <summary>Shuts down the virtual pen device created with InitializePenInjection.</summary>
    [MethodImpl]
    public extern void UninitializePenInjection();

    /// <summary>Sends programmatically generated system shortcuts to the system.</summary>
    /// <param name="shortcut">The system shortcuts.</param>
    [MethodImpl]
    public extern void InjectShortcut(InjectedInputShortcut shortcut);

    /// <summary>Initializes a virtual gamepad device that can synthesize input events and provide corresponding input data to the system.</summary>
    [MethodImpl]
    public extern void InitializeGamepadInjection();

    /// <summary>Sends programmatically generated gamepad input to the system.</summary>
    /// <param name="input">The gamepad input specified by InjectedInputGamepadInfo.</param>
    [MethodImpl]
    public extern void InjectGamepadInput(InjectedInputGamepadInfo input);

    /// <summary>Shuts down the virtual gamepad device created with InitializeGamepadInjection.</summary>
    [MethodImpl]
    public extern void UninitializeGamepadInjection();

    /// <summary>Attempts to create a new instance of the InputInjector class.</summary>
    /// <returns>If successful, returns a new instance of the InputInjector class. Otherwise, returns null.</returns>
    [MethodImpl]
    public static extern InputInjector TryCreateForAppBroadcastOnly();

    /// <summary>Attempts to create a new instance of the InputInjector class.</summary>
    /// <returns>If successful, returns a new instance of the InputInjector class. Otherwise, returns null.</returns>
    [MethodImpl]
    public static extern InputInjector TryCreate();
  }
}
