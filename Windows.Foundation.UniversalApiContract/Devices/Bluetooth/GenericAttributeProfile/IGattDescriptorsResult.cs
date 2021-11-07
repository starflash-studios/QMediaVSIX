// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptorsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2613088755, 38375, 17545, 141, 37, 255, 129, 149, 90, 87, 185)]
  [ExclusiveTo(typeof (GattDescriptorsResult))]
  internal interface IGattDescriptorsResult
  {
    GattCommunicationStatus Status { get; }

    IReference<byte> ProtocolError { get; }

    IVectorView<GattDescriptor> Descriptors { get; }
  }
}
