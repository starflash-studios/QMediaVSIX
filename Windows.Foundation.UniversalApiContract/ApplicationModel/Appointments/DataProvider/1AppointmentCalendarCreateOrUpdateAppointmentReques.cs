// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Provides data for a CreateOrUpdateAppointmentRequested event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs : 
    IAppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs
  {
    /// <summary>Gets the AppointmentCalendarCreateOrUpdateAppointmentRequest object for the corresponding CreateOrUpdateAppointmentRequested event.</summary>
    /// <returns>The AppointmentCalendarCreateOrUpdateAppointmentRequest object for the event.</returns>
    public extern AppointmentCalendarCreateOrUpdateAppointmentRequest Request { [MethodImpl] get; }

    /// <summary>Gets the deferral object for the CreateOrUpdateAppointmentRequested event.</summary>
    /// <returns>The deferral object for the CreateOrUpdateAppointmentRequested event.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
