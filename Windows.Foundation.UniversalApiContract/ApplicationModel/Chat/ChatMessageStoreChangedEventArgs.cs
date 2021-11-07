// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides the data for the ChatMessageStoreChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageStoreChangedEventArgs : IChatMessageStoreChangedEventArgs
  {
    /// <summary>Gets the ID of the object that changed.</summary>
    /// <returns>The ID of the object that changed.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the type of change that happened.</summary>
    /// <returns>The type of change that happened.</returns>
    public extern ChatStoreChangedEventKind Kind { [MethodImpl] get; }
  }
}
