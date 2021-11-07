// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteLeg2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(48367149, 51654, 17848, 142, 84, 26, 16, 181, 122, 23, 232)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRouteLeg))]
  internal interface IMapRouteLeg2
  {
    TimeSpan DurationWithoutTraffic { get; }

    TrafficCongestion TrafficCongestion { get; }
  }
}
