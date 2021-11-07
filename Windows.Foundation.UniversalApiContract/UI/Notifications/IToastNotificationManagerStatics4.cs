// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ToastNotificationManager))]
  [Guid(2409185235, 58646, 17915, 129, 48, 57, 142, 147, 250, 82, 195)]
  internal interface IToastNotificationManagerStatics4
  {
    ToastNotificationManagerForUser GetForUser(User user);

    void ConfigureNotificationMirroring(NotificationMirroring value);
  }
}
