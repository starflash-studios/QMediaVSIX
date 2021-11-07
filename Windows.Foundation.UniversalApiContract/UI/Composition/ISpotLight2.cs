// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpotLight2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (SpotLight))]
  [Guid(1693344094, 1670, 19946, 169, 232, 188, 58, 140, 112, 20, 89)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface ISpotLight2
  {
    float InnerConeIntensity { get; set; }

    float OuterConeIntensity { get; set; }
  }
}
