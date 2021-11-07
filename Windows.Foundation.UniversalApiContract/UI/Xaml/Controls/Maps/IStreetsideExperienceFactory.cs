// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsideExperienceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (StreetsideExperience))]
  [Guid(2052837180, 25758, 17218, 153, 149, 104, 166, 207, 89, 97, 167)]
  internal interface IStreetsideExperienceFactory
  {
    StreetsideExperience CreateInstanceWithPanorama(StreetsidePanorama panorama);

    StreetsideExperience CreateInstanceWithPanoramaHeadingPitchAndFieldOfView(
      StreetsidePanorama panorama,
      double headingInDegrees,
      double pitchInDegrees,
      double fieldOfViewInDegrees);
  }
}
