// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.VibrationDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  /// <summary>Provides access to a device that supports vibration notifications only.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IVibrationDeviceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  public sealed class VibrationDevice : IVibrationDevice
  {
    /// <summary>Gets the identifier for the vibration device.</summary>
    /// <returns>The Global Unique Identifier (GUID) used to identify a single input device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a reference to a SimpleHapticsController object to specify haptic feedback behavior.</summary>
    /// <returns>The haptic input device.</returns>
    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }

    /// <summary>Asynchronously retrieves the access status of the vibration device.</summary>
    /// <returns>The VibrationAccessStatus.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<VibrationAccessStatus> RequestAccessAsync();

    /// <summary>Returns the class selection string that you can use to enumerate vibration devices.</summary>
    /// <returns>The class selection string for vibration devices.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously retrieves the vibration device specified.</summary>
    /// <param name="deviceId">The Global Unique Identifier (GUID) used to identify a single input device.</param>
    /// <returns>The VibrationDevice from the specified identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<VibrationDevice> FromIdAsync(
      string deviceId);

    /// <summary>Asynchronously retrieves the default vibration device.</summary>
    /// <returns>The default VibrationDevice.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<VibrationDevice> GetDefaultAsync();

    /// <summary>Asynchronously retrieves all vibration devices detected.</summary>
    /// <returns>The collection of VibrationDevices detected.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<VibrationDevice>> FindAllAsync();
  }
}
