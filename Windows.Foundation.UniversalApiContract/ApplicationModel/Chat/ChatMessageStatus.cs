// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies the current status of a chat message such as draft, sent, or received.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatMessageStatus
  {
    /// <summary>Draft</summary>
    Draft,
    /// <summary>Sending</summary>
    Sending,
    /// <summary>Sent</summary>
    Sent,
    /// <summary>Send retry needed</summary>
    SendRetryNeeded,
    /// <summary>Send failed</summary>
    SendFailed,
    /// <summary>Received</summary>
    Received,
    /// <summary>Received download needed</summary>
    ReceiveDownloadNeeded,
    /// <summary>Receive download failed</summary>
    ReceiveDownloadFailed,
    /// <summary>Receive downloading</summary>
    ReceiveDownloading,
    /// <summary>Deleted</summary>
    Deleted,
    /// <summary>Declined</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Declined,
    /// <summary>Cancelled</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Cancelled,
    /// <summary>Recalled</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Recalled,
    /// <summary>Receive retry needed</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ReceiveRetryNeeded,
  }
}
