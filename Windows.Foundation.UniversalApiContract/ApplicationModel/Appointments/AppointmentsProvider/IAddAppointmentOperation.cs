// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IAddAppointmentOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [Guid(3964312307, 25101, 19561, 173, 215, 151, 148, 233, 24, 8, 31)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AddAppointmentOperation))]
  internal interface IAddAppointmentOperation
  {
    Appointment AppointmentInformation { get; }

    string SourcePackageFamilyName { get; }

    void ReportCompleted(string itemId);

    void ReportCanceled();

    void ReportError(string value);

    void DismissUI();
  }
}
