// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(798679196, 45900, 19911, 163, 93, 202, 253, 136, 174, 62, 198)]
  internal interface IAppointmentManagerStatics3
  {
    AppointmentManagerForUser GetForUser(User user);
  }
}
