﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.NotificationMirroring
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies whether notification mirroring is allowed. Mirroring enables a notification to be displayed on multiple devices.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum NotificationMirroring
  {
    /// <summary>Notification mirroring is allowed.</summary>
    Allowed,
    /// <summary>Notification mirroring is disabled.</summary>
    Disabled,
  }
}