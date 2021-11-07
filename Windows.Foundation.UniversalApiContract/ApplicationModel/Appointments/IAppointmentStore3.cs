// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStore3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentStore))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1112642571, 45176, 18186, 154, 64, 194, 224, 23, 97, 247, 47)]
  internal interface IAppointmentStore3
  {
    AppointmentStoreChangeTracker GetChangeTracker(string identity);
  }
}
