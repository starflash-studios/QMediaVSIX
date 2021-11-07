// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicketRequestFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(3199928840, 40563, 16503, 150, 20, 8, 97, 76, 11, 194, 69)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OnlineIdServiceTicketRequest))]
  internal interface IOnlineIdServiceTicketRequestFactory
  {
    OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequest(
      string service,
      string policy);

    OnlineIdServiceTicketRequest CreateOnlineIdServiceTicketRequestAdvanced(
      string service);
  }
}
