// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsidePanorama
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreetsidePanorama))]
  [Guid(1876955096, 44384, 18020, 181, 57, 177, 6, 159, 22, 197, 175)]
  internal interface IStreetsidePanorama
  {
    Geopoint Location { get; }
  }
}
