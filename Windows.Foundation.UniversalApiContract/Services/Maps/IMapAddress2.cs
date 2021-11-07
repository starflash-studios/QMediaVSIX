// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapAddress2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(1976397297, 58797, 17833, 191, 64, 108, 242, 86, 193, 221, 19)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapAddress))]
  [WebHostHidden]
  internal interface IMapAddress2
  {
    string FormattedAddress { get; }
  }
}
