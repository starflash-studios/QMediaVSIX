using System.Collections;

namespace QMediaVSIX.Core.Collections;

public class NonRemovableList<T> : NotifyCollectionChange<T>, IList<T> {
    readonly List<T> _Ls;

    public NonRemovableList( List<T>? Ls = null ) => _Ls = Ls ?? new List<T>();
    public NonRemovableList() : this(Ls: null) { }
    public NonRemovableList( params T[] Arr ) : this(Ls: new List<T>(Arr)) { }
    public NonRemovableList( IEnumerable<T> Enum ) : this(Ls: new List<T>(Enum)) { }

    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator() => _Ls.GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public void Add( T Item ) {
        _Ls.Add(Item);
        OnCollectionItemAdded(Item);
    }

    /// <inheritdoc />
    public void Clear() => throw new NotSupportedException("Items cannot be removed from a non-removable list.");

    /// <inheritdoc />
    public bool Contains( T Item ) => _Ls.Contains(Item);

    /// <inheritdoc />
    public void CopyTo( T[] Array, int ArrayIndex ) => _Ls.CopyTo(Array, ArrayIndex);

    /// <inheritdoc />
    public bool Remove( T Item ) => throw new NotSupportedException("Items cannot be removed from a non-removable list.");

    /// <inheritdoc />
    public int Count => _Ls.Count;

    /// <inheritdoc />
    public bool IsReadOnly => false;

    /// <inheritdoc />
    public int IndexOf( T Item ) => _Ls.IndexOf(Item);

    /// <inheritdoc />
    public void Insert( int Index, T Item ) {
        lock ( this ) {
            _Ls.Insert(Index, Item);
            OnCollectionItemInserted(Item, Index);
            int L = _Ls.Count;
            for ( int I = Index + 1; I < L; I++ ) {
                OnCollectionItemMoved(_Ls[I], I - 1, I);
            }
        }
    }

    /// <inheritdoc />
    public void RemoveAt( int Index ) => throw new NotSupportedException("Items cannot be removed from a non-removable list.");

    /// <inheritdoc />
    public T this[int Index] {
        get => _Ls[Index];
        set =>
            //OnCollectionItemRemoved(_Ls[Index]);
            _Ls[Index] = value;
        //OnCollectionItemInserted(value, Index);
    }
}