// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentDataProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentDataProviderTriggerDetails))]
  [Guid(3005758465, 32274, 20062, 177, 239, 116, 251, 104, 172, 111, 42)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentDataProviderTriggerDetails
  {
    AppointmentDataProviderConnection Connection { get; }
  }
}
