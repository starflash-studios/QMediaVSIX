// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStoreAccessType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the level of access granted to an AppointmentStore.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentStoreAccessType
  {
    /// <summary>The appointment store has read and write access to appointment calendars created by the calling app.</summary>
    AppCalendarsReadWrite,
    /// <summary>The appointment store has read-only access to all calendars on the device.</summary>
    AllCalendarsReadOnly,
    /// <summary>The appointment store has read and write access to all calendars created by the calling app.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AllCalendarsReadWrite,
  }
}
