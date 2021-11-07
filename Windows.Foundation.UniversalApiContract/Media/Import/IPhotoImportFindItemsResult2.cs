// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportFindItemsResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(4225591867, 60665, 16490, 129, 94, 80, 21, 98, 91, 10, 136)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PhotoImportFindItemsResult))]
  internal interface IPhotoImportFindItemsResult2
  {
    void AddItemsInDateRangeToSelection(DateTime rangeStart, TimeSpan rangeLength);
  }
}
