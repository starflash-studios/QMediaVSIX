// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.IUserNotificationListenerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserNotificationListener))]
  [Guid(4284556239, 17286, 19107, 183, 61, 184, 4, 229, 182, 59, 35)]
  internal interface IUserNotificationListenerStatics
  {
    UserNotificationListener Current { get; }
  }
}
