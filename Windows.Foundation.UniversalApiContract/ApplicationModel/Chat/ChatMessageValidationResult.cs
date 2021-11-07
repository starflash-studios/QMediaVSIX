// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageValidationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides results for validation of chat messages.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageValidationResult : IChatMessageValidationResult
  {
    /// <summary>Gets the maximum number of text fragments allowed for a message. This value has meaning when the SMS text portion of a message is validated.</summary>
    /// <returns>The maximum number of parts.</returns>
    public extern IReference<uint> MaxPartCount { [MethodImpl] get; }

    /// <summary>Gets the total number of text fragments needed for this message. This value has meaning when the SMS text portion of a message is validated.</summary>
    /// <returns>The number of parts.</returns>
    public extern IReference<uint> PartCount { [MethodImpl] get; }

    /// <summary>Gets the number of characters not used in the final message fragments. This value has meaning when the SMS text portion of a message is validated.</summary>
    /// <returns>The remaining characters in the part.</returns>
    public extern IReference<uint> RemainingCharacterCountInPart { [MethodImpl] get; }

    /// <summary>Gets the message validation status code.</summary>
    /// <returns>The status of the validation.</returns>
    public extern ChatMessageValidationStatus Status { [MethodImpl] get; }
  }
}
