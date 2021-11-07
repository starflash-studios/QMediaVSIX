// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IMarkupExtensionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [ExclusiveTo(typeof (MarkupExtension))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(1697815557, 64346, 17767, 157, 85, 92, 223, 186, 218, 39, 57)]
  internal interface IMarkupExtensionFactory
  {
    MarkupExtension CreateInstance(object baseInterface, out object innerInterface);
  }
}
