// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.DirectXPixelFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX
{
  /// <summary>Specifies pixel formats, which includes fully-typed and type-less formats. This is a Windows Runtime equivalent of the Desktop DXGI_FORMAT enumeration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DirectXPixelFormat
  {
    /// <summary>See DXGI_FORMAT_UNKNOWN.</summary>
    Unknown = 0,
    /// <summary>See DXGI_FORMAT_R32G32B32A32_TYPELESS.</summary>
    R32G32B32A32Typeless = 1,
    /// <summary>See DXGI_FORMAT_R32G32B32A32_FLOAT.</summary>
    R32G32B32A32Float = 2,
    /// <summary>See DXGI_FORMAT_R32G32B32A32_UINT.</summary>
    R32G32B32A32UInt = 3,
    /// <summary>See DXGI_FORMAT_R32G32B32A32_SINT.</summary>
    R32G32B32A32Int = 4,
    /// <summary>See DXGI_FORMAT_R32G32B32_TYPELESS.</summary>
    R32G32B32Typeless = 5,
    /// <summary>See DXGI_FORMAT_R32G32B32_FLOAT.</summary>
    R32G32B32Float = 6,
    /// <summary>See DXGI_FORMAT_R32G32B32_UINT.</summary>
    R32G32B32UInt = 7,
    /// <summary>See DXGI_FORMAT_R32G32B32_SINT.</summary>
    R32G32B32Int = 8,
    /// <summary>See DXGI_FORMAT_R16G16B16A16_TYPELESS.</summary>
    R16G16B16A16Typeless = 9,
    /// <summary>See DXGI_FORMAT_R16G16B16A16_FLOAT.</summary>
    R16G16B16A16Float = 10, // 0x0000000A
    /// <summary>See DXGI_FORMAT_R16G16B16A16_UNORM.</summary>
    R16G16B16A16UIntNormalized = 11, // 0x0000000B
    /// <summary>See DXGI_FORMAT_R16G16B16A16_UINT.</summary>
    R16G16B16A16UInt = 12, // 0x0000000C
    /// <summary>See DXGI_FORMAT_R16G16B16A16_SNORM.</summary>
    R16G16B16A16IntNormalized = 13, // 0x0000000D
    /// <summary>See DXGI_FORMAT_R16G16B16A16_SINT.</summary>
    R16G16B16A16Int = 14, // 0x0000000E
    /// <summary>See DXGI_FORMAT_R32G32_TYPELESS.</summary>
    R32G32Typeless = 15, // 0x0000000F
    /// <summary>See DXGI_FORMAT_R32G32_FLOAT.</summary>
    R32G32Float = 16, // 0x00000010
    /// <summary>See DXGI_FORMAT_R32G32_UINT.</summary>
    R32G32UInt = 17, // 0x00000011
    /// <summary>See DXGI_FORMAT_R32G32_SINT.</summary>
    R32G32Int = 18, // 0x00000012
    /// <summary>See DXGI_FORMAT_R32G8X24_TYPELESS.</summary>
    R32G8X24Typeless = 19, // 0x00000013
    /// <summary>See DXGI_FORMAT_D32_FLOAT_S8X24_UINT.</summary>
    D32FloatS8X24UInt = 20, // 0x00000014
    /// <summary>See DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS.</summary>
    R32FloatX8X24Typeless = 21, // 0x00000015
    /// <summary>See DXGI_FORMAT_X32_TYPELESS_G8X24_UINT.</summary>
    X32TypelessG8X24UInt = 22, // 0x00000016
    /// <summary>See DXGI_FORMAT_R10G10B10A2_TYPELESS.</summary>
    R10G10B10A2Typeless = 23, // 0x00000017
    /// <summary>See DXGI_FORMAT_R10G10B10A2_UNORM.</summary>
    R10G10B10A2UIntNormalized = 24, // 0x00000018
    /// <summary>See DXGI_FORMAT_R10G10B10A2_UINT.</summary>
    R10G10B10A2UInt = 25, // 0x00000019
    /// <summary>See DXGI_FORMAT_R11G11B10_FLOAT.</summary>
    R11G11B10Float = 26, // 0x0000001A
    /// <summary>See DXGI_FORMAT_R8G8B8A8_TYPELESS.</summary>
    R8G8B8A8Typeless = 27, // 0x0000001B
    /// <summary>See DXGI_FORMAT_R8G8B8A8_UNORM.</summary>
    R8G8B8A8UIntNormalized = 28, // 0x0000001C
    /// <summary>See DXGI_FORMAT_R8G8B8A8_UNORM_SRGB.</summary>
    R8G8B8A8UIntNormalizedSrgb = 29, // 0x0000001D
    /// <summary>See DXGI_FORMAT_R8G8B8A8_UINT.</summary>
    R8G8B8A8UInt = 30, // 0x0000001E
    /// <summary>See DXGI_FORMAT_R8G8B8A8_SNORM.</summary>
    R8G8B8A8IntNormalized = 31, // 0x0000001F
    /// <summary>See DXGI_FORMAT_R8G8B8A8_SINT.</summary>
    R8G8B8A8Int = 32, // 0x00000020
    /// <summary>See DXGI_FORMAT_R16G16_TYPELESS.</summary>
    R16G16Typeless = 33, // 0x00000021
    /// <summary>See DXGI_FORMAT_R16G16_FLOAT.</summary>
    R16G16Float = 34, // 0x00000022
    /// <summary>See DXGI_FORMAT_R16G16_UNORM.</summary>
    R16G16UIntNormalized = 35, // 0x00000023
    /// <summary>See DXGI_FORMAT_R16G16_UINT.</summary>
    R16G16UInt = 36, // 0x00000024
    /// <summary>See DXGI_FORMAT_R16G16_SNORM.</summary>
    R16G16IntNormalized = 37, // 0x00000025
    /// <summary>See DXGI_FORMAT_R16G16_SINT.</summary>
    R16G16Int = 38, // 0x00000026
    /// <summary>See DXGI_FORMAT_R32_TYPELESS.</summary>
    R32Typeless = 39, // 0x00000027
    /// <summary>See DXGI_FORMAT_D32_FLOAT.</summary>
    D32Float = 40, // 0x00000028
    /// <summary>See DXGI_FORMAT_R32_FLOAT.</summary>
    R32Float = 41, // 0x00000029
    /// <summary>See DXGI_FORMAT_R32_UINT.</summary>
    R32UInt = 42, // 0x0000002A
    /// <summary>See DXGI_FORMAT_R32_SINT.</summary>
    R32Int = 43, // 0x0000002B
    /// <summary>See DXGI_FORMAT_R24G8_TYPELESS.</summary>
    R24G8Typeless = 44, // 0x0000002C
    /// <summary>See DXGI_FORMAT_D24_UNORM_S8_UINT.</summary>
    D24UIntNormalizedS8UInt = 45, // 0x0000002D
    /// <summary>See DXGI_FORMAT_R24_UNORM_X8_TYPELESS.</summary>
    R24UIntNormalizedX8Typeless = 46, // 0x0000002E
    /// <summary>See DXGI_FORMAT_X24_TYPELESS_G8_UINT.</summary>
    X24TypelessG8UInt = 47, // 0x0000002F
    /// <summary>See DXGI_FORMAT_R8G8_TYPELESS.</summary>
    R8G8Typeless = 48, // 0x00000030
    /// <summary>See DXGI_FORMAT_R8G8_UNORM.</summary>
    R8G8UIntNormalized = 49, // 0x00000031
    /// <summary>See DXGI_FORMAT_R8G8_UINT.</summary>
    R8G8UInt = 50, // 0x00000032
    /// <summary>See DXGI_FORMAT_R8G8_SNORM.</summary>
    R8G8IntNormalized = 51, // 0x00000033
    /// <summary>See DXGI_FORMAT_R8G8_SINT.</summary>
    R8G8Int = 52, // 0x00000034
    /// <summary>See DXGI_FORMAT_R16_TYPELESS.</summary>
    R16Typeless = 53, // 0x00000035
    /// <summary>See DXGI_FORMAT_R16_FLOAT.</summary>
    R16Float = 54, // 0x00000036
    /// <summary>See DXGI_FORMAT_D16_UNORM.</summary>
    D16UIntNormalized = 55, // 0x00000037
    /// <summary>See DXGI_FORMAT_R16_UNORM.</summary>
    R16UIntNormalized = 56, // 0x00000038
    /// <summary>See DXGI_FORMAT_R16_UINT.</summary>
    R16UInt = 57, // 0x00000039
    /// <summary>See DXGI_FORMAT_R16_SNORM.</summary>
    R16IntNormalized = 58, // 0x0000003A
    /// <summary>See DXGI_FORMAT_R16_SINT.</summary>
    R16Int = 59, // 0x0000003B
    /// <summary>See DXGI_FORMAT_R8_TYPELESS.</summary>
    R8Typeless = 60, // 0x0000003C
    /// <summary>See DXGI_FORMAT_R8_UNORM.</summary>
    R8UIntNormalized = 61, // 0x0000003D
    /// <summary>See DXGI_FORMAT_R8_UINT.</summary>
    R8UInt = 62, // 0x0000003E
    /// <summary>See DXGI_FORMAT_R8_SNORM.</summary>
    R8IntNormalized = 63, // 0x0000003F
    /// <summary>See DXGI_FORMAT_R8_SINT.</summary>
    R8Int = 64, // 0x00000040
    /// <summary>See DXGI_FORMAT_A8_UNORM.</summary>
    A8UIntNormalized = 65, // 0x00000041
    /// <summary>See DXGI_FORMAT_R1_UNORM.</summary>
    R1UIntNormalized = 66, // 0x00000042
    /// <summary>See DXGI_FORMAT_R9G9B9E5_SHAREDEXP.</summary>
    R9G9B9E5SharedExponent = 67, // 0x00000043
    /// <summary>See DXGI_FORMAT_R8G8_B8G8_UNORM.</summary>
    R8G8B8G8UIntNormalized = 68, // 0x00000044
    /// <summary>See DXGI_FORMAT_G8R8_G8B8_UNORM.</summary>
    G8R8G8B8UIntNormalized = 69, // 0x00000045
    /// <summary>See DXGI_FORMAT_BC1_TYPELESS.</summary>
    BC1Typeless = 70, // 0x00000046
    /// <summary>See DXGI_FORMAT_BC1_UNORM.</summary>
    BC1UIntNormalized = 71, // 0x00000047
    /// <summary>See DXGI_FORMAT_BC1_UNORM_SRGB.</summary>
    BC1UIntNormalizedSrgb = 72, // 0x00000048
    /// <summary>See DXGI_FORMAT_BC2_TYPELESS.</summary>
    BC2Typeless = 73, // 0x00000049
    /// <summary>See DXGI_FORMAT_BC2_UNORM.</summary>
    BC2UIntNormalized = 74, // 0x0000004A
    /// <summary>See DXGI_FORMAT_BC2_UNORM_SRGB.</summary>
    BC2UIntNormalizedSrgb = 75, // 0x0000004B
    /// <summary>See DXGI_FORMAT_BC3_TYPELESS.</summary>
    BC3Typeless = 76, // 0x0000004C
    /// <summary>See DXGI_FORMAT_BC3_UNORM.</summary>
    BC3UIntNormalized = 77, // 0x0000004D
    /// <summary>See DXGI_FORMAT_BC3_UNORM_SRGB.</summary>
    BC3UIntNormalizedSrgb = 78, // 0x0000004E
    /// <summary>See DXGI_FORMAT_BC4_TYPELESS.</summary>
    BC4Typeless = 79, // 0x0000004F
    /// <summary>See DXGI_FORMAT_BC4_UNORM.</summary>
    BC4UIntNormalized = 80, // 0x00000050
    /// <summary>See DXGI_FORMAT_BC4_SNORM.</summary>
    BC4IntNormalized = 81, // 0x00000051
    /// <summary>See DXGI_FORMAT_BC5_TYPELESS.</summary>
    BC5Typeless = 82, // 0x00000052
    /// <summary>See DXGI_FORMAT_BC5_UNORM.</summary>
    BC5UIntNormalized = 83, // 0x00000053
    /// <summary>See DXGI_FORMAT_BC5_SNORM.</summary>
    BC5IntNormalized = 84, // 0x00000054
    /// <summary>See DXGI_FORMAT_B5G6R5_UNORM.</summary>
    B5G6R5UIntNormalized = 85, // 0x00000055
    /// <summary>See DXGI_FORMAT_B5G5R5A1_UNORM.</summary>
    B5G5R5A1UIntNormalized = 86, // 0x00000056
    /// <summary>See DXGI_FORMAT_B8G8R8A8_UNORM.</summary>
    B8G8R8A8UIntNormalized = 87, // 0x00000057
    /// <summary>See DXGI_FORMAT_B8G8R8X8_UNORM.</summary>
    B8G8R8X8UIntNormalized = 88, // 0x00000058
    /// <summary>See DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM.</summary>
    R10G10B10XRBiasA2UIntNormalized = 89, // 0x00000059
    /// <summary>See DXGI_FORMAT_B8G8R8A8_TYPELESS.</summary>
    B8G8R8A8Typeless = 90, // 0x0000005A
    /// <summary>See DXGI_FORMAT_B8G8R8A8_UNORM_SRGB.</summary>
    B8G8R8A8UIntNormalizedSrgb = 91, // 0x0000005B
    /// <summary>See DXGI_FORMAT_B8G8R8X8_TYPELESS.</summary>
    B8G8R8X8Typeless = 92, // 0x0000005C
    /// <summary>See DXGI_FORMAT_B8G8R8X8_UNORM_SRGB.</summary>
    B8G8R8X8UIntNormalizedSrgb = 93, // 0x0000005D
    /// <summary>See DXGI_FORMAT_BC6H_TYPELESS.</summary>
    BC6HTypeless = 94, // 0x0000005E
    /// <summary>See DXGI_FORMAT_BC6H_UF16.</summary>
    BC6H16UnsignedFloat = 95, // 0x0000005F
    /// <summary>See DXGI_FORMAT_BC6H_SF16.</summary>
    BC6H16Float = 96, // 0x00000060
    /// <summary>See DXGI_FORMAT_BC7_TYPELESS.</summary>
    BC7Typeless = 97, // 0x00000061
    /// <summary>See DXGI_FORMAT_BC7_UNORM.</summary>
    BC7UIntNormalized = 98, // 0x00000062
    /// <summary>See DXGI_FORMAT_BC7_UNORM_SRGB.</summary>
    BC7UIntNormalizedSrgb = 99, // 0x00000063
    /// <summary>See DXGI_FORMAT_AYUV.</summary>
    Ayuv = 100, // 0x00000064
    /// <summary>See DXGI_FORMAT_Y410.</summary>
    Y410 = 101, // 0x00000065
    /// <summary>See DXGI_FORMAT_Y416.</summary>
    Y416 = 102, // 0x00000066
    /// <summary>See DXGI_FORMAT_NV12.</summary>
    NV12 = 103, // 0x00000067
    /// <summary>See DXGI_FORMAT_P010.</summary>
    P010 = 104, // 0x00000068
    /// <summary>See DXGI_FORMAT_P016.</summary>
    P016 = 105, // 0x00000069
    /// <summary>See DXGI_FORMAT_420_OPAQUE.</summary>
    Opaque420 = 106, // 0x0000006A
    /// <summary>See DXGI_FORMAT_YUY2.</summary>
    Yuy2 = 107, // 0x0000006B
    /// <summary>See DXGI_FORMAT_Y210.</summary>
    Y210 = 108, // 0x0000006C
    /// <summary>See DXGI_FORMAT_Y216.</summary>
    Y216 = 109, // 0x0000006D
    /// <summary>See DXGI_FORMAT_NV11.</summary>
    NV11 = 110, // 0x0000006E
    /// <summary>See DXGI_FORMAT_AI44.</summary>
    AI44 = 111, // 0x0000006F
    /// <summary>See DXGI_FORMAT_IA44.</summary>
    IA44 = 112, // 0x00000070
    /// <summary>See DXGI_FORMAT_P8.</summary>
    P8 = 113, // 0x00000071
    /// <summary>See DXGI_FORMAT_A8P8.</summary>
    A8P8 = 114, // 0x00000072
    /// <summary>See DXGI_FORMAT_B4G4R4A4_UNORM.</summary>
    B4G4R4A4UIntNormalized = 115, // 0x00000073
    /// <summary>See DXGI_FORMAT_P208.</summary>
    P208 = 130, // 0x00000082
    /// <summary>See DXGI_FORMAT_V208.</summary>
    V208 = 131, // 0x00000083
    /// <summary>See DXGI_FORMAT_V408.</summary>
    V408 = 132, // 0x00000084
    /// <summary>See DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] SamplerFeedbackMinMipOpaque = 189, // 0x000000BD
    /// <summary>See DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] SamplerFeedbackMipRegionUsedOpaque = 190, // 0x000000BE
  }
}
