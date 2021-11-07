// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameIsoSpeedCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(381550433, 28150, 19145, 185, 42, 159, 110, 205, 26, 210, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameIsoSpeedCapabilities))]
  internal interface IFrameIsoSpeedCapabilities
  {
    bool Supported { get; }

    uint Min { get; }

    uint Max { get; }

    uint Step { get; }
  }
}
