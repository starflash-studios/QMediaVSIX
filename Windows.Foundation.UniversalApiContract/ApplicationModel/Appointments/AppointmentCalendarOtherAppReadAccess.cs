// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentCalendarOtherAppReadAccess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the level of read access provided to an app calendar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentCalendarOtherAppReadAccess
  {
    /// <summary>Only the operating system can read data from the app calendar.</summary>
    SystemOnly,
    /// <summary>Other apps on the device can read the Subject, StartTime, Duration, AllDay, LocalId properties of appointments in the calendar and the LocalId property of the calendar</summary>
    Limited,
    /// <summary>Other apps on the device can read all properties of appointments in the calendar.</summary>
    Full,
    /// <summary>Other apps on the device cannot read any properties of appointments in the calendar.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] None,
  }
}
