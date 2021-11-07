// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsFilterActionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Values that describe the action to be taken on a message filter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsFilterActionType
  {
    /// <summary>The first action type to be taken. Messages filtered on this action type are delivered to your application and are not delivered to the messaging application to be shown to the user. Note that if multiple applications register the same filter with this action type, each application gets its own copy of the message.</summary>
    AcceptImmediately,
    /// <summary>Filters with this action type are applied after **AcceptImmediately** filters. Messages filtered on this action type are dropped, and neither your app nor the messaging app receive the message or any notification that a message arrived and was dropped.</summary>
    Drop,
    /// <summary>Filters with this action type are applied after **Drop** filters. This action type allows your application to inspect each message, and decide which are dropped and which continue on to be processed or shown to the user.</summary>
    Peek,
    /// <summary>Filters with this action type are applied after **Peek** filters. Messages filtered on this action type are delivered to your app. A copy of the message can also be delivered to the messaging application to be shown to the user if appropriate. Note that if multiple applications register the same filter with this action type, each application gets its own copy of the message.</summary>
    Accept,
  }
}
