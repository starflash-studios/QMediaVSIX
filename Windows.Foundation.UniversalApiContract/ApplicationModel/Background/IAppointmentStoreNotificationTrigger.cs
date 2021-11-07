// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IAppointmentStoreNotificationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1691616268, 49665, 17069, 170, 42, 226, 27, 163, 66, 91, 109)]
  [ExclusiveTo(typeof (AppointmentStoreNotificationTrigger))]
  internal interface IAppointmentStoreNotificationTrigger : IBackgroundTrigger
  {
  }
}
