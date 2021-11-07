// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicViewConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Graphics.Holographic
{
  [Guid(1545463526, 26601, 20484, 176, 44, 103, 163, 161, 34, 181, 118)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HolographicViewConfiguration))]
  internal interface IHolographicViewConfiguration
  {
    Size NativeRenderTargetSize { get; }

    Size RenderTargetSize { get; }

    Size RequestRenderTargetSize(Size size);

    IVectorView<DirectXPixelFormat> SupportedPixelFormats { get; }

    DirectXPixelFormat PixelFormat { get; set; }

    bool IsStereo { get; }

    double RefreshRate { get; }

    HolographicViewConfigurationKind Kind { get; }

    HolographicDisplay Display { get; }

    bool IsEnabled { get; set; }
  }
}
