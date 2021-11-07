// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Glyphs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2861301340, 14164, 19438, 187, 225, 68, 3, 238, 155, 134, 240)]
  internal interface IGlyphs2
  {
    bool IsColorFontEnabled { get; set; }

    int ColorFontPaletteIndex { get; set; }
  }
}
