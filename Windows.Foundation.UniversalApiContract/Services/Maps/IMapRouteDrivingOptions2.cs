// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteDrivingOptions2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [Guid(903644784, 49816, 18640, 181, 173, 130, 84, 96, 100, 86, 3)]
  [ExclusiveTo(typeof (MapRouteDrivingOptions))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMapRouteDrivingOptions2
  {
    IReference<DateTime> DepartureTime { get; set; }
  }
}
