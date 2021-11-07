// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [Guid(591552936, 40371, 18051, 170, 66, 220, 111, 81, 211, 56, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Launcher))]
  internal interface ILauncherStatics3
  {
    [Overload("LaunchFolderAsync")]
    IAsyncOperation<bool> LaunchFolderAsync(IStorageFolder folder);

    [Overload("LaunchFolderWithOptionsAsync")]
    IAsyncOperation<bool> LaunchFolderAsync(
      IStorageFolder folder,
      FolderLauncherOptions options);
  }
}
