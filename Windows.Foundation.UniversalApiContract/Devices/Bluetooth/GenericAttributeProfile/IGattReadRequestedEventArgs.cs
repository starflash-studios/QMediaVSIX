// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattReadRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2471064131, 62364, 18507, 138, 182, 153, 107, 164, 134, 207, 163)]
  internal interface IGattReadRequestedEventArgs
  {
    GattSession Session { get; }

    Deferral GetDeferral();

    [RemoteAsync]
    IAsyncOperation<GattReadRequest> GetRequestAsync();
  }
}
