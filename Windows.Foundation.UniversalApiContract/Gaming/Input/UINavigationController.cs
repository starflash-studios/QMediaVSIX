// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.UINavigationController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Gaming.Input
{
  /// <summary>Represents a controller of any type that can be used for UI navigation. Most gamepads, arcade sticks, and racing wheels can also be accessed as a **UINavigationController**. It is recommended that games use the controller-specific class during gameplay and the **UINavigationController** class for UI menus.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IUINavigationControllerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUINavigationControllerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class UINavigationController : 
    IUINavigationController,
    IGameController,
    IGameControllerBatteryInfo
  {
    /// <summary>Gets a snapshot of the UI navigation controller's state.</summary>
    /// <returns>The state of the UI navigation controller.</returns>
    [MethodImpl]
    public extern UINavigationReading GetCurrentReading();

    /// <summary>Retrieves a label for an optional UI navigation button.</summary>
    /// <param name="button">Enumeration indicating the UI navigation button whose label to retrieve.</param>
    /// <returns>The label of the specified button.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetOptionalButtonLabel(
      OptionalUINavigationButtons button);

    /// <summary>Retrieves a label for a required UI navigation button.</summary>
    /// <param name="button">Enumeration indicating the UI navigation button whose label to retrieve.</param>
    /// <returns>The label of the specified button.</returns>
    [MethodImpl]
    public extern GameControllerButtonLabel GetRequiredButtonLabel(
      RequiredUINavigationButtons button);

    /// <summary>Signals when a headset is attached to the UI navigation controller.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the UI navigation controller.</summary>
    public extern event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the UI navigation controller has changed.</summary>
    public extern event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the UI navigation controller.</summary>
    /// <returns>The audio headset attached to the UI navigation controller.</returns>
    public extern Headset Headset { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the wireless state of the UI navigation controller.</summary>
    /// <returns>True if the UI navigation controller is wireless. Otherwise, false.</returns>
    public extern bool IsWireless { [MethodImpl] get; }

    /// <summary>The user associated with the UI navigation controller.</summary>
    /// <returns>The user associated with the UI navigation controller.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets information about the UI navigation controller's current battery state.</summary>
    /// <returns>Information about the UI navigation controller's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();

    /// <summary>Returns the given game controller as a UI navigation controller.</summary>
    /// <param name="gameController">The game controller to be returned as a UI navigation controller.</param>
    /// <returns>The UI navigation controller that was returned from the given game controller.</returns>
    [MethodImpl]
    public static extern UINavigationController FromGameController(
      IGameController gameController);

    /// <summary>Signals when a new UI navigation controller is connected.</summary>
    public static extern event EventHandler<UINavigationController> UINavigationControllerAdded;

    /// <summary>Signals when a UI navigation controller is disconnected.</summary>
    public static extern event EventHandler<UINavigationController> UINavigationControllerRemoved;

    /// <summary>The list of all connected UI navigation controllers.</summary>
    /// <returns>The list of all connected UI navigation controllers.</returns>
    public static extern IVectorView<UINavigationController> UINavigationControllers { [MethodImpl] get; }
  }
}
