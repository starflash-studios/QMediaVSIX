// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IGattServiceProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(2928412197, 1535, 19195, 177, 106, 222, 149, 243, 207, 1, 88)]
  [ExclusiveTo(typeof (GattServiceProviderTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattServiceProviderTriggerDetails
  {
    GattServiceProviderConnection Connection { get; }
  }
}
