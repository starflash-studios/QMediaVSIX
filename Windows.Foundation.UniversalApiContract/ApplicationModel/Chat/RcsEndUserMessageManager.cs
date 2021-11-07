﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsEndUserMessageManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides functionality for handling message events.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RcsEndUserMessageManager : IRcsEndUserMessageManager
  {
    /// <summary>Occurs when a new message is available.</summary>
    public extern event TypedEventHandler<RcsEndUserMessageManager, RcsEndUserMessageAvailableEventArgs> MessageAvailableChanged;
  }
}