// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [Guid(3275372035, 27100, 17029, 160, 119, 213, 192, 228, 124, 203, 232)]
  [ExclusiveTo(typeof (ResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceLoaderFactory
  {
    ResourceLoader CreateResourceLoaderByName(string name);
  }
}
