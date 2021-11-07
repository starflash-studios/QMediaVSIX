// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides methods to enable and retrieve message change revisions.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageChangeTracker : IChatMessageChangeTracker
  {
    /// <summary>Enables change tracking for the messages in the message store.</summary>
    [MethodImpl]
    public extern void Enable();

    /// <summary>Returns a ChatMessageChangeReader class object which provides a collection of message revisions from the message store.</summary>
    /// <returns>The change reader associated with the change tracker.</returns>
    [MethodImpl]
    public extern ChatMessageChangeReader GetChangeReader();

    /// <summary>Resets change tracking for the messages in the message store. The first revision begins with the next message change.</summary>
    [MethodImpl]
    public extern void Reset();
  }
}
