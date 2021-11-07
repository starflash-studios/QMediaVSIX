// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpotLight3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SpotLight))]
  [Guid(3838852842, 4895, 18446, 133, 158, 184, 39, 5, 183, 67, 96)]
  internal interface ISpotLight3
  {
    float MinAttenuationCutoff { get; set; }

    float MaxAttenuationCutoff { get; set; }
  }
}
