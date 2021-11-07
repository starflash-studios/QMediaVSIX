// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccAppRecordDetailsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains details about results of a UICC application record read operation initiated with MobileBroadbandUiccAppClass.GetRecordDetailsAsync.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandUiccAppRecordDetailsResult : 
    IMobileBroadbandUiccAppRecordDetailsResult
  {
    /// <summary>Gets the status of the operation to retrieve UICC application record details. If this value is not **Success**, then other properties might not contain valid values.</summary>
    /// <returns>The status value.</returns>
    public extern MobileBroadbandUiccAppOperationStatus Status { [MethodImpl] get; }

    /// <summary>Gets an enumeration value specifying what kind of record this is.</summary>
    /// <returns>The kind of record.</returns>
    public extern UiccAppRecordKind Kind { [MethodImpl] get; }

    /// <summary>Gets the count of this record in the list of records provided by this UICC application.</summary>
    /// <returns>This record's count.</returns>
    public extern int RecordCount { [MethodImpl] get; }

    /// <summary>Gets the size in bytes of this record.</summary>
    /// <returns>Record size, in bytes.</returns>
    public extern int RecordSize { [MethodImpl] get; }

    /// <summary>Gets a value specifying how read access to this record is determined.</summary>
    /// <returns>The enumeration value that describes how read access is determined.</returns>
    public extern UiccAccessCondition ReadAccessCondition { [MethodImpl] get; }

    /// <summary>Gets a value specifying how write access to this record is determined.</summary>
    /// <returns>The enumeration value that describes how write access is determined.</returns>
    public extern UiccAccessCondition WriteAccessCondition { [MethodImpl] get; }
  }
}
