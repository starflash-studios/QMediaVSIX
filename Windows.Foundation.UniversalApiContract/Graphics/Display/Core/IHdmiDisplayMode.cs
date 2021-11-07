// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.IHdmiDisplayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ExclusiveTo(typeof (HdmiDisplayMode))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(201774509, 7056, 20305, 153, 129, 239, 90, 28, 13, 223, 102)]
  internal interface IHdmiDisplayMode
  {
    uint ResolutionWidthInRawPixels { get; }

    uint ResolutionHeightInRawPixels { get; }

    double RefreshRate { get; }

    bool StereoEnabled { get; }

    ushort BitsPerPixel { get; }

    bool IsEqual(HdmiDisplayMode mode);

    HdmiDisplayColorSpace ColorSpace { get; }

    HdmiDisplayPixelEncoding PixelEncoding { get; }

    bool IsSdrLuminanceSupported { get; }

    bool IsSmpte2084Supported { get; }

    bool Is2086MetadataSupported { get; }
  }
}
