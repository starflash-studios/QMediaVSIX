﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.UserNotificationChangedKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the type of user notification change that occurred.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum UserNotificationChangedKind
  {
    /// <summary>The user notification was added.</summary>
    Added,
    /// <summary>The user notification was removed.</summary>
    Removed,
  }
}