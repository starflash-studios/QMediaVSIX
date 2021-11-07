// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentRecurrence3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2315228889, 55885, 18967, 141, 210, 28, 235, 194, 181, 255, 157)]
  [ExclusiveTo(typeof (AppointmentRecurrence))]
  internal interface IAppointmentRecurrence3 : IAppointmentRecurrence2, IAppointmentRecurrence
  {
    string CalendarIdentifier { get; }
  }
}
