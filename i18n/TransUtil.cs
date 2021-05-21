#region Copyright (C) 2017-2020  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#nullable enable

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace QMediaVSIX.i18n {
    public static class TransUtil {
        public static readonly Lang Current = new Lang(CultureInfo.CurrentCulture);
        public static readonly Lang CurrentUI = new Lang(CultureInfo.CurrentUICulture);
        public static readonly Lang En = new Lang("en");
        public static readonly Lang EnUS = new Lang("en-us");
        public static readonly Lang EnGB = new Lang("en-gb");
        public static readonly Lang EnAU = new Lang("en-au", EnGB);
        public static readonly Lang JaJP = new Lang("ja-jp");
    }

    public readonly struct Trans {
        public readonly struct TransKey {
            public readonly string Text;
            public readonly Lang Expected;

            public TransKey( Lang Expected, string Text ) {
                this.Expected = Expected;
                this.Text = Text;
            }

            public static implicit operator TransKey( (Lang L, string S) T ) => new TransKey(T.L, T.S);
            public static implicit operator TransKey( (string S, Lang L) T ) => new TransKey(T.L, T.S);

            public override string ToString() => $"{{{Expected}:'{Text}'}}";
        }

        public readonly ReadOnlyCollection<TransKey> Keys;
        public readonly string DefKey;

        public Trans( string DefKey, ReadOnlyCollection<TransKey>? Keys = null ) {
            this.DefKey = DefKey;
            this.Keys = Keys ?? new ReadOnlyCollection<TransKey>(Array.Empty<TransKey>());
        }

        public Trans( string DefKey, IEnumerable<TransKey> Keys ) : this(DefKey, new ReadOnlyCollection<TransKey>(Keys.ToArray())) { }
        public Trans( string DefKey, params TransKey[] Keys ) : this(DefKey, new ReadOnlyCollection<TransKey>(Keys)) { }
        public Trans( string DefKey, params (Lang, string)[] Keys ) : this(DefKey, new ReadOnlyCollection<TransKey>(Keys.Select(Key => (TransKey)Key).ToArray())) { }
        public Trans( string DefKey, params (string, Lang)[] Keys ) : this(DefKey, new ReadOnlyCollection<TransKey>(Keys.Select(Key => (TransKey)Key).ToArray())) { }

        /// <summary>
        /// Returns the related translation, given the requested destination language (<paramref name="CurrentLang"/>).
        /// </summary>
        /// <param name="CurrentLang">The requested language to translate to.</param>
        /// <remarks><b><i>Remarks:</i></b><br/>Translations follow the given priorities in order:
        /// <list type="table">
        ///     <listheader>
        ///         <term>№, Match Type</term>
        ///         <description>Example</description>
        ///     </listheader>
        ///     <item>
        ///         <term>#1, Direct Match</term>
        ///         <description>i.e. 'en-AU'</description>
        ///     </item>
        ///     <item>
        ///         <term>#2, Variant Match</term>
        ///         <description>i.e. if 'en-au', maybe 'en-GB'</description>
        ///     </item>
        ///     <item>
        ///         <term>#3, Root Match</term>
        ///         <description>i.e. if 'en-au', maybe 'en'</description>
        ///     </item>
        ///     <item>
        ///         <term>#4, Family Match</term>
        ///         <description>i.e. if 'en-au', maybe 'en-US'</description>
        ///     </item>
        ///     <item>
        ///         <term>#5, Loose Match</term>
        ///         <description>i.e. if 'ja', maybe 'zh'</description>
        ///     </item>
        ///     <item>
        ///         <term>#6, Default / Placeholder</term>
        ///         <description>there must be a placeholder, but direct translation should be avoided at all costs.</description>
        ///     </item>
        /// </list>
        /// <para/>
        /// <example><br/><b><i>Example #1:</i></b><br/>Given 'en-AU' (English, Australia)
        ///     <list type="number">
        ///         <item>If there is a direct 'en-AU' translation, use it.</item>
        ///         <item>If there is a 'en-GB' translation (being 'en-AU' is a variant of 'en-GB'), use it.</item>
        ///         <item>If there is a standard english ('en') translation, use it.</item>
        ///         <item>If there is any other english translation (i.e. 'en-US'), use it.</item>
        ///         <item>If there is some other cousin (i.e. latin), use that.</item>
        ///         <item>Use the fallback translation.</item>
        ///     </list>
        /// <br/><b><i>Example #2:</i></b><br/>Given 'ja-JP' (Japan, Japanese)
        ///     <list type="number">
        ///         <item>If there is a direct 'ja-JP' translation, use it.</item>
        ///         <item><i>- no other (documented/standardised) variants of 'ja' exist ; will be ignored -</i></item>
        ///         <item>If there is a standard japanese ('ja') translation, use it.</item>
        ///         <item><i>- no other (documented/standardised) variants of 'ja' exist ; will be ignored -</i></item>
        ///         <item>If there is a chinese ('zh', 'zh-*') translation, use that. (since japanese and chinese use some similar characters, there may be some rough understanding - greater than that of a default translation)</item>
        ///         <item>Use the fallback translation.</item>
        ///     </list>
        /// </example>
        /// </remarks>
        /// <returns>A translated string.</returns>
        public string Get( Lang CurrentLang ) {
            //All languages in the same family (i.e. 'en', 'en-au', 'en-gb', etc.)
            List<TransKey> Fam = new List<TransKey>();
            //The root of the language (i.e. 'en')
            TransKey? LangRoot = null;
            //Language variants of the current language (i.e. 'en-au' is a variant of 'en-gb', and prefers it over others of the same family, such as 'en-us')
            List<TransKey> Var = new List<TransKey>();
            //Other languages loosely related to the current language (i.e. 'ja' may be loosely related to 'zh')
            List<TransKey> Rel = new List<TransKey>();

            string[] RelatedRoots = CurrentLang.Related.Select(Relat => Relat.Family).ToArray();

            //Debug.WriteLine($">{CurrentLang}");
            //Debug.WriteLine($">{CurrentLang.Family}");
            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (TransKey Key in Keys) {
                //Debug.WriteLine($"\t{Key.Expected}:");
                if (CurrentLang.IsSameFamily(Key.Expected)) {
                    if (CurrentLang.IsSameTag(Key.Expected, false)) {
                        //Debug.WriteLine("\t\tSame Tag.");
                        return Key.Text;
                    }

                    if (string.IsNullOrEmpty(Key.Expected.Tag)) {
                        //Debug.WriteLine("\t\tRoot.");
                        LangRoot = Key;
                    } else {
                        //Debug.WriteLine("\t\tFamily.");
                        Fam.Add(Key);
                    }
                } else {
                    //Debug.WriteLine("\t\tDifferent Family.");
                }

                if (CurrentLang.Variants.Contains(Key.Expected)) {
                    //Debug.WriteLine("\t\t\tVariant.");
                    Var.Add(Key);
                }

                if (RelatedRoots.Contains(Key.Expected.Family)) {
                    //Debug.WriteLine("\t\t\tLoosely related through language-family relations.");
                    Rel.Add(Key);
                }
            }

            //Translation priority: Direct Match > Relatives > Language Root > Family > Cousins
            //Example #1: Given 'en-AU' (English, Australia)
            //1. If there is a direct en-AU translation, use it.
            //2. If there is a en-GB translation (being en-AU is a variant of en-GB), use it.
            //3. If there is a standard english (en) translation, use it.
            //4. If there is any other english translation (i.e. en-US), use it.
            //5. If there is some other cousin (i.e. latin), use that.
            //6. Use the fallback translation.

            //Example #2: Given 'ja-JP' (Japan, Japanese)
            //1. If there is a direct ja-JP translation, use it.
            //2. - no other (documented/standardised) variants of ja exist ; will be ignored -
            //3. If there is a standard japanese translation, use it.
            //4. - no other (documented/standardised) variants of ja exist ; will be ignored -
            //5. If there is a chinese translation, use that. (since japanese and chinese use some similar characters, there may be some rough understanding - greater than that of a default translation)
            //6. Use the fallback translation.

            if (Var.Count > 0) { return Var.First().Text; }

            if (LangRoot.HasValue) { return LangRoot.Value.Text; }

            if (Fam.Count > 0) { return Fam.First().Text; }

            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (Rel.Count > 0) { return Rel.First().Text; }

            return DefKey;
        }

        /// <summary>
        /// Equivalent to <see cref="Get(Lang)"/>, just with a predefined translation <see cref="Lang"/>.
        /// If <paramref name="UseUICulture"/> == <see langword="true"/>, <see cref="TransUtil.CurrentUI"/> is used; otherwise <see cref="TransUtil.Current"/> is used instead.
        /// <inheritdoc cref="Get(Lang)"/>
        /// </summary>
        /// <param name="UseUICulture">Whether or not to use the current UI culture. If <see langword="true"/>, the current UI culture is used; otherwise the current culture is used instead.</param>
        /// <remarks><inheritdoc cref="Get(Lang)"/></remarks>
        /// <returns><inheritdoc cref="Get(Lang)"/></returns>
        public string Get( bool UseUICulture = true ) => Get(UseUICulture ? TransUtil.CurrentUI : TransUtil.Current);

        public override string ToString() => $"['{DefKey}';{string.Join(",", Keys)}]";
    }

    public readonly struct Lang : IEquatable<Lang> {
        public string Family { get; }
        public string? Tag { get; }
        public Lang[] Variants { get; }
        public Lang[] Related { get; }

        public Lang( string Family, string Tag, params Lang[] Variants ) : this(Family: Family, Tag: Tag, Related: null, Variants: Variants) { }

        public Lang( string Family, string Tag, Lang[]? Related, params Lang[] Variants ) {
            this.Family = Family.ToUpperInvariant();
            this.Tag = Tag.ToUpperInvariant();
            this.Related = Related ?? Array.Empty<Lang>();
            this.Variants = Variants;
        }

        public Lang( string FullTag, params Lang[] Variants ) : this(FullTag: FullTag, Related: null, Variants: Variants) { }

        public Lang( string FullTag, Lang[]? Related, params Lang[] Variants ) {
            int HyphInd = FullTag.IndexOf('-');
            if (HyphInd >= 0) {
                Family = FullTag.Substring(0, HyphInd).ToUpperInvariant();
                Tag = FullTag.Substring(HyphInd + 1, FullTag.Length - HyphInd - 1).ToUpperInvariant();
            } else {
                Family = FullTag.ToUpperInvariant();
                Tag = null;
            }

            this.Related = Related ?? Array.Empty<Lang>();
            this.Variants = Variants;
        }

        public Lang( CultureInfo Cult, params Lang[] Variants ) : this(Cult: Cult, Related: null, Variants: Variants) { }
        public Lang( CultureInfo Cult, Lang[]? Related, params Lang[] Variants ) : this(Cult.Name, Related, Variants) { }

        public bool IsSameFamily( Lang L ) => Family == L.Family;
        public bool IsSameFamily( params Lang[] LArr ) => LArr.All(IsSameFamily);

        public bool IsSameFamily( Lang L, bool CheckTag ) => Family == L.Family && (!CheckTag || Tag == L.Tag);

        public bool IsSameFamily( bool CheckTag = true, params Lang[] LArr ) {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (Lang L in LArr) {
                if (!IsSameFamily(L, CheckTag)) { return false; }
            }

            return true;
        }

        public bool IsSameTag( Lang L, bool CheckFamily = true ) => (!CheckFamily || Family == L.Family) && Tag == L.Tag;

        public bool IsSameTag( bool CheckFamily = true, params Lang[] LArr ) {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (Lang L in LArr) {
                if (!IsSameTag(L, CheckFamily)) { return false; }
            }

            return true;
        }

        public bool SharesVariance(Lang L) => Variants.Any(L.IsSameFamily) || L.Variants.Any(IsSameFamily);

        public bool SharesLooseRelation(Lang L) => Related.Any(L.IsSameFamily) || L.Related.Any(IsSameFamily);

        public override string ToString() {
            StringBuilder SB = new StringBuilder();
            SB.Append(Family.ToLowerInvariant());
            if (Tag != null) {
                SB.Append('-');
                SB.Append(Tag);
            }

            return SB.ToString();
        }

        /// <inheritdoc />
        public bool Equals( Lang Other ) => IsSameTag(Other, true);

        public bool Equals( Lang Other, bool CheckTag ) => IsSameFamily(Other, CheckTag);

        /// <inheritdoc />
        public override bool Equals( object? Obj ) => Obj is Lang Other && Equals(Other);

        public bool Equals( object? Obj, bool CheckTag ) => Obj is Lang Other && Equals(Other, CheckTag);

        /// <inheritdoc />
        public override int GetHashCode() {
            unchecked { return (Family.GetHashCode() * 397) ^ (Tag != null ? Tag.GetHashCode() : 0); }
        }

        public static bool operator ==( Lang Left, Lang Right ) => Left.Equals(Right);
        public static bool operator !=( Lang Left, Lang Right ) => !Left.Equals(Right);
    }
}