// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameExposureCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3183385827, 14725, 20082, 151, 194, 5, 144, 214, 19, 7, 161)]
  internal interface IFrameExposureCapabilities
  {
    bool Supported { get; }

    TimeSpan Min { get; }

    TimeSpan Max { get; }

    TimeSpan Step { get; }
  }
}
