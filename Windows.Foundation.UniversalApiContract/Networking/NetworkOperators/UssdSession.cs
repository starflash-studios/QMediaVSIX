// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UssdSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a session of the USSD network protocol.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IUssdSessionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class UssdSession : IUssdSession
  {
    /// <summary>Sends a message to a USSD session and returns a handler to retrieve the reply asynchronously.</summary>
    /// <param name="message">The message to send to the USSD session.</param>
    /// <returns>An asynchronous handler to retrieve the USSD response to the sent message.</returns>
    [MethodImpl]
    public extern IAsyncOperation<UssdReply> SendMessageAndGetReplyAsync(
      UssdMessage message);

    /// <summary>Closes the USSD session with the network.</summary>
    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a USSD session for the mobile device associated with the supplied network account ID.</summary>
    /// <param name="networkAccountId">The network account ID to use to select the corresponding mobile broadband device to use for the USSD session.</param>
    /// <returns>The USSD session for the mobile device associated with the supplied network account ID.</returns>
    [MethodImpl]
    public static extern UssdSession CreateFromNetworkAccountId(string networkAccountId);

    /// <summary>Creates a USSD session for the mobile device associated with the supplied network interface ID.</summary>
    /// <param name="networkInterfaceId">The network interface ID to use to select the corresponding mobile broadband device to use for the USSD session.</param>
    /// <returns>The USSD session for the mobile device associated with the supplied network interface ID.</returns>
    [MethodImpl]
    public static extern UssdSession CreateFromNetworkInterfaceId(
      string networkInterfaceId);
  }
}
