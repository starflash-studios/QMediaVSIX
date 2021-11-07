// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(913083557, 12371, 20385, 128, 255, 212, 117, 243, 237, 30, 110)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MapRoute))]
  [WebHostHidden]
  internal interface IMapRoute4
  {
    bool IsScenic { get; }
  }
}
