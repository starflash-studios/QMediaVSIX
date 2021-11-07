// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ChatMessageNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that is activated when there is a notification for a text message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatMessageNotificationTrigger : 
    IBackgroundTrigger,
    IChatMessageNotificationTrigger
  {
    /// <summary>Represents a trigger that is activated when there is a notification for a text message.</summary>
    [MethodImpl]
    public extern ChatMessageNotificationTrigger();
  }
}
