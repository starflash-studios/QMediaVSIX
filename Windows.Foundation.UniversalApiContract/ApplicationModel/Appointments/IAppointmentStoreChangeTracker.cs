﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStoreChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentStoreChangeTracker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(455472305, 36558, 20247, 147, 200, 230, 65, 36, 88, 253, 92)]
  internal interface IAppointmentStoreChangeTracker
  {
    AppointmentStoreChangeReader GetChangeReader();

    void Enable();

    void Reset();
  }
}