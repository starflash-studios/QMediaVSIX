// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccAppReadRecordResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Encapsulates the results of a UICC application record read operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandUiccAppReadRecordResult : 
    IMobileBroadbandUiccAppReadRecordResult
  {
    /// <summary>Gets a value which indicates whether the record read completed successfully.</summary>
    /// <returns>The status of the completed operation.</returns>
    public extern MobileBroadbandUiccAppOperationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the data returned by the application record read operation. Note that if *Status* is not **Success**, this value may be invalid or empty.</summary>
    /// <returns>The data. Format is defined by the UICC application.</returns>
    public extern IBuffer Data { [MethodImpl] get; }
  }
}
