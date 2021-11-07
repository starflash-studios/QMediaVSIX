// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraViewportParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Graphics.Holographic
{
  [ExclusiveTo(typeof (HolographicCameraViewportParameters))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2160980983, 33834, 16865, 147, 237, 86, 146, 171, 31, 187, 16)]
  internal interface IHolographicCameraViewportParameters
  {
    Vector2[] HiddenAreaMesh { get; }

    Vector2[] VisibleAreaMesh { get; }
  }
}
