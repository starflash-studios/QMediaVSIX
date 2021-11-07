// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Provides an app with the ability to start the authentication request to get JavaScript Object Notation (JSON) tokens to use with your service or request tickets that can be used to get data that the user has consented to for your app using the Live ConnectAPI.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class OnlineIdAuthenticator : IOnlineIdAuthenticator
  {
    /// <summary>Creates an instance of the OnlineIdAuthenticator.</summary>
    [MethodImpl]
    public extern OnlineIdAuthenticator();

    /// <summary>Starts the asynchronous authentication request with one OnlineIdServiceTicketRequest by showing the credential prompt if needed to collect credentials or consent and get the ticket. If a user is signed into a Windows 8 system with a Microsoft account, this user will be used for the authentication request.</summary>
    /// <param name="request">A request object that provides the ability for an app to specify the service and policy used to authenticate a Live user to obtain identity properties and tickets.</param>
    /// <returns>An object representing the authentication operation.</returns>
    [Overload("AuthenticateUserAsync")]
    [MethodImpl]
    public extern UserAuthenticationOperation AuthenticateUserAsync(
      OnlineIdServiceTicketRequest request);

    [Overload("AuthenticateUserAsyncAdvanced")]
    [MethodImpl]
    public extern UserAuthenticationOperation AuthenticateUserAsync(
      IIterable<OnlineIdServiceTicketRequest> requests,
      CredentialPromptType credentialPromptType);

    /// <summary>Allows users to sign out of your app.</summary>
    /// <returns>An object that contains additional information about the why the user signed out.</returns>
    [MethodImpl]
    public extern SignOutUserOperation SignOutUserAsync();

    /// <summary>Returns the ID of the application as a GUID.</summary>
    /// <returns>The ID of the application.</returns>
    public extern Guid ApplicationId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates whether a user can sign out of the app, and whether to show the sign out link in the app.</summary>
    /// <returns>**True** if the user can sign out and the sign out link should be shown in the app, otherwise **false**.</returns>
    public extern bool CanSignOut { [MethodImpl] get; }

    /// <summary>Returns the ID of a user who has been successfully authenticated for your app.</summary>
    /// <returns>The ID of a user who has been successfully authenticated for your app.</returns>
    public extern string AuthenticatedSafeCustomerId { [MethodImpl] get; }
  }
}
