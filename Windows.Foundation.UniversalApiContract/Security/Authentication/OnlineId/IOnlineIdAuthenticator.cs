// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdAuthenticator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OnlineIdAuthenticator))]
  [Guid(2684614026, 10667, 18455, 184, 132, 215, 81, 109, 173, 24, 185)]
  internal interface IOnlineIdAuthenticator
  {
    [Overload("AuthenticateUserAsync")]
    UserAuthenticationOperation AuthenticateUserAsync(
      OnlineIdServiceTicketRequest request);

    [Overload("AuthenticateUserAsyncAdvanced")]
    UserAuthenticationOperation AuthenticateUserAsync(
      IIterable<OnlineIdServiceTicketRequest> requests,
      CredentialPromptType credentialPromptType);

    SignOutUserOperation SignOutUserAsync();

    Guid ApplicationId { set; get; }

    bool CanSignOut { get; }

    string AuthenticatedSafeCustomerId { get; }
  }
}
