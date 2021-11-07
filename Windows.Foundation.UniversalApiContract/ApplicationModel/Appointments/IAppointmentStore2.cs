// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(633637920, 7233, 16975, 128, 132, 103, 193, 207, 224, 168, 84)]
  [ExclusiveTo(typeof (AppointmentStore))]
  internal interface IAppointmentStore2 : IAppointmentStore
  {
    event TypedEventHandler<AppointmentStore, AppointmentStoreChangedEventArgs> StoreChanged;

    [RemoteAsync]
    [Overload("CreateAppointmentCalendarInAccountAsync")]
    IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name,
      string userDataAccountId);
  }
}
