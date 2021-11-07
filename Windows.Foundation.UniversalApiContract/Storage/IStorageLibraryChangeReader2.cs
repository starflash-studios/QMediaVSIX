// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChangeReader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [ExclusiveTo(typeof (StorageLibraryChangeReader))]
  [Guid(2884929163, 64460, 19023, 153, 158, 231, 171, 124, 100, 109, 190)]
  internal interface IStorageLibraryChangeReader2
  {
    ulong GetLastChangeId();
  }
}
