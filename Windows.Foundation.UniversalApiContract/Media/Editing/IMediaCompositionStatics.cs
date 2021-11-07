// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaCompositionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (MediaComposition))]
  [Guid(2275446532, 58154, 17870, 143, 102, 163, 13, 240, 118, 98, 36)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCompositionStatics
  {
    [RemoteAsync]
    IAsyncOperation<MediaComposition> LoadAsync(StorageFile file);
  }
}
