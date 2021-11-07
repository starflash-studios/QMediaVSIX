// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IExposureControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (ExposureControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(166251490, 44438, 20264, 160, 224, 150, 237, 126, 27, 95, 210)]
  internal interface IExposureControl
  {
    bool Supported { get; }

    bool Auto { get; }

    [RemoteAsync]
    IAsyncAction SetAutoAsync(bool value);

    TimeSpan Min { get; }

    TimeSpan Max { get; }

    TimeSpan Step { get; }

    TimeSpan Value { get; }

    [RemoteAsync]
    IAsyncAction SetValueAsync(TimeSpan shutterDuration);
  }
}
