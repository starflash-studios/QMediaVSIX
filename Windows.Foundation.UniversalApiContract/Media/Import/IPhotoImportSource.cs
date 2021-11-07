// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportSource))]
  [Guid(529441630, 5211, 19670, 135, 241, 84, 150, 90, 152, 47, 239)]
  internal interface IPhotoImportSource
  {
    string Id { get; }

    string DisplayName { get; }

    string Description { get; }

    string Manufacturer { get; }

    string Model { get; }

    string SerialNumber { get; }

    string ConnectionProtocol { get; }

    PhotoImportConnectionTransport ConnectionTransport { get; }

    PhotoImportSourceType Type { get; }

    PhotoImportPowerSource PowerSource { get; }

    IReference<uint> BatteryLevelPercent { get; }

    IReference<global::Windows.Foundation.DateTime> DateTime { get; }

    IVectorView<PhotoImportStorageMedium> StorageMedia { get; }

    IReference<bool> IsLocked { get; }

    bool IsMassStorage { get; }

    IRandomAccessStreamReference Thumbnail { get; }

    PhotoImportSession CreateImportSession();
  }
}
