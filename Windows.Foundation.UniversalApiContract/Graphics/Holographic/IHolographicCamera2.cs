// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(3042680602, 47756, 20356, 173, 121, 46, 126, 30, 36, 80, 243)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (HolographicCamera))]
  internal interface IHolographicCamera2 : IHolographicCamera
  {
    HolographicCameraViewportParameters LeftViewportParameters { get; }

    HolographicCameraViewportParameters RightViewportParameters { get; }

    HolographicDisplay Display { get; }
  }
}
