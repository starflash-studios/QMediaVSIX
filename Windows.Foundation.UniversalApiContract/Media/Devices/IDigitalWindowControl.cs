// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IDigitalWindowControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (DigitalWindowControl))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(599170815, 26066, 21482, 135, 128, 222, 88, 43, 72, 181, 68)]
  internal interface IDigitalWindowControl
  {
    bool IsSupported { get; }

    DigitalWindowMode[] SupportedModes { get; }

    DigitalWindowMode CurrentMode { get; }

    DigitalWindowBounds GetBounds();

    [Overload("Configure")]
    void Configure(DigitalWindowMode digitalWindowMode);

    [Overload("ConfigureWithBounds")]
    void Configure(DigitalWindowMode digitalWindowMode, DigitalWindowBounds digitalWindowBounds);

    IVectorView<DigitalWindowCapability> SupportedCapabilities { get; }

    DigitalWindowCapability GetCapabilityForSize(int width, int height);
  }
}
