// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(1512731936, 18434, 17709, 154, 217, 67, 81, 173, 167, 236, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KnownFolders))]
  internal interface IKnownFoldersStatics
  {
    StorageFolder MusicLibrary { get; }

    StorageFolder PicturesLibrary { get; }

    StorageFolder VideosLibrary { get; }

    StorageFolder DocumentsLibrary { get; }

    StorageFolder HomeGroup { get; }

    StorageFolder RemovableDevices { get; }

    StorageFolder MediaServerDevices { get; }
  }
}
