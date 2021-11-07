// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGameController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Gaming.Input
{
  /// <summary>The core interface required to be implemented by all controller devices, regardless of their actual type (gamepad, racing wheel, flight stick, and so on). This interface exists mainly to support extensibility for game controllers, which allows OEMs (Original Equipment Manufacturers) to publish WinRT (Windows Runtime) classes that provide rich access to their device's features, while integrating into the underlying game controller device enumeration framework.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(464479522, 24420, 17093, 130, 103, 185, 254, 34, 21, 191, 189)]
  public interface IGameController
  {
    /// <summary>Signals when a headset is attached to the controller.</summary>
    event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    /// <summary>Signals when a headset is disconnected from the controller.</summary>
    event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    /// <summary>Signals when the user associated with the controller has changed.</summary>
    event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    /// <summary>The audio headset attached to the controller.</summary>
    /// <returns>The audio headset attached to the controller.</returns>
    Headset Headset { get; }

    /// <summary>Gets a value that indicates the wireless state of the gamepad.</summary>
    /// <returns>True if the gamepad is wireless. Otherwise, false.</returns>
    bool IsWireless { get; }

    /// <summary>The user associated with the controller.</summary>
    /// <returns>The user associated with the controller.</returns>
    User User { get; }
  }
}
