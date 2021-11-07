// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Resources.ICustomXamlResourceLoaderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Resources
{
  [Guid(575665687, 58588, 19495, 173, 50, 219, 147, 213, 208, 229, 218)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CustomXamlResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICustomXamlResourceLoaderStatics
  {
    CustomXamlResourceLoader Current { get; set; }
  }
}
