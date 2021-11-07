// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.UserAuthenticationOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Asynchronously gets the user's identity and corresponding tickets and properties.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UserAuthenticationOperation : IAsyncOperation<UserIdentity>, IAsyncInfo
  {
    /// <summary>Gets or sets a handler that's called when the operation completes.</summary>
    /// <returns>The method or function that is called when the operation completes.</returns>
    public extern AsyncOperationCompletedHandler<UserIdentity> Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns a UserIdentity object that contains information about the user.</summary>
    /// <returns>An object containing information about the user's identity.</returns>
    [MethodImpl]
    public extern UserIdentity GetResults();

    /// <summary>Gets a unique identifier that represents the operation.</summary>
    /// <returns>The operation's unique ID as defined in the package manifest.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the current status of the operation.</summary>
    /// <returns>One of the enumeration values that indicates the status.</returns>
    public extern AsyncStatus Status { [MethodImpl] get; }

    /// <summary>Gets the error code should the operation fail.</summary>
    /// <returns>The structure that contains the error code.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }

    /// <summary>Requests the cancellation of the operation.</summary>
    [MethodImpl]
    public extern void Cancel();

    /// <summary>Requests that work associated with the operation should terminate.</summary>
    [MethodImpl]
    public extern void Close();
  }
}
