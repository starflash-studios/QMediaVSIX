// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(937682197, 33460, 19796, 143, 217, 175, 38, 36, 179, 1, 28)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapManager))]
  [WebHostHidden]
  internal interface IMapManagerStatics
  {
    void ShowDownloadedMapsUI();

    void ShowMapsUpdateUI();
  }
}
