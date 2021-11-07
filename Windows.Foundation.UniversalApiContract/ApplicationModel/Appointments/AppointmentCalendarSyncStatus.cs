// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentCalendarSyncStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the current sync status of an AppointmentCalendar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentCalendarSyncStatus
  {
    /// <summary>There is no sync operation currently occurring.</summary>
    Idle,
    /// <summary>A sync operation is in progress.</summary>
    Syncing,
    /// <summary>The local machine and server are up to date.</summary>
    UpToDate,
    /// <summary>An authentication error occurred when trying to connect to the server.</summary>
    AuthenticationError,
    /// <summary>A policy error occurred.</summary>
    PolicyError,
    /// <summary>An unknown error occurred.</summary>
    UnknownError,
    /// <summary>The account must be manually removed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 131072)] ManualAccountRemovalRequired,
  }
}
