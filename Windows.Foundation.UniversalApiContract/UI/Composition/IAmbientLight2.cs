// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IAmbientLight2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AmbientLight))]
  [Guid(996452031, 24471, 19604, 134, 229, 4, 45, 211, 134, 178, 125)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAmbientLight2
  {
    float Intensity { get; set; }
  }
}
