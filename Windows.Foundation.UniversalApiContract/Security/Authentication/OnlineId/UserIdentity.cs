// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.UserIdentity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Contains the ID, tickets, and other information associated with a user.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UserIdentity : IUserIdentity
  {
    /// <summary>Contains an array of tickets that identify the user. If your app uses the JWT policy, only one ticket is returned. This value is only available to Microsoft application partners.</summary>
    /// <returns>An array of tickets that identify the user.</returns>
    public extern IVectorView<OnlineIdServiceTicket> Tickets { [MethodImpl] get; }

    /// <summary>Gets the user's unique Microsoft account identifier. This value is available only to Microsoft application partners.</summary>
    /// <returns>The user's unique Microsoft account identifier.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets an obfuscated customer ID specific to the calling application. This ID allows your application to identify the user across sessions but cannot be used to share data between separate applications since each application will receive a distinct SafeCustomerId value for the same Microsoft account.</summary>
    /// <returns>An obfuscated customer ID specific to the calling application.</returns>
    public extern string SafeCustomerId { [MethodImpl] get; }

    /// <summary>The sign in name of the user. This value is available only to Microsoft application partners.</summary>
    /// <returns>The name of the user.</returns>
    public extern string SignInName { [MethodImpl] get; }

    /// <summary>Contains the first name of the user. This value is available only to Microsoft application partners.</summary>
    /// <returns>The user's first name.</returns>
    public extern string FirstName { [MethodImpl] get; }

    /// <summary>Contains the user's last name. This value is available only to Microsoft application partners.</summary>
    /// <returns>The user's last name.</returns>
    public extern string LastName { [MethodImpl] get; }

    /// <summary>Indicates if the user is part of a beta program. This value is available only to Microsoft application partners.</summary>
    /// <returns>True if the user is part of a beta program; false otherwise.</returns>
    public extern bool IsBetaAccount { [MethodImpl] get; }

    /// <summary>Indicates if the user is on a PC that they have confirmed as their PC. This value is available only to Microsoft application partners.</summary>
    /// <returns>True if the user is on a confirmed PC; false otherwise.</returns>
    public extern bool IsConfirmedPC { [MethodImpl] get; }
  }
}
