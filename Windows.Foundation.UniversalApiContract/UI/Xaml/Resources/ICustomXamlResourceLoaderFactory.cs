// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Resources.ICustomXamlResourceLoaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Resources
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1543339593, 30854, 17651, 142, 211, 111, 236, 4, 99, 237, 105)]
  [ExclusiveTo(typeof (CustomXamlResourceLoader))]
  internal interface ICustomXamlResourceLoaderFactory
  {
    CustomXamlResourceLoader CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
