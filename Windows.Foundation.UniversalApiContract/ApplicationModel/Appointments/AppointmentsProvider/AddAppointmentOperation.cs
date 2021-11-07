// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.AddAppointmentOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  /// <summary>Represents the operation object associated with adding a new appointment. Appointments provider apps use this info to perform the operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AddAppointmentOperation : IAddAppointmentOperation
  {
    /// <summary>Gets the Appointment info from the activation request.</summary>
    /// <returns>An instance of the Appointment class that represents the specific info for the appointment to add.</returns>
    public extern Appointment AppointmentInformation { [MethodImpl] get; }

    /// <summary>Gets the package family name of the app that is requesting the operation.</summary>
    /// <returns>The package family name.</returns>
    public extern string SourcePackageFamilyName { [MethodImpl] get; }

    /// <summary>Call this method to inform the activating app that the operation was completed successfully. Provide a unique appointment ID as the *itemID* parameter.</summary>
    /// <param name="itemId">A unique appointment ID that the activating app can later use to remove this appointment if necessary.</param>
    [MethodImpl]
    public extern void ReportCompleted(string itemId);

    /// <summary>Call this method to inform the activating app that the operation was canceled by the user.</summary>
    [MethodImpl]
    public extern void ReportCanceled();

    /// <summary>Informs the activating app that the operation couldn't be completed because of a provider error.</summary>
    /// <param name="value">A string that contains info about the error.</param>
    [MethodImpl]
    public extern void ReportError(string value);

    /// <summary>Dismisses the UI for the operation that adds a new appointment.</summary>
    [MethodImpl]
    public extern void DismissUI();
  }
}
