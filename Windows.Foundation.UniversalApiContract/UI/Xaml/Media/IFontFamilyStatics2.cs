// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IFontFamilyStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1387100921, 14310, 17047, 162, 56, 151, 251, 106, 64, 141, 158)]
  [ExclusiveTo(typeof (FontFamily))]
  internal interface IFontFamilyStatics2
  {
    FontFamily XamlAutoFontFamily { get; }
  }
}
