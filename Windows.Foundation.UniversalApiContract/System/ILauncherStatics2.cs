// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.System
{
  [ExclusiveTo(typeof (Launcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1505374139, 9419, 19458, 164, 196, 130, 148, 86, 157, 84, 241)]
  internal interface ILauncherStatics2
  {
    [Overload("LaunchUriForResultsAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriWithDataAsync")]
    IAsyncOperation<bool> LaunchUriAsync(
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [RemoteAsync]
    [Overload("QueryUriSupportAsync")]
    IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType);

    [RemoteAsync]
    [Overload("QueryUriSupportWithPackageFamilyNameAsync")]
    IAsyncOperation<LaunchQuerySupportStatus> QueryUriSupportAsync(
      Uri uri,
      LaunchQuerySupportType launchQuerySupportType,
      string packageFamilyName);

    [RemoteAsync]
    [Overload("QueryFileSupportAsync")]
    IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file);

    [RemoteAsync]
    [Overload("QueryFileSupportWithPackageFamilyNameAsync")]
    IAsyncOperation<LaunchQuerySupportStatus> QueryFileSupportAsync(
      StorageFile file,
      string packageFamilyName);

    [RemoteAsync]
    [Overload("FindUriSchemeHandlersAsync")]
    IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme);

    [Overload("FindUriSchemeHandlersWithLaunchUriTypeAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindUriSchemeHandlersAsync(
      string scheme,
      LaunchQuerySupportType launchQuerySupportType);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindFileHandlersAsync(
      string extension);
  }
}
