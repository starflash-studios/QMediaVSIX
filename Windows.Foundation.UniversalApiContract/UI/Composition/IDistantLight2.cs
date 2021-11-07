// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDistantLight2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (DistantLight))]
  [Guid(3687688732, 10571, 18647, 182, 14, 118, 223, 100, 170, 57, 43)]
  internal interface IDistantLight2
  {
    float Intensity { get; set; }
  }
}
