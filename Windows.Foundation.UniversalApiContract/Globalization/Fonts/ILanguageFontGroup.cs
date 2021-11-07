// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.ILanguageFontGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Fonts
{
  [ExclusiveTo(typeof (LanguageFontGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4080697283, 14940, 19178, 185, 255, 179, 159, 178, 66, 247, 246)]
  internal interface ILanguageFontGroup
  {
    LanguageFont UITextFont { get; }

    LanguageFont UIHeadingFont { get; }

    LanguageFont UITitleFont { get; }

    LanguageFont UICaptionFont { get; }

    LanguageFont UINotificationHeadingFont { get; }

    LanguageFont TraditionalDocumentFont { get; }

    LanguageFont ModernDocumentFont { get; }

    LanguageFont DocumentHeadingFont { get; }

    LanguageFont FixedWidthTextFont { get; }

    LanguageFont DocumentAlternate1Font { get; }

    LanguageFont DocumentAlternate2Font { get; }
  }
}
