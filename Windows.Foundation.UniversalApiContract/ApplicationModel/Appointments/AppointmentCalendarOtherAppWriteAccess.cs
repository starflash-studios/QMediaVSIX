// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentCalendarOtherAppWriteAccess
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the level of write access provided to an app calendar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentCalendarOtherAppWriteAccess
  {
    /// <summary>Only the app that created the calendar can write to it.</summary>
    None,
    /// <summary>The operating system can write to the calendar.</summary>
    SystemOnly,
    /// <summary>Other apps on the device can perform any write-level actions that use a DataProviderConnection.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Limited,
  }
}
