// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceCandidate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Resources.Core
{
  [ExclusiveTo(typeof (ResourceCandidate))]
  [Guid(2941388761, 50227, 18276, 179, 253, 143, 166, 191, 188, 186, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceCandidate
  {
    IVectorView<ResourceQualifier> Qualifiers { get; }

    bool IsMatch { get; }

    bool IsMatchAsDefault { get; }

    bool IsDefault { get; }

    string ValueAsString { get; }

    [RemoteAsync]
    IAsyncOperation<StorageFile> GetValueAsFileAsync();

    string GetQualifierValue(string qualifierName);
  }
}
