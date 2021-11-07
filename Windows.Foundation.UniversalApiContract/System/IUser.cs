// Decompiled with JetBrains decompiler
// Type: Windows.System.IUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System
{
  [Guid(3751421638, 59206, 19405, 181, 212, 18, 1, 3, 196, 32, 155)]
  [ExclusiveTo(typeof (User))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUser
  {
    string NonRoamableId { get; }

    UserAuthenticationStatus AuthenticationStatus { get; }

    UserType Type { get; }

    [RemoteAsync]
    IAsyncOperation<object> GetPropertyAsync(string value);

    [RemoteAsync]
    IAsyncOperation<IPropertySet> GetPropertiesAsync(
      IVectorView<string> values);

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamReference> GetPictureAsync(
      UserPictureSize desiredSize);
  }
}
