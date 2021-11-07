// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ICachedFileUpdaterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ExclusiveTo(typeof (CachedFileUpdater))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2680752416, 31695, 18568, 168, 30, 16, 45, 112, 52, 215, 206)]
  internal interface ICachedFileUpdaterStatics
  {
    void SetUpdateInformation(
      IStorageFile file,
      string contentId,
      ReadActivationMode readMode,
      WriteActivationMode writeMode,
      CachedFileOptions options);
  }
}
