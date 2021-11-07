// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorDataUsageTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides details about the data usage change that activated a NetworkOperatorDataUsageTrigger.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class NetworkOperatorDataUsageTriggerDetails : 
    INetworkOperatorDataUsageTriggerDetails
  {
    /// <summary>Gets details about the kind of data usage change that activated a mobile network operator data usage trigger.</summary>
    /// <returns>
    /// </returns>
    public extern NetworkOperatorDataUsageNotificationKind NotificationKind { [MethodImpl] get; }
  }
}
