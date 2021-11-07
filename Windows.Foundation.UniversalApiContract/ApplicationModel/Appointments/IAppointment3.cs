// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointment3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3217835433, 35169, 18833, 147, 75, 196, 135, 104, 229, 169, 108)]
  [ExclusiveTo(typeof (Appointment))]
  internal interface IAppointment3 : IAppointment2, IAppointment
  {
    ulong ChangeNumber { get; }

    ulong RemoteChangeNumber { get; set; }

    AppointmentDetailsKind DetailsKind { get; set; }
  }
}
