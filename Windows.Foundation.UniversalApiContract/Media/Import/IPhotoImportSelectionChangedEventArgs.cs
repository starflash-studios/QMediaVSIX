// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSelectionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportSelectionChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(273028994, 64157, 19504, 139, 201, 77, 100, 145, 21, 114, 213)]
  internal interface IPhotoImportSelectionChangedEventArgs
  {
    bool IsSelectionEmpty { get; }
  }
}
