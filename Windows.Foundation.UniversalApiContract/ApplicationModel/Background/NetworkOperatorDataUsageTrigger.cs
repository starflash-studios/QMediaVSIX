// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.NetworkOperatorDataUsageTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task when the local data counters estimate that usage (bytes sent and received) on the mobile broadband interface has changed by an actionable threshold.</summary>
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class NetworkOperatorDataUsageTrigger : IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of a mobile network operator data usage trigger.</summary>
    [MethodImpl]
    public extern NetworkOperatorDataUsageTrigger();
  }
}
