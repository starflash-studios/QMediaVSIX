// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccAppsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Reports results of a call to MobileBroadbandUicc.GetUiccAppsAsync.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandUiccAppsResult : IMobileBroadbandUiccAppsResult
  {
    /// <summary>Gets the status of the completed MobileBroadbandUicc.GetUiccAppsAsync operation. If this value is not **Success**, then other properties may not be valid.</summary>
    /// <returns>The enumeration value that describes the status of the operation.</returns>
    public extern MobileBroadbandUiccAppOperationStatus Status { [MethodImpl] get; }

    /// <summary>A list of UICC applications retrieved using MobileBroadbandUicc.GetUiccAppsAsync. Note that this is only valid when *Status* is **Success**.</summary>
    /// <returns>A list of the UICC applications.</returns>
    public extern IVectorView<MobileBroadbandUiccApp> UiccApps { [MethodImpl] get; }
  }
}
