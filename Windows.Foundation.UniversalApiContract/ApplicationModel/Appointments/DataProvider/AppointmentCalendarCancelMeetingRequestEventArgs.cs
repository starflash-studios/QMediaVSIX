// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCancelMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Provides data for a CancelMeetingRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppointmentCalendarCancelMeetingRequestEventArgs : 
    IAppointmentCalendarCancelMeetingRequestEventArgs
  {
    /// <summary>Gets the AppointmentCalendarCancelMeetingRequest object for the corresponding CancelMeetingRequested event.</summary>
    /// <returns>The AppointmentCalendarCancelMeetingRequest object for the event.</returns>
    public extern AppointmentCalendarCancelMeetingRequest Request { [MethodImpl] get; }

    /// <summary>Gets the deferral object for the CancelMeetingRequested event.</summary>
    /// <returns>The deferral object for the CancelMeetingRequested event.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
