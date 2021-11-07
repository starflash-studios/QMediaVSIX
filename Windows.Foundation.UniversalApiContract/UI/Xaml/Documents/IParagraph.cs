// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IParagraph
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Paragraph))]
  [Guid(4164875674, 64097, 19439, 174, 51, 11, 10, 215, 86, 168, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IParagraph
  {
    InlineCollection Inlines { get; }

    double TextIndent { get; set; }
  }
}
