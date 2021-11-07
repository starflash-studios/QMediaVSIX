// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Specifies the type of change made to a chat message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChatMessageChangeType
  {
    /// <summary>Message created.</summary>
    MessageCreated,
    /// <summary>Message modified.</summary>
    MessageModified,
    /// <summary>Message deleted.</summary>
    MessageDeleted,
    /// <summary>Change tracking lost.</summary>
    ChangeTrackingLost,
  }
}
