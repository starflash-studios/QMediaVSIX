// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.ILanguageFont
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.Globalization.Fonts
{
  [Guid(2972605498, 46957, 17819, 190, 235, 144, 17, 81, 205, 119, 209)]
  [ExclusiveTo(typeof (LanguageFont))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguageFont
  {
    string FontFamily { get; }

    FontWeight FontWeight { get; }

    FontStretch FontStretch { get; }

    FontStyle FontStyle { get; }

    double ScaleFactor { get; }
  }
}
