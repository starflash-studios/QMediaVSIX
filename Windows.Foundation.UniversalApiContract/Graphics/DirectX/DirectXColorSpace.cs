// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.DirectXColorSpace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX
{
  /// <summary>This is a Windows Runtime equivalent of the Desktop DXGI_COLOR_SPACE_TYPE enumeration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum DirectXColorSpace
  {
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709**.</summary>
    RgbFullG22NoneP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709**.</summary>
    RgbFullG10NoneP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709**.</summary>
    RgbStudioG22NoneP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020**.</summary>
    RgbStudioG22NoneP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RESERVED**.</summary>
    Reserved,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601**.</summary>
    YccFullG22NoneP709X601,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601**.</summary>
    YccStudioG22LeftP601,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601**.</summary>
    YccFullG22LeftP601,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709**.</summary>
    YccStudioG22LeftP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709**.</summary>
    YccFullG22LeftP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020**.</summary>
    YccStudioG22LeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020**.</summary>
    YccFullG22LeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020**.</summary>
    RgbFullG2084NoneP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020**.</summary>
    YccStudioG2084LeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020**.</summary>
    RgbStudioG2084NoneP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020**.</summary>
    YccStudioG22TopLeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020**.</summary>
    YccStudioG2084TopLeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020**.</summary>
    RgbFullG22NoneP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020**.</summary>
    YccStudioGHlgTopLeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020**.</summary>
    YccFullGHlgTopLeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709**.</summary>
    RgbStudioG24NoneP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020**.</summary>
    RgbStudioG24NoneP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709**.</summary>
    YccStudioG24LeftP709,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020**.</summary>
    YccStudioG24LeftP2020,
    /// <summary>Corresponds to **DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020**.</summary>
    YccStudioG24TopLeftP2020,
  }
}
