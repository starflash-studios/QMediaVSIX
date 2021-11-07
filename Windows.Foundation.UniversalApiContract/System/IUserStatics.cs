// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(358527547, 9258, 17888, 162, 233, 49, 113, 252, 106, 127, 221)]
  [ExclusiveTo(typeof (User))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUserStatics
  {
    UserWatcher CreateWatcher();

    [DefaultOverload]
    [Overload("FindAllAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<User>> FindAllAsync();

    [Deprecated("FindAllAsyncByType is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [Overload("FindAllAsyncByType")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<User>> FindAllAsync(UserType type);

    [Deprecated("FindAllAsyncByTypeAndStatus is deprecated and might not function consistently on all platforms. Instead, use FindAllAsync or GetDefault.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [Overload("FindAllAsyncByTypeAndStatus")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<User>> FindAllAsync(
      UserType type,
      UserAuthenticationStatus status);

    User GetFromId(string nonRoamableId);
  }
}
