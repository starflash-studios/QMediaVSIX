// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage8
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel
{
  [Guid(743985019, 52778, 19430, 160, 147, 119, 207, 187, 42, 126, 161)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage8
  {
    StorageFolder EffectiveExternalLocation { get; }

    StorageFolder MachineExternalLocation { get; }

    StorageFolder UserExternalLocation { get; }

    string InstalledPath { get; }

    string MutablePath { get; }

    string EffectivePath { get; }

    string EffectiveExternalPath { get; }

    string MachineExternalPath { get; }

    string UserExternalPath { get; }

    RandomAccessStreamReference GetLogoAsRandomAccessStreamReference(
      Size size);

    IVectorView<AppListEntry> GetAppListEntries();

    bool IsStub { get; }
  }
}
