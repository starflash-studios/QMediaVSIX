// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSession2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(710043408, 16070, 18077, 163, 117, 43, 159, 71, 133, 57, 30)]
  [ExclusiveTo(typeof (PhotoImportSession))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhotoImportSession2
  {
    PhotoImportSubfolderDateFormat SubfolderDateFormat { set; get; }

    bool RememberDeselectedItems { set; get; }
  }
}
