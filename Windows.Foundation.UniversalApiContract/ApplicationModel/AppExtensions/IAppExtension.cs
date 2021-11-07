// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.AppExtensions
{
  [ExclusiveTo(typeof (AppExtension))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2219872300, 5613, 20399, 147, 234, 34, 55, 187, 248, 203, 214)]
  internal interface IAppExtension
  {
    string Id { get; }

    string DisplayName { get; }

    string Description { get; }

    Package Package { get; }

    AppInfo AppInfo { get; }

    [RemoteAsync]
    IAsyncOperation<IPropertySet> GetExtensionPropertiesAsync();

    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetPublicFolderAsync();
  }
}
