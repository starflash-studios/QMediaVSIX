// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(4043650309, 62779, 18083, 158, 48, 54, 16, 121, 26, 145, 16)]
  [ExclusiveTo(typeof (PhotoImportItem))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IPhotoImportItem2
  {
    string Path { get; }
  }
}
