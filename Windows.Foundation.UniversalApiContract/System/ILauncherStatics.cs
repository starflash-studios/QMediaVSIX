// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(661737923, 40510, 17142, 145, 164, 93, 253, 235, 35, 36, 81)]
  [ExclusiveTo(typeof (Launcher))]
  internal interface ILauncherStatics
  {
    [Overload("LaunchFileAsync")]
    IAsyncOperation<bool> LaunchFileAsync(IStorageFile file);

    [Overload("LaunchFileWithOptionsAsync")]
    IAsyncOperation<bool> LaunchFileAsync(IStorageFile file, LauncherOptions options);

    [Overload("LaunchUriAsync")]
    IAsyncOperation<bool> LaunchUriAsync(Uri uri);

    [Overload("LaunchUriWithOptionsAsync")]
    IAsyncOperation<bool> LaunchUriAsync(Uri uri, LauncherOptions options);
  }
}
