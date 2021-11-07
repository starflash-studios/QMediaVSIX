// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStoreChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Provides APIs for managing change tracking for appointments.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentStoreChangeTracker : 
    IAppointmentStoreChangeTracker,
    IAppointmentStoreChangeTracker2
  {
    /// <summary>Retrieves an AppointmentStoreChangeReader that enables the app to iterate through the list of changes and mark changes as accepted.</summary>
    /// <returns>The returned change reader.</returns>
    [MethodImpl]
    public extern AppointmentStoreChangeReader GetChangeReader();

    /// <summary>Enables change tracking for the appointment store.</summary>
    [MethodImpl]
    public extern void Enable();

    /// <summary>Resets change tracking for the appointment store, deleting existing change tracking data.</summary>
    [MethodImpl]
    public extern void Reset();

    /// <summary>Gets a Boolean value indicating whether change tracking is active.</summary>
    /// <returns>A Boolean value indicating whether change tracking is active.</returns>
    public extern bool IsTracking { [MethodImpl] get; }
  }
}
