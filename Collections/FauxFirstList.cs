#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Collections;
using System.Collections.Generic;

#endregion

namespace QMediaVSIX.Collections;

public class FauxFirstList<T> : IList<T> {
    readonly List<T> _Ls = new List<T>();

    public T FirstItem { get; set; }

    public void ReplaceAll( IList<T> OtherList ) {
        lock ( _Ls ) {
            _Ls.Clear();
            _Ls.AddRange(OtherList);
        }
    }

    public FauxFirstList( T FirstItem ) => this.FirstItem = FirstItem;

    public FauxFirstList( T FirstItem, IEnumerable<T> Enumerable ) {
        _Ls = new List<T>(Enumerable);
        this.FirstItem = FirstItem;
    }

    public FauxFirstList( T FirstItem, IList<T> Ls ) {
        _Ls = new List<T>(Ls);
        this.FirstItem = FirstItem;
    }

    public FauxFirstList( T FirstItem, params T[] Items ) {
        _Ls = new List<T>(Items);
        this.FirstItem = FirstItem;
    }

    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator() {
        yield return FirstItem;
        foreach( T Item in _Ls ) {
            yield return Item;
        }
    }

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public void Add( T Item ) => _Ls.Add(Item);

    /// <inheritdoc />
    public void Clear() => _Ls.Clear();

    /// <inheritdoc />
    public bool Contains( T Item ) => _Ls.Contains(Item);

    /// <inheritdoc />
    public void CopyTo( T[] Array, int ArrayIndex ) {
        List<T> Return = new List<T>(_Ls);
        Return.Insert(0, FirstItem);
        Return.CopyTo(Array, ArrayIndex);
    }

    /// <inheritdoc />
    public bool Remove( T Item ) => _Ls.Remove(Item);

    /// <inheritdoc />
    public int Count => _Ls.Count + 1;

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public int IndexOf( T Item ) => _Ls.IndexOf(Item) + 1;

    /// <inheritdoc />
    public void Insert( int Index, T Item ) => _Ls.Insert(Index, Item);

    /// <inheritdoc />
    public void RemoveAt( int Index ) {
        if (Index == 0 ) {
            throw new ArgumentException($"Cannot delete the first item in a {nameof(FauxFirstList<T>)}.");
        }
        _Ls.RemoveAt(Index - 1);
    }

    /// <inheritdoc />
    public T this[ int Index ] {
        get => Index switch {
            0 => FirstItem,
            _ => _Ls[Index - 1]
        };
        set {
            switch ( Index ) {
                case 0:
                    FirstItem = value;
                    break;
                default:
                    _Ls[Index - 1] = value;
                    break;
            }
        }
    }
}