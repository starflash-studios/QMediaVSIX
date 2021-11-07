// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatRestoreHistorySpan
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Indicates the chat restore history span.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum ChatRestoreHistorySpan
  {
    /// <summary>Only messages from last month will be restored.</summary>
    LastMonth,
    /// <summary>Only messages from last year will be restored.</summary>
    LastYear,
    /// <summary>All messages will be restored.</summary>
    AnyTime,
  }
}
