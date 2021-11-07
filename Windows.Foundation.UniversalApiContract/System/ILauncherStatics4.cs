// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (Launcher))]
  [Guid(3119284639, 46501, 16838, 179, 179, 221, 27, 49, 120, 188, 242)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ILauncherStatics4
  {
    [Overload("QueryAppUriSupportAsync")]
    [RemoteAsync]
    IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri);

    [Overload("QueryAppUriSupportWithPackageFamilyNameAsync")]
    [RemoteAsync]
    IAsyncOperation<LaunchQuerySupportStatus> QueryAppUriSupportAsync(
      Uri uri,
      string packageFamilyName);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindAppUriHandlersAsync(
      Uri uri);

    [Overload("LaunchUriForUserAsync")]
    IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri);

    [Overload("LaunchUriWithOptionsForUserAsync")]
    IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriWithDataForUserAsync")]
    IAsyncOperation<LaunchUriStatus> LaunchUriForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);

    [Overload("LaunchUriForResultsForUserAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options);

    [Overload("LaunchUriForResultsWithDataForUserAsync")]
    IAsyncOperation<LaunchUriResult> LaunchUriForResultsForUserAsync(
      User user,
      Uri uri,
      LauncherOptions options,
      ValueSet inputData);
  }
}
