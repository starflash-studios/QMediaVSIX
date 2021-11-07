// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUicc
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a Universal Integrated Circuit Card (UICC), normally called a SIM Card on a mobile broadband device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandUicc : IMobileBroadbandUicc
  {
    /// <summary>Gets the unique SIM Card identity on a mobile broadband device.</summary>
    /// <returns>The unique SIM Card identity on a mobile broadband device.</returns>
    public extern string SimIccId { [MethodImpl] get; }

    /// <summary>Asynchronously retrieves a list of mobile broadband UICC (SIM card) applications.</summary>
    /// <returns>An asynchronous retrieval operation. On successful completion, returns an object with the results of the retrieval operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandUiccAppsResult> GetUiccAppsAsync();
  }
}
