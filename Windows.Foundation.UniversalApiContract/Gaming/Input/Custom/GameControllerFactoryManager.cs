// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GameControllerFactoryManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Manages factories for custom controllers.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IGameControllerFactoryManagerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGameControllerFactoryManagerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class GameControllerFactoryManager
  {
    /// <summary>Tries to get a game controller that belongs to the specified factory and references the same underlying game controller as the one that was specified.</summary>
    /// <param name="factory">The factory for the type of game controller that you want to get.</param>
    /// <param name="gameController">The game controller that references the underlying device for which you want to get another game controller representation.</param>
    /// <returns>If found, a game controller that belongs to the specified factory and references the same underlying device as the specified game controller; otherwise, **null**.</returns>
    [MethodImpl]
    public static extern IGameController TryGetFactoryControllerFromGameController(
      ICustomGameControllerFactory factory,
      IGameController gameController);

    /// <summary>Registers a factory for a custom Gip controller.</summary>
    /// <param name="factory">The factory to register.</param>
    /// <param name="interfaceId">The interface ID of the factory.</param>
    [MethodImpl]
    public static extern void RegisterCustomFactoryForGipInterface(
      ICustomGameControllerFactory factory,
      Guid interfaceId);

    /// <summary>Registers a factory for a custom hardware ID controller.</summary>
    /// <param name="factory">The factory to register.</param>
    /// <param name="hardwareVendorId">The hardware vendor ID.</param>
    /// <param name="hardwareProductId">The hardware product ID.</param>
    [MethodImpl]
    public static extern void RegisterCustomFactoryForHardwareId(
      ICustomGameControllerFactory factory,
      ushort hardwareVendorId,
      ushort hardwareProductId);

    /// <summary>Registers a factory for a Xusb type controller.</summary>
    /// <param name="factory">The factory to register.</param>
    /// <param name="xusbType">The Xusb device type.</param>
    /// <param name="xusbSubtype">The Xusb device subtype.</param>
    [MethodImpl]
    public static extern void RegisterCustomFactoryForXusbType(
      ICustomGameControllerFactory factory,
      XusbDeviceType xusbType,
      XusbDeviceSubtype xusbSubtype);
  }
}
