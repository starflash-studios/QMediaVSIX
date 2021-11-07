// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStoreChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Enables the calling app to read through the changes to appointments in its appointment store.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentStoreChangeReader : IAppointmentStoreChangeReader
  {
    /// <summary>Returns a list of the changes that have occurred in the appointment store that have not yet been accepted by the calling app.</summary>
    /// <returns>An asynchronous operation that returns an IVectorView upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentStoreChange>> ReadBatchAsync();

    /// <summary>Tells the system that all of the changes to appointments returned by the call to ReadBatchAsync have been addressed by the app.</summary>
    [MethodImpl]
    public extern void AcceptChanges();

    /// <summary>Tells the system that all of the changes to appointments returned by the call to ReadBatchAsync, up to the specified AppointmentStoreChange, have been addressed by the app.</summary>
    /// <param name="lastChangeToAccept">The AppointmentStoreChange object indicating the latest change that has been addressed by the app.</param>
    [MethodImpl]
    public extern void AcceptChangesThrough(AppointmentStoreChange lastChangeToAccept);
  }
}
