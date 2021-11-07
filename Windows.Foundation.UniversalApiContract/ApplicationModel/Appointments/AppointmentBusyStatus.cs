// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentBusyStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the busy status for a participant of an appointment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentBusyStatus
  {
    /// <summary>The participant is busy and so can't attend the appointment.</summary>
    Busy,
    /// <summary>The participant might be able to attend the appointment.</summary>
    Tentative,
    /// <summary>The participant is free and so can attend the appointment.</summary>
    Free,
    /// <summary>The participant is out of office.</summary>
    OutOfOffice,
    /// <summary>The participant is working elsewhere.</summary>
    WorkingElsewhere,
  }
}
