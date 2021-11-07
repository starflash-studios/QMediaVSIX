// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IStoreHardwareManufacturerInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(4069710856, 50772, 17324, 162, 31, 52, 128, 28, 157, 51, 136)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StoreHardwareManufacturerInfo))]
  internal interface IStoreHardwareManufacturerInfo
  {
    string HardwareManufacturerId { get; }

    string StoreContentModifierId { get; }

    string ModelName { get; }

    string ManufacturerName { get; }
  }
}
