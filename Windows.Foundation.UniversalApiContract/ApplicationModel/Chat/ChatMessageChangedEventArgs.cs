// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents event parameters used by the event handler that processes message change events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageChangedEventArgs : IChatMessageChangedEventArgs
  {
    /// <summary>The message changed event handler that an application registers with the message store receives a deferral object in the event parameters. The GetDeferral method registers a change deferral and allows an application to take action related to the change before the message store completes the change.</summary>
    /// <returns>Gets a deferral for the MessageChanged event.</returns>
    [MethodImpl]
    public extern ChatMessageChangedDeferral GetDeferral();
  }
}
