// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarForwardMeetingRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Provides data for a ForwardMeetingRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppointmentCalendarForwardMeetingRequestEventArgs : 
    IAppointmentCalendarForwardMeetingRequestEventArgs
  {
    /// <summary>Gets the AppointmentCalendarForwardMeetingRequest object for the corresponding ForwardMeetingRequested event.</summary>
    /// <returns>The ForwardMeetingRequest object for the event.</returns>
    public extern AppointmentCalendarForwardMeetingRequest Request { [MethodImpl] get; }

    /// <summary>Gets the deferral object for the ForwardMeetingRequested event.</summary>
    /// <returns>The deferral object for the ForwardMeetingRequested event.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
