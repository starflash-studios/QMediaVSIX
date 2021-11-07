// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentPropertiesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentProperties))]
  [Guid(3757851467, 45079, 17885, 138, 245, 209, 99, 209, 8, 1, 187)]
  internal interface IAppointmentPropertiesStatics2 : IAppointmentPropertiesStatics
  {
    string ChangeNumber { get; }

    string RemoteChangeNumber { get; }

    string DetailsKind { get; }
  }
}
