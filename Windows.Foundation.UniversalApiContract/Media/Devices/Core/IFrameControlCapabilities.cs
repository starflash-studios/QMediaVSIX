// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameControlCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(2835328608, 20126, 17271, 167, 137, 226, 76, 74, 231, 229, 68)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameControlCapabilities))]
  internal interface IFrameControlCapabilities
  {
    FrameExposureCapabilities Exposure { get; }

    FrameExposureCompensationCapabilities ExposureCompensation { get; }

    FrameIsoSpeedCapabilities IsoSpeed { get; }

    FrameFocusCapabilities Focus { get; }

    bool PhotoConfirmationSupported { get; }
  }
}
