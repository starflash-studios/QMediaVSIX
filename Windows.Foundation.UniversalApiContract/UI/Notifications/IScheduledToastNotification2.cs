﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotification2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2792267932, 12724, 17328, 181, 221, 122, 64, 232, 83, 99, 177)]
  internal interface IScheduledToastNotification2
  {
    string Tag { set; get; }

    string Group { set; get; }

    bool SuppressPopup { set; get; }
  }
}