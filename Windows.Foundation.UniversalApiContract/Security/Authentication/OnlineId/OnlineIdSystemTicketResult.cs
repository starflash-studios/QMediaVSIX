// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdSystemTicketResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Represents the result of a call to retrieve a system ticket.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class OnlineIdSystemTicketResult : IOnlineIdSystemTicketResult
  {
    /// <summary>The OnlineIdSystemIdentity object corresponding to the device whose system ticket was retrieved.</summary>
    /// <returns>The identity of the device.</returns>
    public extern OnlineIdSystemIdentity Identity { [MethodImpl] get; }

    /// <summary>Gets the status of the system ticket call.</summary>
    /// <returns>The status of the system ticket call.</returns>
    public extern OnlineIdSystemTicketStatus Status { [MethodImpl] get; }

    /// <summary>Represents the Windows Runtime error associated with a failed attempt to retrieve the system ticket.</summary>
    /// <returns>The Windows Runtime error code.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
