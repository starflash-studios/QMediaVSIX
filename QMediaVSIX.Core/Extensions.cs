using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;

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

	public static ICollection<T> AsCollection<T>( this IEnumerable<T> Enumerable ) => AsCollection(List: Enumerable.ToList());

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
	public static string CatchEmpty( this string? Str, string WhenNullOrEmpty ) => string.IsNullOrEmpty(Str) ? WhenNullOrEmpty : Str;
	public static string CatchEmpty( this string? Str, string Fallback, params string?[] Alternatives ) {
		if ( string.IsNullOrEmpty(Str) ) {
			// ReSharper disable once LoopCanBePartlyConvertedToQuery
			foreach (string? Alt in Alternatives ) {
				if ( !string.IsNullOrEmpty(Alt) ) {
					return Alt;
				}
			}
			return Fallback;
		}
		return Str;
	}
	public static string CatchWhitespace( this string? Str, string WhenNullEmptyOrWhitespace ) => string.IsNullOrWhiteSpace(Str) ? WhenNullEmptyOrWhitespace : Str;
	public static string CatchWhitespace( this string? Str, string Fallback, params string?[] Alternatives ) {
		if ( string.IsNullOrWhiteSpace(Str) ) {
			// ReSharper disable once LoopCanBePartlyConvertedToQuery
			foreach ( string? Alt in Alternatives ) {
				if ( !string.IsNullOrWhiteSpace(Alt) ) {
					return Alt;
				}
			}
			return Fallback;
		}
		return Str;
	}
}