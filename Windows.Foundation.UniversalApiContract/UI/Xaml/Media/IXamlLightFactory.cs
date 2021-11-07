// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(2279528296, 12373, 17336, 142, 246, 121, 141, 196, 194, 50, 154)]
  [ExclusiveTo(typeof (XamlLight))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IXamlLightFactory
  {
    XamlLight CreateInstance(object baseInterface, out object innerInterface);
  }
}
