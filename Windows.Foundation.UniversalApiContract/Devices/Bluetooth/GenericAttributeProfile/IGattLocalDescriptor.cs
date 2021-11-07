// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4102995462, 30877, 19019, 134, 82, 189, 1, 123, 93, 47, 198)]
  internal interface IGattLocalDescriptor
  {
    Guid Uuid { get; }

    IBuffer StaticValue { get; }

    GattProtectionLevel ReadProtectionLevel { get; }

    GattProtectionLevel WriteProtectionLevel { get; }

    event TypedEventHandler<GattLocalDescriptor, GattReadRequestedEventArgs> ReadRequested;

    event TypedEventHandler<GattLocalDescriptor, GattWriteRequestedEventArgs> WriteRequested;
  }
}
