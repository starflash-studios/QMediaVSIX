// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the result of a mobile broadband device service command.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandDeviceServiceCommandResult : 
    IMobileBroadbandDeviceServiceCommandResult
  {
    /// <summary>Gets the status code of the command execution on a mobile broadband device service.</summary>
    /// <returns>The status code of the command execution on a mobile broadband device service.</returns>
    public extern uint StatusCode { [MethodImpl] get; }

    /// <summary>Gets the response data from the command execution on a mobile broadband device service.</summary>
    /// <returns>The response data from the command execution on a mobile broadband device service.</returns>
    public extern IBuffer ResponseData { [MethodImpl] get; }
  }
}
