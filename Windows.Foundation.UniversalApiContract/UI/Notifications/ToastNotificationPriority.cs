// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationPriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the priority of a ToastNotification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum ToastNotificationPriority
  {
    /// <summary>The notification should have default behavior in terms of delivery and display priority during connected standby mode.</summary>
    Default,
    /// <summary>The notification should be treated as high priority. For desktop PCs, this means during connected standby mode the incoming notification can turn on the screen for Surface-like devices if it doesn’t have a closed lid detected.</summary>
    High,
  }
}
