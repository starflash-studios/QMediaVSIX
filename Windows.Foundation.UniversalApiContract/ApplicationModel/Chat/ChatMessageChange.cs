// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents a revision to a chat message.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageChange : IChatMessageChange
  {
    /// <summary>Gets the type of change made to a chat message, such as created, modified, etc.</summary>
    /// <returns>The type of change represented by the object.</returns>
    public extern ChatMessageChangeType ChangeType { [MethodImpl] get; }

    /// <summary>Gets the updated message text.</summary>
    /// <returns>The chat message associated with the change.</returns>
    public extern ChatMessage Message { [MethodImpl] get; }
  }
}
