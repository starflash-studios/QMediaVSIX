// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(2240618158, 62125, 17055, 187, 55, 205, 33, 9, 79, 252, 146)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MapRoute))]
  internal interface IMapRoute3
  {
    TimeSpan DurationWithoutTraffic { get; }

    TrafficCongestion TrafficCongestion { get; }
  }
}
