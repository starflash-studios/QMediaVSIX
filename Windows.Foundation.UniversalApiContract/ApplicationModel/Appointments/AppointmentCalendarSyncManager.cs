// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentCalendarSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Provides access to sync functionality for an AppointmentCalendar object.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentCalendarSyncManager : 
    IAppointmentCalendarSyncManager,
    IAppointmentCalendarSyncManager2
  {
    /// <summary>Gets or sets the current status of the AppointmentCalendarSyncManager.</summary>
    /// <returns>The current status of the AppointmentCalendarSyncManager.</returns>
    public extern AppointmentCalendarSyncStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last date and time that a sync with the AppointmentCalendar server was successful.</summary>
    /// <returns>The last date and time that a sync with the AppointmentCalendar server was successful.</returns>
    public extern DateTime LastSuccessfulSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last date and time that a sync with the AppointmentCalendar server was attempted.</summary>
    /// <returns>The last date and time that a sync with the AppointmentCalendar server was attempted.</returns>
    public extern DateTime LastAttemptedSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Initiates a sync operation on the AppointmentCalendar.</summary>
    /// <returns>A Boolean value indicating if the sync was successfully initiated.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SyncAsync();

    /// <summary>Occurs when the status of an AppointmentCalendar sync operation changes.</summary>
    public extern event TypedEventHandler<AppointmentCalendarSyncManager, object> SyncStatusChanged;
  }
}
