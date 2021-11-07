// Decompiled with JetBrains decompiler
// Type: Windows.Data.Html.IHtmlUtilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Html
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HtmlUtilities))]
  [Guid(4273998557, 9113, 20396, 181, 167, 5, 233, 172, 215, 24, 29)]
  [WebHostHidden]
  internal interface IHtmlUtilities
  {
    string ConvertToText(string html);
  }
}
