// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.IRemoveAppointmentOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  [ExclusiveTo(typeof (RemoveAppointmentOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(146172602, 65075, 18125, 165, 12, 168, 255, 179, 38, 5, 55)]
  internal interface IRemoveAppointmentOperation
  {
    string AppointmentId { get; }

    IReference<DateTime> InstanceStartDate { get; }

    string SourcePackageFamilyName { get; }

    void ReportCompleted();

    void ReportCanceled();

    void ReportError(string value);

    void DismissUI();
  }
}
