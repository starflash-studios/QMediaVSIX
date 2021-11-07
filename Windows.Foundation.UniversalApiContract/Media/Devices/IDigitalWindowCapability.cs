// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IDigitalWindowCapability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3616255276, 63265, 21060, 161, 150, 181, 108, 203, 236, 96, 108)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (DigitalWindowCapability))]
  internal interface IDigitalWindowCapability
  {
    int Width { get; }

    int Height { get; }

    double MinScaleValue { get; }

    double MaxScaleValue { get; }

    double MinScaleValueWithoutUpsampling { get; }

    Rect NormalizedFieldOfViewLimit { get; }
  }
}
