// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdServiceTicket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Contains the ticket that is obtained after the user authenticates to this app or has provided consent to access user data stored in Live.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class OnlineIdServiceTicket : IOnlineIdServiceTicket
  {
    /// <summary>The ticket.</summary>
    /// <returns>A string that represents the ticket.</returns>
    public extern string Value { [MethodImpl] get; }

    /// <summary>Represents the OnlineIdServiceTicketRequest for which the ticket was obtained.</summary>
    /// <returns>Provides the ability for an app to specify the service and policy that is used to authenticate a Live user to obtain identity properties and tickets.</returns>
    public extern OnlineIdServiceTicketRequest Request { [MethodImpl] get; }

    /// <summary>If there was an error in obtaining the ticket, then the error code is captured here.</summary>
    /// <returns>The error code number.</returns>
    public extern int ErrorCode { [MethodImpl] get; }
  }
}
