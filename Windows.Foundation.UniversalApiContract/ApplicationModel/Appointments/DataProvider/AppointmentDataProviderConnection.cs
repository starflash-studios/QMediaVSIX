// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  /// <summary>Describes a connection between app and system for relaying calendar appointment information.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppointmentDataProviderConnection : IAppointmentDataProviderConnection
  {
    /// <summary>Raised when the user elects to sync all calendar appointments with the server.</summary>
    public extern event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarSyncManagerSyncRequestEventArgs> SyncRequested;

    /// <summary>Raised when the user elects to create or update a meeting.</summary>
    public extern event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs> CreateOrUpdateAppointmentRequested;

    /// <summary>Raised when the user elects to cancel a meeting.</summary>
    public extern event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarCancelMeetingRequestEventArgs> CancelMeetingRequested;

    /// <summary>Raised when the user elects to forward a meeting.</summary>
    public extern event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarForwardMeetingRequestEventArgs> ForwardMeetingRequested;

    /// <summary>Raised when the user elects to change the time of a meeting.</summary>
    public extern event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested;

    /// <summary>Raised when the user elects to change their response to a proposed meeting.</summary>
    public extern event TypedEventHandler<AppointmentDataProviderConnection, AppointmentCalendarUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested;

    /// <summary>Starts the connection for transfer of data.</summary>
    [MethodImpl]
    public extern void Start();
  }
}
