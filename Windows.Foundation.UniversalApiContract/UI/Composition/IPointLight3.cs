// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IPointLight3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PointLight))]
  [Guid(1275757415, 54505, 18058, 135, 174, 123, 164, 58, 178, 148, 133)]
  internal interface IPointLight3
  {
    float MinAttenuationCutoff { get; set; }

    float MaxAttenuationCutoff { get; set; }
  }
}
