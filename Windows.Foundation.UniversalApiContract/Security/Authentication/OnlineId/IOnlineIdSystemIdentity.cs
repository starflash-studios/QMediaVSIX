// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemIdentity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [Guid(1950142989, 46794, 17229, 129, 36, 83, 234, 18, 104, 83, 7)]
  [ExclusiveTo(typeof (OnlineIdSystemIdentity))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOnlineIdSystemIdentity
  {
    OnlineIdServiceTicket Ticket { get; }

    string Id { get; }
  }
}
