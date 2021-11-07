// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePairingRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(4145544278, 56939, 18559, 131, 118, 1, 128, 172, 166, 153, 99)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (DevicePairingRequestedEventArgs))]
  internal interface IDevicePairingRequestedEventArgs
  {
    DeviceInformation DeviceInformation { get; }

    DevicePairingKinds PairingKind { get; }

    string Pin { get; }

    [Overload("Accept")]
    void Accept();

    [Overload("AcceptWithPin")]
    void Accept(string pin);

    Deferral GetDeferral();
  }
}
