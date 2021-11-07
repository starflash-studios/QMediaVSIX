// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IUnicodeCharactersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2542837383, 37521, 20369, 182, 200, 182, 227, 89, 215, 167, 251)]
  [ExclusiveTo(typeof (UnicodeCharacters))]
  internal interface IUnicodeCharactersStatics
  {
    uint GetCodepointFromSurrogatePair(uint highSurrogate, uint lowSurrogate);

    void GetSurrogatePairFromCodepoint(
      uint codepoint,
      out char highSurrogate,
      out char lowSurrogate);

    bool IsHighSurrogate(uint codepoint);

    bool IsLowSurrogate(uint codepoint);

    bool IsSupplementary(uint codepoint);

    bool IsNoncharacter(uint codepoint);

    bool IsWhitespace(uint codepoint);

    bool IsAlphabetic(uint codepoint);

    bool IsCased(uint codepoint);

    bool IsUppercase(uint codepoint);

    bool IsLowercase(uint codepoint);

    bool IsIdStart(uint codepoint);

    bool IsIdContinue(uint codepoint);

    bool IsGraphemeBase(uint codepoint);

    bool IsGraphemeExtend(uint codepoint);

    UnicodeNumericType GetNumericType(uint codepoint);

    UnicodeGeneralCategory GetGeneralCategory(uint codepoint);
  }
}
