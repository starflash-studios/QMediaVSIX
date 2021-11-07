// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UssdMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a USSD message that is used for sending messages to and receiving messages from the network.</summary>
  [Activatable(typeof (IUssdMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UssdMessage : IUssdMessage
  {
    /// <summary>Creates a new instance of a UssdMessage and encodes the supplied string into the message payload.</summary>
    /// <param name="messageText">The payload for the UssdMessage.</param>
    [MethodImpl]
    public extern UssdMessage(string messageText);

    /// <summary>Gets or sets the encoding scheme of the payload of this UssdMessage.</summary>
    /// <returns>The encoding scheme of the payload of this UssdMessage.</returns>
    public extern byte DataCodingScheme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the raw payload of this UssdMessage.</summary>
    /// <returns>The raw payload of this UssdMessage.</returns>
    [MethodImpl]
    public extern byte[] GetPayload();

    /// <summary>Sets the raw payload of this UssdMessage.</summary>
    /// <param name="value">The raw payload of this UssdMessage.</param>
    [MethodImpl]
    public extern void SetPayload([Range(0, 160)] byte[] value);

    /// <summary>Gets or sets the payload of this UssdMessage as text.</summary>
    /// <returns>The payload of this UssdMessage as text.</returns>
    public extern string PayloadAsText { [MethodImpl] get; [MethodImpl] set; }
  }
}
