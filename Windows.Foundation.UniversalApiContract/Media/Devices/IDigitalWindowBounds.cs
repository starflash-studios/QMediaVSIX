// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IDigitalWindowBounds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (DigitalWindowBounds))]
  [Guid(3712950749, 53619, 23659, 140, 37, 189, 210, 109, 81, 34, 177)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  internal interface IDigitalWindowBounds
  {
    double NormalizedOriginTop { get; set; }

    double NormalizedOriginLeft { get; set; }

    double Scale { get; set; }
  }
}
