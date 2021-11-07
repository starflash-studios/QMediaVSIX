// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattWriteRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattWriteRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(770476990, 42810, 18202, 148, 213, 3, 125, 234, 221, 8, 6)]
  internal interface IGattWriteRequestedEventArgs
  {
    GattSession Session { get; }

    Deferral GetDeferral();

    [RemoteAsync]
    IAsyncOperation<GattWriteRequest> GetRequestAsync();
  }
}
