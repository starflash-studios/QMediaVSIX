// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILamp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(75324314, 59973, 19243, 177, 162, 20, 223, 240, 11, 222, 123)]
  [ExclusiveTo(typeof (Lamp))]
  internal interface ILamp : IClosable
  {
    string DeviceId { get; }

    bool IsEnabled { get; set; }

    float BrightnessLevel { get; set; }

    bool IsColorSettable { get; }

    Color Color { get; set; }

    event TypedEventHandler<Lamp, LampAvailabilityChangedEventArgs> AvailabilityChanged;
  }
}
