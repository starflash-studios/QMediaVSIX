// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotificationManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2041272310, 17406, 18555, 138, 127, 153, 86, 114, 0, 174, 148)]
  internal interface IToastNotificationManagerForUser
  {
    [Overload("CreateToastNotifier")]
    ToastNotifier CreateToastNotifier();

    [Overload("CreateToastNotifierWithId")]
    ToastNotifier CreateToastNotifier(string applicationId);

    ToastNotificationHistory History { get; }

    User User { get; }
  }
}
