// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumeralSystemIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Contains the numeral system identifiers for the supported numeral systems, as static properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (INumeralSystemIdentifiersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (INumeralSystemIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class NumeralSystemIdentifiers
  {
    /// <summary>Gets the identifier for the Brahmi decimal numeral system.</summary>
    /// <returns>The string "Brah", which identifies the Brahmi decimal numeral system.</returns>
    public static extern string Brah { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Osmanya decimal numeral system.</summary>
    /// <returns>The string "Osma", which identifies the Osmanya decimal numeral system.</returns>
    public static extern string Osma { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using MathBold characters.</summary>
    /// <returns>The string "MathBold", which identifies the decimal numeral system using MathBold characters.</returns>
    public static extern string MathBold { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using MathDbl characters.</summary>
    /// <returns>The string "MathDbl", which identifies the decimal numeral system using MathDbl characters.</returns>
    public static extern string MathDbl { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using MathSans characters.</summary>
    /// <returns>The string "MathSans", which identifies the decimal numeral system using MathSans characters.</returns>
    public static extern string MathSans { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using MathSanb characters.</summary>
    /// <returns>The string "MathSanb", which identifies the decimal numeral system using MathSanb characters.</returns>
    public static extern string MathSanb { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using MathMono characters.</summary>
    /// <returns>The string "MathMono", which identifies the decimal numeral system using MathMono characters.</returns>
    public static extern string MathMono { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using ZmthBold (Mathematical notation) characters.</summary>
    /// <returns>The string "ZmthBold", which identifies the decimal numeral system using ZmthBold (Mathematical notation) characters.</returns>
    public static extern string ZmthBold { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using ZmthDbl (Mathematical notation) characters.</summary>
    /// <returns>The string "ZmthDbl", which identifies the decimal numeral system using ZmthDbl (Mathematical notation) characters.</returns>
    public static extern string ZmthDbl { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using ZmthSans (Mathematical notation) characters.</summary>
    /// <returns>The string "ZmthSans", which identifies the decimal numeral system using ZmthSans (Mathematical notation) characters.</returns>
    public static extern string ZmthSans { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using ZmthSanb (Mathematical notation) characters.</summary>
    /// <returns>The string "ZmthSanb", which identifies the decimal numeral system using ZmthSanb (Mathematical notation) characters.</returns>
    public static extern string ZmthSanb { [MethodImpl] get; }

    /// <summary>Gets the identifier for the decimal numeral system using ZmthMono (Mathematical notation) characters.</summary>
    /// <returns>The string "ZmthMono", which identifies the decimal numeral system using ZmthMono (Mathematical notation) characters.</returns>
    public static extern string ZmthMono { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Arabic-Indic decimal numeral system.</summary>
    /// <returns>The string "Arab", which identifies the Arabic-Indic decimal numeral system. This system has the digits ٠١٢٣٤٥٦٧٨٩ which correspond to the Latin digits 0-9.</returns>
    public static extern string Arab { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Extended Arabic-Indic decimal numeral system.</summary>
    /// <returns>The string "ArabExt", which identifies the Extended Arabic-Indic decimal numeral system. This system has the digits ۰۱۲۳۴۵۶۷۸۹ which correspond to the Latin digits 0-9.</returns>
    public static extern string ArabExt { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Balinese decimal numeral system.</summary>
    /// <returns>The string "Bali", which identifies the Balinese decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Bali { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Bangla decimal numeral system.</summary>
    /// <returns>The string "Beng", which identifies the Bangla decimal numeral system. This system has the digits ০১২৩৪৫৬৭৮৯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Beng { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Cham decimal numeral system.</summary>
    /// <returns>The string "Cham", which identifies the Cham decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Cham { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Devanagari decimal numeral system.</summary>
    /// <returns>The string "Deva", which identifies the Devanagari decimal numeral system. This system has the digits ०१२३४५६७८९ which correspond to the Latin digits 0-9.</returns>
    public static extern string Deva { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Latin decimal numeral system using full-width characters.</summary>
    /// <returns>The string "FullWide", which identifies the Latin decimal numeral system using full-width characters. This system has the digits ０１２３４５６７８９ which correspond to the Latin digits 0-9.</returns>
    public static extern string FullWide { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Gujarati decimal numeral system.</summary>
    /// <returns>The string "Gujr", which identifies the Gujarati decimal numeral system. This system has the digits ૦૧૨૩૪૫૬૭૮૯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Gujr { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Gurmukhi decimal numeral system.</summary>
    /// <returns>The string "Guru", which identifies the Gurmukhi decimal numeral system. This system has the digits ੦੧੨੩੪੫੬੭੮੯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Guru { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Han decimal numeral system.</summary>
    /// <returns>The string "HaniDec", which identifies the Han decimal numeral system. This system has the digits 〇一二三四五六七八九 which correspond to the Latin digits 0-9.</returns>
    public static extern string HaniDec { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Javanese decimal numeral system.</summary>
    /// <returns>The string "Java", which identifies the Javanese decimal numeral system. This system has the digits ꧐꧑꧒꧓꧔꧕꧖꧗꧘꧙ which correspond to the Latin digits 0-9.</returns>
    public static extern string Java { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Kayah Li decimal numeral system.</summary>
    /// <returns>The string "Kali", which identifies the Kayah Li decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Kali { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Khmer decimal numeral system.</summary>
    /// <returns>The string "Khmr", which identifies the Khmer decimal numeral system. This system has the digits ០១២៣៤៥៦៧៨៩ which correspond to the Latin digits 0-9.</returns>
    public static extern string Khmr { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Kannada decimal numeral system.</summary>
    /// <returns>The string "Knda", which identifies the Kannada decimal numeral system. This system has the digits ೦೧೨೩೪೫೬೭೮೯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Knda { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Tai Tham Hora decimal numeral system.</summary>
    /// <returns>The string "Lana", which identifies the Tai Tham Hora decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Lana { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Tai Tham Tham decimal numeral system.</summary>
    /// <returns>The string "LanaTham", which identifies the Tai Tham Tham decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string LanaTham { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Laoo decimal numeral system.</summary>
    /// <returns>The string "Laoo", which identifies the Laoo decimal numeral system. This system has the digits ۰۱۲۳۴۵۶۷۸۹ which correspond to the Latin digits 0-9.</returns>
    public static extern string Laoo { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Latin decimal numeral system.</summary>
    /// <returns>The string "Latn", which identifies the Latin decimal numeral system. This system has the Latin digits 0123456789.</returns>
    public static extern string Latn { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Lepcha decimal numeral system.</summary>
    /// <returns>The string "Lepc", which identifies the Lepcha decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Lepc { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Limbu decimal numeral system.</summary>
    /// <returns>The string "Limb", which identifies the Limbu decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Limb { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Malayalam decimal numeral system.</summary>
    /// <returns>The string "Mlym", which identifies the Malayalam decimal numeral system. This system has the digits ൦൧൨൩൪൫൬൭൮൯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Mlym { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Mongolian decimal numeral system.</summary>
    /// <returns>The string "Mong", which identifies the Mongolian decimal numeral system. This system has the digits ᠐᠑᠒᠓᠔᠕᠖᠗᠘᠙ which correspond to the Latin digits 0-9.</returns>
    public static extern string Mong { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Meetei Mayek decimal numeral system.</summary>
    /// <returns>The string "Mtei", which identifies the Meetei Mayek decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Mtei { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Myanmar decimal numeral system.</summary>
    /// <returns>The string "Mymr", which identifies the Myanmar decimal numeral system. This system has the digits ၀၁၂၃၄၅၆၇၈၉ which correspond to the Latin digits 0-9.</returns>
    public static extern string Mymr { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Myanmar Shan decimal numeral system.</summary>
    /// <returns>The string "MymrShan", which identifies the Myanmar Shan decimal numeral system. This system has the digits ႐႑႒႓႔႕႖႗႘႙ which correspond to the Latin digits 0-9.</returns>
    public static extern string MymrShan { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Nko decimal numeral system.</summary>
    /// <returns>The string "Nkoo", which identifies the Nko decimal numeral system. This system has the digits ߀߁߂߃߄߅߆߇߈߉ which correspond to the Latin digits 0-9.</returns>
    public static extern string Nkoo { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Ol Chiki decimal numeral system.</summary>
    /// <returns>The string "Olck", which identifies the Ol Chiki decimal numeral system. This system has the digits ᱐᱑᱒᱓᱔᱕᱖᱗᱘᱙ which correspond to the Latin digits 0-9.</returns>
    public static extern string Olck { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Odia decimal numeral system.</summary>
    /// <returns>The string "Orya", which identifies the Odia decimal numeral system. This system has the digits ୦୧୨୩୪୫୬୭୮୯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Orya { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Saurashtra decimal numeral system.</summary>
    /// <returns>The string "Saur", which identifies the Saurashtra decimal numeral system. This system uses the following Unicode values:&lt;table&gt;</returns>
    public static extern string Saur { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Sundanese decimal numeral system.</summary>
    /// <returns>The string "Sund", which identifies the Sundanese decimal numeral system. This system uses the following Unicode values:</returns>
    public static extern string Sund { [MethodImpl] get; }

    /// <summary>Gets the identifier for the New Tai Lue decimal numeral system.</summary>
    /// <returns>The string "Talu", which identifies the New Tai Lue decimal numeral system. This system has the digits ᧐᧑᧒᧓᧔᧕᧖᧗᧘᧙ which correspond to the Latin digits 0-9.</returns>
    public static extern string Talu { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Tamil decimal numeral system.</summary>
    /// <returns>The string "TamlDec", which identifies the Tamil decimal numeral system. This system has the digits ௦௧௨௩௪௫௬௭௮௯ which correspond to the Latin digits 0-9.</returns>
    public static extern string TamlDec { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Telugu decimal numeral system.</summary>
    /// <returns>The string "Telu", which identifies the Telugu decimal numeral system. This system has the digits ౦౧౨౩౪౫౬౭౮౯ which correspond to the Latin digits 0-9.</returns>
    public static extern string Telu { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Thai decimal numeral system.</summary>
    /// <returns>The string "Thai", which identifies the Thai decimal numeral system. This system has the digits ๐๑๒๓๔๕๖๗๘๙ which correspond to the Latin digits 0-9.</returns>
    public static extern string Thai { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Tibetan decimal numeral system.</summary>
    /// <returns>The string "Tibt", which identifies the Tibetan decimal numeral system. This system has the digits ༠༡༢༣༤༥༦༧༨༩ which correspond to the Latin digits 0-9.</returns>
    public static extern string Tibt { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Vai decimal numeral system.</summary>
    /// <returns>The string "Vaii", which identifies the Vai decimal numeral system. This system has the digits ꘠꘡꘢꘣꘤꘥꘦꘧꘨꘩ which correspond to the Latin digits 0-9.</returns>
    public static extern string Vaii { [MethodImpl] get; }
  }
}
