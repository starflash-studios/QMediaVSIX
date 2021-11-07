// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains information about a mobile broadband device service.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandDeviceServiceInformation : 
    IMobileBroadbandDeviceServiceInformation
  {
    /// <summary>Gets the unique device service identifier for the mobile broadband device.</summary>
    /// <returns>The unique device service identifier for the mobile broadband device.</returns>
    public extern Guid DeviceServiceId { [MethodImpl] get; }

    /// <summary>Determines if the mobile broadband device service is able to read data.</summary>
    /// <returns>If the mobile broadband device service is able to read data.</returns>
    public extern bool IsDataReadSupported { [MethodImpl] get; }

    /// <summary>Determines if the mobile broadband device service is able to write data.</summary>
    /// <returns>If the mobile broadband device service is able to write data.</returns>
    public extern bool IsDataWriteSupported { [MethodImpl] get; }
  }
}
