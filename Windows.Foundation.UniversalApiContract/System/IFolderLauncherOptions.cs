// Decompiled with JetBrains decompiler
// Type: Windows.System.IFolderLauncherOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FolderLauncherOptions))]
  [Guid(3146891901, 27527, 17194, 189, 4, 119, 108, 111, 95, 178, 171)]
  internal interface IFolderLauncherOptions
  {
    IVector<IStorageItem> ItemsToSelect { get; }
  }
}
