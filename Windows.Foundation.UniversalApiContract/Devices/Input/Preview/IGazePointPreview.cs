// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.IGazePointPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.HumanInterfaceDevice;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  [ExclusiveTo(typeof (GazePointPreview))]
  [Guid(3885924074, 45961, 4583, 178, 1, 200, 211, 255, 183, 87, 33)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IGazePointPreview
  {
    GazeDevicePreview SourceDevice { get; }

    IReference<Point> EyeGazePosition { get; }

    IReference<Point> HeadGazePosition { get; }

    ulong Timestamp { get; }

    HidInputReport HidInputReport { get; }
  }
}
