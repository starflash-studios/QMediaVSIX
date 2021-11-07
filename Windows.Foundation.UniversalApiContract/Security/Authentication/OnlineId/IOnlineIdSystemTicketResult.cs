// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemTicketResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (OnlineIdSystemTicketResult))]
  [Guid(3674890232, 45208, 19149, 157, 19, 158, 100, 6, 82, 181, 182)]
  internal interface IOnlineIdSystemTicketResult
  {
    OnlineIdSystemIdentity Identity { get; }

    OnlineIdSystemTicketStatus Status { get; }

    HResult ExtendedError { get; }
  }
}
