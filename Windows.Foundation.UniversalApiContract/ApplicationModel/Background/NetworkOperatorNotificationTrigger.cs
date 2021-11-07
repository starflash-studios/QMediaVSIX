// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.NetworkOperatorNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a mobile network operator notification trigger.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (INetworkOperatorNotificationTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class NetworkOperatorNotificationTrigger : 
    INetworkOperatorNotificationTrigger,
    IBackgroundTrigger
  {
    /// <summary>Initializes a new instance of a mobile network operator notification.</summary>
    /// <param name="networkAccountId">Specifies the unique identifier of the mobile broadband account.</param>
    [MethodImpl]
    public extern NetworkOperatorNotificationTrigger(string networkAccountId);

    /// <summary>Gets the account identifier for the mobile network operator notification trigger.</summary>
    /// <returns>A unique identifier for the mobile broadband account.</returns>
    public extern string NetworkAccountId { [MethodImpl] get; }
  }
}
