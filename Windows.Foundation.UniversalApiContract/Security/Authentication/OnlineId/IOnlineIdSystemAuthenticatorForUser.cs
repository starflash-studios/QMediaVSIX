// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemAuthenticatorForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  [ExclusiveTo(typeof (OnlineIdSystemAuthenticatorForUser))]
  [Guid(1469628155, 7652, 16774, 162, 230, 181, 99, 248, 106, 175, 68)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOnlineIdSystemAuthenticatorForUser
  {
    [Overload("GetTicketAsync")]
    [RemoteAsync]
    IAsyncOperation<OnlineIdSystemTicketResult> GetTicketAsync(
      OnlineIdServiceTicketRequest request);

    Guid ApplicationId { set; get; }

    User User { get; }
  }
}
