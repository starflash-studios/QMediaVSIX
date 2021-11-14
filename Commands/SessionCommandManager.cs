#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Controls;
using QMediaVSIX.Core.MediaSource.Software;
using QMediaVSIX.Types;

#endregion

namespace QMediaVSIX.Commands;

[InstanceProvider(nameof(Instance), nameof(Init), nameof(OnFinishedInit))]
public class SessionCommandManager : NotifyPropertyChange {

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static SessionCommandManager? Instance { get; } = null;

    public static SessionCommandManager Init() => new SessionCommandManager();

    static MediaSession? _Active = null;
    public static MediaSession? Active {
        get => _Active;
        set {
            if ( Instance is null ) {
                Debug.WriteLine("No instance, ignoring change.");
                //If no instance is created yet, there's no reason to raise property change notifications as there will be no receivers anyways. Just change the value and return.
                _Active = value;
                return;
            }
            //if ( value is null || value != _Active ) {
                Instance.RaisePropertyChanging();
                Debug.WriteLine($"Active session changed to {value?.ToString() ?? "<NULL>"}");
                _Active = value;

                if ( !_ActiveChangedByCommand ) {
                    PlayCommand.Instance?.ChangeChosenOption(value);
                }

                Instance.RaisePropertyChanged();
            //} else {
            //    Debug.WriteLine("Session was already the same. Ignoring.");
            //}
        }
    }

    static bool _ActiveChangedByCommand = false;
    public static void SetActiveFromCommand( MediaSession? Session ) {
        _ActiveChangedByCommand = true;
        Debug.WriteLine($"Setting active to {Session}");
        Active = Session;
        _ActiveChangedByCommand = false;
    }

    public static Action<Func<Task>> AsyncRunner = null!;

    public SessionCommandManager() {
        if ( Instance is not null ) {
            throw new NotSupportedException("May not create multiple instances.");
        }
        AsyncRunner = Tk => _ = ThreadHelper.JoinableTaskFactory.RunAsync(Tk);
        foreach (MediaSession Session in MediaSessionManager.Sessions.Values ) {
            Session.AsyncRunner = AsyncRunner;
        }
        MediaSessionManager.SessionConnected += ( S, _ ) => {
            S.AsyncRunner = AsyncRunner;
        };
        MediaSessionManager.CurrentSessionChanged += ( _, E, _ ) => Active = E;
    }

    public static void RunWhenInitialised(InitialisedEventArgs Act) {
        if ( Instance is { } I ) {
            Act(I);
        } else {
            Initialised += Act;
        }
    }

    static void OnFinishedInit() {
        OnInitialised(Instance!);
        Active = null;
    }

    #region Initialised Event

    /// <summary>
    /// Event arguments for the <see cref="Initialised"/> event (<inheritdoc cref="Initialised"/>).
    /// </summary>
    /// <param name="Sender">The event raiser.</param>
    public delegate void InitialisedEventArgs( SessionCommandManager Sender );

    /// <summary>
    /// Invoked when a <see cref="SessionCommandManager"/> instance is created.
    /// </summary>
    public static event InitialisedEventArgs Initialised = delegate { };

    /// <summary>
    /// Raises the <see cref="Initialised"/> event (<inheritdoc cref="Initialised"/>)
    /// </summary>
    /// <param name="Sender">The event raiser.</param>
    public static void OnInitialised( SessionCommandManager Sender ) => Initialised(Sender);

    #endregion
}