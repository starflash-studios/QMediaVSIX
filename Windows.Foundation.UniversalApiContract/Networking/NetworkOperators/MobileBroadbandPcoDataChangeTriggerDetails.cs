// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPcoDataChangeTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class providing details about a Protocol Configuration Options (PCO) data change notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandPcoDataChangeTriggerDetails : 
    IMobileBroadbandPcoDataChangeTriggerDetails
  {
    /// <summary>Gets details about a Protocol Configuration Options (PCO) data change notification.</summary>
    /// <returns>Details about the Protocol Configuration Options (PCO) data change notification.</returns>
    public extern MobileBroadbandPco UpdatedData { [MethodImpl] get; }
  }
}
