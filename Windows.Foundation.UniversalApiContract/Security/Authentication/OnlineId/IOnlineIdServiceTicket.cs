// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3378271359, 55169, 19092, 172, 184, 197, 152, 116, 35, 140, 38)]
  [ExclusiveTo(typeof (OnlineIdServiceTicket))]
  internal interface IOnlineIdServiceTicket
  {
    string Value { get; }

    OnlineIdServiceTicketRequest Request { get; }

    int ErrorCode { get; }
  }
}
