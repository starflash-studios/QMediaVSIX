// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.OnlineId
{
  /// <summary>Provides the ability for an app to specify the service and policy that is used to authenticate a Live user to obtain identity properties and tickets.</summary>
  [Activatable(typeof (IOnlineIdServiceTicketRequestFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OnlineIdServiceTicketRequest : IOnlineIdServiceTicketRequest
  {
    /// <summary>Creates an instance of the OnlineIdServiceTicketRequest class.</summary>
    /// <param name="service">The service for the request.</param>
    /// <param name="policy">The policy for the request.</param>
    [MethodImpl]
    public extern OnlineIdServiceTicketRequest(string service, string policy);

    /// <summary>Creates an instance of the OnlineIdServiceTicketRequest class.</summary>
    /// <param name="service">The service for the request.</param>
    [MethodImpl]
    public extern OnlineIdServiceTicketRequest(string service);

    /// <summary>Identifies the service your app uses. The service name must match the DNS name you supplied when registering your app on http://go.microsoft.com/fwlink/p/?linkid=241860. Tickets are issued only for this service. For apps that are requesting user consent to access stored in Live, you must pass the offers to which your app needs access. The available list of offers can be found at our Scopes and Permissions page. Check out our REST APIs topic to learn more.</summary>
    /// <returns>A string that represents the service.</returns>
    public extern string Service { [MethodImpl] get; }

    /// <summary>The policy used to authenticate users. Supported values are JWT, which returns data using the JSON format. For apps that are requesting user consent to access stored in Live, app developer must pass a policy of DELEGATION.</summary>
    /// <returns>A string that represents the policy.</returns>
    public extern string Policy { [MethodImpl] get; }
  }
}
