// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [Guid(139610376, 5871, 17837, 166, 2, 41, 54, 55, 215, 230, 26)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceLoader))]
  internal interface IResourceLoader
  {
    string GetString(string resource);
  }
}
