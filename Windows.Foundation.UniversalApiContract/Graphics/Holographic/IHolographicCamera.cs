// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCamera
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [Guid(3840508997, 39917, 18816, 155, 160, 232, 118, 128, 209, 203, 116)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (HolographicCamera))]
  internal interface IHolographicCamera
  {
    Size RenderTargetSize { get; }

    double ViewportScaleFactor { get; set; }

    bool IsStereo { get; }

    uint Id { get; }

    void SetNearPlaneDistance(double value);

    void SetFarPlaneDistance(double value);
  }
}
