// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStoreChangeType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the type of change represented by an AppointmentStoreChange object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentStoreChangeType
  {
    /// <summary>An appointment was created.</summary>
    AppointmentCreated,
    /// <summary>An appointment was modified.</summary>
    AppointmentModified,
    /// <summary>An appointment was deleted.</summary>
    AppointmentDeleted,
    /// <summary>The change tracking information associated with the appointment was lost.</summary>
    ChangeTrackingLost,
    /// <summary>A calendar was created.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CalendarCreated,
    /// <summary>A calendar was modified.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CalendarModified,
    /// <summary>A calendar was deleted.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CalendarDeleted,
  }
}
