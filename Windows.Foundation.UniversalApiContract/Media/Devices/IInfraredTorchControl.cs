// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IInfraredTorchControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (InfraredTorchControl))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(481963139, 27830, 23044, 166, 252, 59, 231, 179, 63, 240, 86)]
  internal interface IInfraredTorchControl
  {
    bool IsSupported { get; }

    IVectorView<InfraredTorchMode> SupportedModes { get; }

    InfraredTorchMode CurrentMode { get; set; }

    int MinPower { get; }

    int MaxPower { get; }

    int PowerStep { get; }

    int Power { get; set; }
  }
}
