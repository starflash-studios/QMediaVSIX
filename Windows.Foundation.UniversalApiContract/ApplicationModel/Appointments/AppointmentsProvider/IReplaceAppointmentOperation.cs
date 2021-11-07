// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IReplaceAppointmentOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ReplaceAppointmentOperation))]
  [Guid(4103093659, 40545, 19938, 167, 50, 38, 135, 192, 125, 29, 232)]
  internal interface IReplaceAppointmentOperation
  {
    string AppointmentId { get; }

    Appointment AppointmentInformation { get; }

    IReference<DateTime> InstanceStartDate { get; }

    string SourcePackageFamilyName { get; }

    void ReportCompleted(string itemId);

    void ReportCanceled();

    void ReportError(string value);

    void DismissUI();
  }
}
