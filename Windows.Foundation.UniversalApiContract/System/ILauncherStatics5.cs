// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1529147268, 55445, 24554, 145, 83, 26, 196, 154, 237, 155, 169)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (Launcher))]
  internal interface ILauncherStatics5
  {
    [Overload("LaunchFolderPathAsync")]
    IAsyncOperation<bool> LaunchFolderPathAsync(string path);

    [Overload("LaunchFolderPathWithOptionsAsync")]
    IAsyncOperation<bool> LaunchFolderPathAsync(
      string path,
      FolderLauncherOptions options);

    [Overload("LaunchFolderPathForUserAsync")]
    IAsyncOperation<bool> LaunchFolderPathForUserAsync(User user, string path);

    [Overload("LaunchFolderPathWithOptionsForUserAsync")]
    IAsyncOperation<bool> LaunchFolderPathForUserAsync(
      User user,
      string path,
      FolderLauncherOptions options);
  }
}
