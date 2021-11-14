#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace QMediaVSIX.Core;

public static class Extensions {
	public static IEnumerable<T> NotNull<T>( this IEnumerable<T?> Enumerable ) {
		// ReSharper disable once LoopCanBeConvertedToQuery
		foreach( T? Element  in Enumerable ) {
			if (Element is not null ) {
				yield return Element;
			}
		}
	}

	public static IEnumerable<T?> GetEnumerable<T>( this IEnumerator<T?> Enumerator ) {
		while ( Enumerator.MoveNext() ) {
			yield return Enumerator.Current;
		}
	}

	public static bool Any<T> ( this IEnumerable<T?> Enumerable, Func<T?, bool> Predicate ) => System.Linq.Enumerable.Any(Enumerable, Predicate);

	public static bool SafeEquals<T>( this T? ItemA, T? ItemB ) => ItemA is null ? ItemB is null : ItemB is not null && Equals(ItemA, ItemB);

	public static ICollection<T> AsCollection<T>( this IList<T> List ) => new Collection<T>(List);

	public static ICollection<T> AsCollection<T>( this IEnumerable<T> Enumerable ) => AsCollection(Enumerable.ToList());

	public static bool Any<T>( this IEnumerable<T> Enumerable, Func<T, bool> Predicate, out T Found ) {
		// ReSharper disable once LoopCanBePartlyConvertedToQuery
		foreach(T Item in Enumerable ) {
			if ( Predicate(Item) ) {
				Found = Item;
				return true;
			}
		}
		Found = default!;
		return false;
	}

	public static bool ForAllUnless<T>( this T[] Array, Action<T> Action, Func<T, bool> Predicate, Action<T> Caught ) {
		if ( Any(Array, Predicate, out T Found) ) {
			Caught(Found);
		}
		foreach ( T Item in Array ) {
			Action(Item);
		}
		return true;
		//if ( Array.All(Predicate) ) {
		//	ForAll(Array, Action);
		//	return true;
		//}
		//return false;
	}

	public static void ForAll<T>(this IEnumerable<T> Enumerable, Action<T> Action) {
		foreach(T Element in Enumerable ) {
			Action(Element);
		}
	}

	public static void ForAll<T>( this IEnumerable<T> Enumerable, Func<Action<T>> ActionFunc ) => ForAll(Enumerable, ActionFunc.Invoke());

	public static bool TryFind<T>(this IList<T> Enumerable, out T Found, out int Index, Predicate<T> Predicate ) {
		lock ( Enumerable ) {
			int C = Enumerable.Count;
			for ( Index = 0; Index < C; Index++ ) {
				Found = Enumerable[Index];
				if ( Predicate(Found) ) {
					return true;
				}
			}
		}

		Found = default!;
		return false;
	}

	public static void CopyTo<T>( this IEnumerable<T> Enumerable, Array Array, int ArrayIndex ) => Enumerable.ToArray().CopyTo(Array, ArrayIndex);

	public static void CopyTo<T>( this IEnumerable<T> Enumerable, T[] Array, int ArrayIndex ) => Enumerable.ToArray().CopyTo(Array, ArrayIndex);

	public static Guid GetGuid( this object Obj ) {
		using ( MD5 Md = MD5.Create() ) {
			switch ( Obj.ToString() ) {
				case { } Str:
					byte[] Bytes = Encoding.Default.GetBytes(Str);
					byte[] CryptoBytes = Md.ComputeHash(Bytes);
					return new Guid(CryptoBytes);
				default:
					return Guid.Empty;
			}
		}
	}

	public static string WithCallStack( this string? Message ) => $"{Message}\n\t{Environment.StackTrace.Replace("\n", "\n\t")}";

	public static void AddRange<T>(this IList<T> Obv, IEnumerable<T> Items ) {
		lock ( Obv ) {
			foreach ( T Item in Items ) {
				Obv.Add(Item);
			}
		}
	}

	public static T? FirstNotNull<T>(this IEnumerable<T?> Enumerable) {
		foreach (T? Item in Enumerable ) {
			if ( Item is { } I ) {
				return I;
			}
		}
		return default;
	}

	public static string CatchNull( this string? Str, string WhenNull ) => Str ?? WhenNull;

	public static string CatchNull( this string? Str, string Fallback, params string?[] Alternatives ) => Str ?? FirstNotNull(Alternatives) ?? Fallback;

	public static string CatchEmpty( this string? Str, string WhenNullOrEmpty ) => Str.IsNullOrEmpty() ? WhenNullOrEmpty : Str!;

	public static string CatchEmpty( this string? Str, string Fallback, params string?[] Alternatives ) {
		if ( Str.IsNullOrEmpty() ) {
			// ReSharper disable once LoopCanBePartlyConvertedToQuery
			foreach (string? Alt in Alternatives ) {
				if ( !Alt.IsNullOrEmpty() ) {
					return Alt!;
				}
			}
			return Fallback;
		}
		return Str!;
	}

	public static string TrimEnd( this string Str, string Trim ) {
		int L = Trim.Length;
		while ( Str.EndsWith(Trim) ) {
			Str = Str[..^L];
		}
		return Str;
	}

	public static string CatchWhitespace( this string? Str, string WhenNullEmptyOrWhitespace ) => Str.IsNullOrWhiteSpace() ? WhenNullEmptyOrWhitespace : Str!;

	public static string CatchWhitespace( this string? Str, string Fallback, params string?[] Alternatives ) {
		if ( Str.IsNullOrWhiteSpace() ) {
			// ReSharper disable once LoopCanBePartlyConvertedToQuery
			foreach ( string? Alt in Alternatives ) {
				if ( !Alt.IsNullOrWhiteSpace() ) {
					return Alt!;
				}
			}
			return Fallback;
		}
		return Str!;
	}

	/// <summary>
	/// <inheritdoc cref="string.IsNullOrEmpty(string)"/>
	/// <para/>Implementation courtesy of <see href="https://stackoverflow.com/a/64066801/11519246">ims1234</see>.
	/// </summary>
	/// <remarks>
	/// This code is licensed under Creative Commons Attribution-ShareAlike 4.0 Internal (CC BY-SA 4.0).
	/// <br/>You are free to:
	/// <list type="bullet"><item>
	/// <term>Share</term>
	/// <description> copy and redistribute the material in any medium or format</description>
	/// </item><item>
	/// <term>Adapt</term>
	/// <description> remix, transform, and build upon the material for any purpose, even commercially.</description>
	/// </item></list>
	/// This is a human-readable summary of (and not a substitute for) the <see href="https://creativecommons.org/licenses/by-sa/4.0/legalcode">license</see>.
	/// <para/>For more information, please visit: <see href="https://creativecommons.org/licenses/by-sa/4.0/"/>
	/// </remarks>
	public static bool IsNullOrEmpty( [NotNullWhen(false)] this string? Data ) => string.IsNullOrEmpty(Data);

	/// <summary>
	/// <inheritdoc cref="string.IsNullOrWhiteSpace(string)"/>
	/// <para/>Implementation courtesy of <see href="https://stackoverflow.com/a/64066801/11519246">ims1234</see>.
	/// </summary>
	/// <remarks>
	/// This code is licensed under Creative Commons Attribution-ShareAlike 4.0 Internal (CC BY-SA 4.0).
	/// <br/>You are free to:
	/// <list type="bullet"><item>
	/// <term>Share</term>
	/// <description> copy and redistribute the material in any medium or format</description>
	/// </item><item>
	/// <term>Adapt</term>
	/// <description> remix, transform, and build upon the material for any purpose, even commercially.</description>
	/// </item></list>
	/// This is a human-readable summary of (and not a substitute for) the <see href="https://creativecommons.org/licenses/by-sa/4.0/legalcode">license</see>.
	/// <para/>For more information, please visit: <see href="https://creativecommons.org/licenses/by-sa/4.0/"/>
	/// </remarks>
	public static bool IsNullOrWhiteSpace( [NotNullWhen(false)] this string? Data ) => string.IsNullOrWhiteSpace(Data);
}