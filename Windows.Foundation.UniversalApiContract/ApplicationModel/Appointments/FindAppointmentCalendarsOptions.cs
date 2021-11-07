// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.FindAppointmentCalendarsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies additional options when querying for appointment calendars.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FindAppointmentCalendarsOptions : uint
  {
    /// <summary>No additional options.</summary>
    None = 0,
    /// <summary>Include appointment calendars that are hidden.</summary>
    IncludeHidden = 1,
  }
}
