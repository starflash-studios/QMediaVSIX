// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a mobile broadband device service.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandDeviceService : IMobileBroadbandDeviceService
  {
    /// <summary>Gets the unique device service identity for the mobile broadband device service.</summary>
    /// <returns>The unique Device Service identity for the Mobile Broadband device service.</returns>
    public extern Guid DeviceServiceId { [MethodImpl] get; }

    /// <summary>Gets a list of supported device service commands for the mobile broadband device service.</summary>
    /// <returns>A list of supported device service commands for the mobile broadband device service.</returns>
    public extern IVectorView<uint> SupportedCommands { [MethodImpl] get; }

    /// <summary>Opens a new MobileBroadbandDeviceServiceDataSession for the mobile broadband device service.</summary>
    /// <returns>A new data session for the Mobile Broadband device service.</returns>
    [MethodImpl]
    public extern MobileBroadbandDeviceServiceDataSession OpenDataSession();

    /// <summary>Opens a new MobileBroadbandDeviceServiceCommandSession for the mobile broadband device service.</summary>
    /// <returns>A new command session for the mobile broadband device service.</returns>
    [MethodImpl]
    public extern MobileBroadbandDeviceServiceCommandSession OpenCommandSession();
  }
}
