// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatSyncConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>The chat messages sync configurations.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ChatSyncConfiguration : IChatSyncConfiguration
  {
    /// <summary>Gets or sets a boolean that indicates whether sync is enabled.</summary>
    /// <returns>The boolean that indicates whether sync is enabled.</returns>
    public extern bool IsSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time span for which messages will be restored.</summary>
    /// <returns>The time span for which messages will be restored.</returns>
    public extern ChatRestoreHistorySpan RestoreHistorySpan { [MethodImpl] get; [MethodImpl] set; }
  }
}
