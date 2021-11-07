// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IAdvancedColorInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (AdvancedColorInfo))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2274876667, 45609, 16513, 174, 154, 44, 200, 94, 52, 173, 106)]
  internal interface IAdvancedColorInfo
  {
    AdvancedColorKind CurrentAdvancedColorKind { get; }

    Point RedPrimary { get; }

    Point GreenPrimary { get; }

    Point BluePrimary { get; }

    Point WhitePoint { get; }

    float MaxLuminanceInNits { get; }

    float MinLuminanceInNits { get; }

    float MaxAverageFullFrameLuminanceInNits { get; }

    float SdrWhiteLevelInNits { get; }

    bool IsHdrMetadataFormatCurrentlySupported(HdrMetadataFormat format);

    bool IsAdvancedColorKindAvailable(AdvancedColorKind kind);
  }
}
