// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IKnownFoldersSavedPicturesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (KnownFolders))]
  [Guid(89953258, 9533, 18044, 182, 202, 169, 125, 161, 233, 161, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKnownFoldersSavedPicturesStatics
  {
    StorageFolder SavedPictures { get; }
  }
}
