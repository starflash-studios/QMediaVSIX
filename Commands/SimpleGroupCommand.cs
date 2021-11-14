#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal abstract class SimpleGroupCommand<T> : SessionCommand<T> where T : SimpleGroupCommand<T> {
    public abstract int MinCommandId { get; }
    public abstract int MaxCommandId { get; }

    //readonly CustomIndexing _CommandIdIndexing;

    protected SimpleGroupCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }// => _CommandIdIndexing = new CustomIndexing(MinCommandId.CountUntil(MaxCommandId))
    // ReSharper restore VirtualMemberCallInConstructor

    public override void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) {
        base.CtoAddToMenu(Package, CommandService);
        for ( int I = MinCommandId; I <= MaxCommandId; I++ ) {
            CommandID CmdID = new CommandID(SelfCommandSet, I);
            OleMenuCommand MC = new OleMenuCommand(MC_OnItemClicked, CmdID);
            MC.BeforeQueryStatus += MC_BeforeQueryStatus;
            CommandService.AddCommand(MC);
        }
    }

    public abstract bool IsChecked( int CmdId );

    void MC_BeforeQueryStatus( object Sender, EventArgs E ) {
        OleMenuCommand CMD = (OleMenuCommand)Sender;
        Debug.WriteLine($"Query {CMD.CommandID}");

        if (CMD.CommandID.ID < MinCommandId || CMD.CommandID.ID > MaxCommandId ) {
            throw new IndexOutOfRangeException($"{nameof(CMD.CommandID.ID)} is out of the acceptable range of command ids.");
        }

        CMD.Checked = IsChecked(CMD.CommandID.ID);
    }

    public abstract void OnClick( OleMenuCommand CMD );

    void MC_OnItemClicked( object Sender, EventArgs E ) {
        //Debug.WriteLine("Click");
        //if ( SessionCommandManager.Active is not { } ) { return; }
        OleMenuCommand CMD = (OleMenuCommand)Sender;
        Debug.WriteLine($"Click from {CMD.CommandID}");

        if ( CMD.CommandID.ID < MinCommandId || CMD.CommandID.ID > MaxCommandId ) {
            throw new IndexOutOfRangeException($"{nameof(CMD.CommandID.ID)} is out of the acceptable range of command ids.");
        }

        OnClick(CMD);
    }

    public virtual bool MoveFirstActiveToFront => true;

    public abstract bool ShouldCommandBeEnabled( int CmdId );

    public override void OnCurrentSessionChanged() {
        //if ( SessionCommandManager.Active is { } A ) {
        for ( int CmdId = MinCommandId; CmdId <= MaxCommandId; CmdId++ ) {
            ChangeEnableable(Package, new CommandID(SelfCommandSet, CmdId), ShouldCommandBeEnabled(CmdId));
        }
        //} else {
        //    base.OnCurrentSessionChanged();
        //}
    }

    /// <inheritdoc />
    public override void Execute( object Sender, EventArgs E ) {
        Debug.WriteLine("Huh?");
    }

    //internal class CustomIndexing : IList<int> {
    //    readonly List<int> _Ls;

    //    public CustomIndexing( List<int>? Ls = null ) => _Ls = Ls ?? new List<int>();
    //    public CustomIndexing() : this(Ls: null) { }
    //    public CustomIndexing( params int[] Ints ) : this(new List<int>(Ints)) { }
    //    public CustomIndexing( IEnumerable<int> Enum ) : this(new List<int>(Enum)) { }

    //    IList<int> ExportList {
    //        get {
    //            switch ( First ) {
    //                case { } F:
    //                    List<int> NewLs = new List<int>(_Ls);
    //                    NewLs.Remove(F);
    //                    NewLs.Insert(0, F);
    //                    return NewLs;
    //                default:
    //                    return _Ls;
    //            }
    //        }
    //    }

    //    public int? First { get; set; }

    //    /// <inheritdoc />
    //    public IEnumerator<int> GetEnumerator() => ExportList.GetEnumerator();

    //    /// <inheritdoc />
    //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    //    /// <inheritdoc />
    //    public void Add( int Item ) => _Ls.Add(Item);

    //    /// <inheritdoc />
    //    public void Clear() {
    //        _Ls.Clear();
    //        First = null;
    //    }

    //    /// <inheritdoc />
    //    public bool Contains( int Item ) => _Ls.Contains(Item);

    //    /// <inheritdoc />
    //    public void CopyTo( int[] Array, int ArrayIndex ) => ExportList.CopyTo(Array, ArrayIndex);

    //    /// <inheritdoc />
    //    public bool Remove( int Item ) => _Ls.Remove(Item);

    //    /// <inheritdoc />
    //    public int Count => _Ls.Count;

    //    /// <inheritdoc />
    //    public bool IsReadOnly => false;

    //    /// <inheritdoc />
    //    public int IndexOf( int Item ) {
    //        if ( First is { } F && Item == F ) {
    //            return 0;
    //        }
    //        return _Ls.IndexOf(Item);
    //    }

    //    /// <inheritdoc />
    //    public void Insert( int Index, int Item ) {
    //        if ( Index == 0 ) {
    //            throw new ArgumentException("Cannot insert into first position.");
    //        }
    //        _Ls.Insert(Index, Item);
    //    }

    //    /// <inheritdoc />
    //    public void RemoveAt( int Index ) {
    //        if ( Index == 0 ) {
    //            if (First is not null ) {
    //                First = null;
    //            } else {
    //                throw new ArgumentException("Cannot remove first when there is no first.");
    //            }
    //        }
    //    }

    //    /// <inheritdoc />
    //    public int this[ int Index ] {
    //        get => ExportList[Index];
    //        set {
    //            if ( Index == 0 ) {
    //                First = value;
    //            } else {
    //                _Ls[Index] = value; 
    //            }
    //        }
    //    }
    //}
}