// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraRenderingParameters3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicCameraRenderingParameters))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2980729151, 4973, 19206, 185, 212, 228, 185, 20, 205, 6, 131)]
  internal interface IHolographicCameraRenderingParameters3 : 
    IHolographicCameraRenderingParameters2,
    IHolographicCameraRenderingParameters
  {
    bool IsContentProtectionEnabled { get; set; }
  }
}
