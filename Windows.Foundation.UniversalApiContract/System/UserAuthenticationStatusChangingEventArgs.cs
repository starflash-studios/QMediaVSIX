// Decompiled with JetBrains decompiler
// Type: Windows.System.UserAuthenticationStatusChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides data for a user authentication status changing event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class UserAuthenticationStatusChangingEventArgs : 
    IUserAuthenticationStatusChangingEventArgs
  {
    /// <summary>Requests a delay before the user's authentication status changes.</summary>
    /// <returns>The user authentication status change deferral.</returns>
    [MethodImpl]
    public extern UserAuthenticationStatusChangeDeferral GetDeferral();

    /// <summary>Gets the user.</summary>
    /// <returns>The user.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the user's new authentication status.</summary>
    /// <returns>The user's new authentication status.</returns>
    public extern UserAuthenticationStatus NewStatus { [MethodImpl] get; }

    /// <summary>Gets the user's current authentication status.</summary>
    /// <returns>The user's current authentication status.</returns>
    public extern UserAuthenticationStatus CurrentStatus { [MethodImpl] get; }
  }
}
