// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [ExclusiveTo(typeof (ResourceLoader))]
  [Guid(3212279009, 6600, 18882, 149, 60, 71, 233, 34, 123, 51, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceLoaderStatics
  {
    string GetStringForReference(Uri uri);
  }
}
