// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticatorForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Represents the authentication info for a single user entity on a single device (system).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class OnlineIdSystemAuthenticatorForUser : IOnlineIdSystemAuthenticatorForUser
  {
    /// <summary>Attempts to retrieve the system ticket for the device.</summary>
    /// <param name="request">The OnlineIdServiceTicketRequest representing the specifications for authenticating this user account.</param>
    /// <returns>An asynchronous task containing the system ticket result.</returns>
    [RemoteAsync]
    [Overload("GetTicketAsync")]
    [MethodImpl]
    public extern IAsyncOperation<OnlineIdSystemTicketResult> GetTicketAsync(
      OnlineIdServiceTicketRequest request);

    /// <summary>The unique id value of the calling application. Windows desktop applications that are to use the System Ticket feature must set this value explicitly before calling getTicketAsync.</summary>
    /// <returns>The id of the calling application.</returns>
    public extern Guid ApplicationId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the corresponding Windows user for this OnlineIdSystemAuthenticatorForUser.</summary>
    /// <returns>The Windows user for this OnlineIdSystemAuthenticatorForUser.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
