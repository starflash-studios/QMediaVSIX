// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.SignOutUserOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Allows users to sign out of your app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SignOutUserOperation : IAsyncAction, IAsyncInfo
  {
    /// <summary>Gets or sets a handler that is called when the operation completes.</summary>
    /// <returns>A method or function that is called when the operation completes.</returns>
    public extern AsyncActionCompletedHandler Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns the results of the operation. For this class, there are no results to return if the operation succeeds.</summary>
    [MethodImpl]
    public extern void GetResults();

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
