﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentConflictResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(3587043518, 12079, 15229, 175, 10, 167, 226, 15, 58, 70, 227)]
  [ExclusiveTo(typeof (AppointmentConflictResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppointmentConflictResult
  {
    AppointmentConflictType Type { get; }

    DateTime Date { get; }
  }
}