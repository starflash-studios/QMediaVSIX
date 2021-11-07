// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IFindAppointmentsOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FindAppointmentsOptions))]
  [Guid(1442307157, 39234, 12422, 130, 181, 44, 178, 159, 100, 213, 245)]
  internal interface IFindAppointmentsOptions
  {
    IVector<string> CalendarIds { get; }

    IVector<string> FetchProperties { get; }

    bool IncludeHidden { get; set; }

    uint MaxCount { get; set; }
  }
}
