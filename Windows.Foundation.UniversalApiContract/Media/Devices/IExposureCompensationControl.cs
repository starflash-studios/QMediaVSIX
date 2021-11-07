// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IExposureCompensationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2177427508, 56556, 16401, 166, 16, 31, 56, 71, 230, 74, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ExposureCompensationControl))]
  internal interface IExposureCompensationControl
  {
    bool Supported { get; }

    float Min { get; }

    float Max { get; }

    float Step { get; }

    float Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(float value);
  }
}
