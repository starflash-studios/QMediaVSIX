// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarSyncManagerSyncRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentCalendarSyncManagerSyncRequestEventArgs))]
  [Guid(3390555895, 644, 20189, 135, 186, 77, 143, 105, 220, 245, 192)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarSyncManagerSyncRequestEventArgs
  {
    AppointmentCalendarSyncManagerSyncRequest Request { get; }

    Deferral GetDeferral();
  }
}
