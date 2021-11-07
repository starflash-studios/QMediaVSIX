// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentDaysOfWeek
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the days of the week on which an appointment occurs.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentDaysOfWeek : uint
  {
    /// <summary>The appointment doesn't occur on any days of the week.</summary>
    None = 0,
    /// <summary>The appointment occurs on Sunday.</summary>
    Sunday = 1,
    /// <summary>The appointment occurs on Monday.</summary>
    Monday = 2,
    /// <summary>The appointment occurs on Tuesday.</summary>
    Tuesday = 4,
    /// <summary>The appointment occurs on Wednesday.</summary>
    Wednesday = 8,
    /// <summary>The appointment occurs on Thursday.</summary>
    Thursday = 16, // 0x00000010
    /// <summary>The appointment occurs on Friday.</summary>
    Friday = 32, // 0x00000020
    /// <summary>The appointment occurs on Saturday.</summary>
    Saturday = 64, // 0x00000040
  }
}
