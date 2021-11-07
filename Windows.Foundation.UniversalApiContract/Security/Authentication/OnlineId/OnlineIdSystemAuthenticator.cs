// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdSystemAuthenticator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>This class handles an app's attempts to acquire the local user id on a device, for use with the System Ticket feature (see Remarks).</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IOnlineIdSystemAuthenticatorStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class OnlineIdSystemAuthenticator
  {
    /// <summary>Gets an instance of OnlineIdSystemAuthenticatorForUser that corresponds to the user currently logged in to the device.</summary>
    /// <returns>The OnlineIdSystemAuthenticatorForUser corresponding to the local user.</returns>
    public static extern OnlineIdSystemAuthenticatorForUser Default { [MethodImpl] get; }

    /// <summary>Gets an instance of OnlineIdSystemAuthenticatorForUser that corresponds to the specified user.</summary>
    /// <param name="user">The local Windows user.</param>
    /// <returns>A OnlineIdSystemAuthenticatorForUser corresponding to the user.</returns>
    [MethodImpl]
    public static extern OnlineIdSystemAuthenticatorForUser GetForUser(
      User user);
  }
}
