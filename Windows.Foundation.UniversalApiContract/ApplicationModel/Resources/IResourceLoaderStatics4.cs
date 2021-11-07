// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [ExclusiveTo(typeof (ResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(2679335986, 27788, 17174, 150, 46, 144, 149, 57, 181, 194, 89)]
  internal interface IResourceLoaderStatics4
  {
    string GetDefaultPriPath(string packageFullName);
  }
}
