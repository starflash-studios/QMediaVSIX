// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.FindAppointmentsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Represents a set of options that modifies a query for appointments.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FindAppointmentsOptions : IFindAppointmentsOptions
  {
    /// <summary>Creates a new instance of the FindAppointmentsOptions class.</summary>
    [MethodImpl]
    public extern FindAppointmentsOptions();

    /// <summary>Gets the list of calendar IDs that will be included in the find appointments query. If this list is empty, then appointments will be returned from all calendars.</summary>
    /// <returns>A list of calendar IDs.</returns>
    public extern IVector<string> CalendarIds { [MethodImpl] get; }

    /// <summary>Gets the list of appointment property names that will be populated with data in the find appointment query results.</summary>
    /// <returns>A list of appointment property names.</returns>
    public extern IVector<string> FetchProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether appointments belonging to hidden calendars will be included in the find appointments query result.</summary>
    /// <returns>A value indicating whether appointments belonging to hidden calendars will be included in the find appointments query result.</returns>
    public extern bool IncludeHidden { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of appointments that should be included in the find appointments query result.</summary>
    /// <returns>The maximum number of appointments that should be included in the find appointments query result.</returns>
    public extern uint MaxCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
