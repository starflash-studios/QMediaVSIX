// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStoreChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentStoreChangeReader))]
  [Guid(2334394865, 26099, 17056, 150, 29, 76, 32, 155, 243, 3, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppointmentStoreChangeReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentStoreChange>> ReadBatchAsync();

    void AcceptChanges();

    void AcceptChangesThrough(AppointmentStoreChange lastChangeToAccept);
  }
}
