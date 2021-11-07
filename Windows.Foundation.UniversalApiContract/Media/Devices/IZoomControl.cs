// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IZoomControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(975047442, 13018, 19479, 191, 215, 141, 12, 115, 200, 245, 165)]
  [ExclusiveTo(typeof (ZoomControl))]
  internal interface IZoomControl
  {
    bool Supported { get; }

    float Min { get; }

    float Max { get; }

    float Step { get; }

    float Value { get; set; }
  }
}
