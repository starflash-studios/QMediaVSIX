// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides the data for a MessageAvailableChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RcsEndUserMessageAvailableEventArgs : IRcsEndUserMessageAvailableEventArgs
  {
    /// <summary>Gets a Boolean value indicating if a new message is available.</summary>
    /// <returns>A Boolean value indicating if a new message is available.</returns>
    public extern bool IsMessageAvailable { [MethodImpl] get; }

    /// <summary>Gets the actual message to display, or empty if IsMessageAvailable is FALSE.</summary>
    /// <returns>The actual message to display.</returns>
    public extern RcsEndUserMessage Message { [MethodImpl] get; }
  }
}
