// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicViewConfiguration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [ExclusiveTo(typeof (HolographicViewConfiguration))]
  [Guid(3795940718, 57552, 20505, 154, 245, 27, 22, 91, 194, 245, 78)]
  internal interface IHolographicViewConfiguration2
  {
    IVectorView<HolographicDepthReprojectionMethod> SupportedDepthReprojectionMethods { get; }
  }
}
