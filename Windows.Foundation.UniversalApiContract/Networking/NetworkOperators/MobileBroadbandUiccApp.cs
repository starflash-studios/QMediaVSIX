// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a UICC (SIM card) application.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandUiccApp : IMobileBroadbandUiccApp
  {
    /// <summary>Gets the ID of this UICC application.</summary>
    /// <returns>The ID of the UICC application.</returns>
    public extern IBuffer Id { [MethodImpl] get; }

    /// <summary>Gets what kind of UICC application this instance represents.</summary>
    /// <returns>An enumeration value specifying what kind of UICC application this is.</returns>
    public extern UiccAppKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandUiccAppRecordDetailsResult> GetRecordDetailsAsync(
      IIterable<uint> uiccFilePath);

    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandUiccAppReadRecordResult> ReadRecordAsync(
      IIterable<uint> uiccFilePath,
      int recordIndex);
  }
}
