// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IMarkupExtensionOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [ExclusiveTo(typeof (MarkupExtension))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(959936959, 47552, 20475, 165, 127, 88, 231, 53, 110, 66, 95)]
  [WebHostHidden]
  internal interface IMarkupExtensionOverrides
  {
    object ProvideValue();
  }
}
