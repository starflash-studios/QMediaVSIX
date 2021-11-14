#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Linq;

using Windows.Media.Control;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

#endregion

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PlayCommand : MenuControllerCommand<PlayCommand, MediaSession> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 6000;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <summary>
    /// Initialises a new instance of the <see cref="PlayCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public PlayCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService, MediaSessionManager.Sessions.Values.Select(Ms => (Ms.ToString(), Ms)), 0u) {

        MediaSessionManager.SessionConnected += (S, _) => {
            Items.Add((S.ToString(), S));
        };

        MediaSessionManager.SessionDisconnected += S => {
            Items.RemoveAt(Items.FindIndex(Tp => Tp.Stored == S));
        };

        //CurrentChosenOption = MediaSessionManager.Current switch { { } C => MediaSessionManager.Sessions.TryGetIndexOf(C, out int I) ? (uint)I + 1u : 0u,
        //    _ => 0u
        //};
        CurrentChosenOption = 0u;
    }

    public override uint CurrentChosenOption {
        get => _CurrentChosenOption;
        set { 
            if ( value != _CurrentChosenOption ) {
                Debug.WriteLine($"Changed to {value}");
                RaisePropertyChanging();
                _CurrentChosenOption = value;
                SessionCommandManager.SetActiveFromCommand(Items[(int)value].Stored);
                RaisePropertyChanged();
                switch ( CurrentChosen ) {
                    case { } C: //set button enabled relative to whether the status is playing or not
                        SetCommandEnabled(C.PlaybackStatus != GlobalSystemMediaTransportControlsSessionPlaybackStatus.Playing);
                        //when value changes, change SessionCommand current
                        //likewise when SessionCommandManager changes, change this
                        //generic MakeLinkedBinding() method? (avoid infinite loop for property change notifications)
                        break;
                    default: //when null, disable button
                        SetCommandDisabled();
                        break;
                }
            } else {
                Debug.WriteLine($"Equal change ignored (wanted from: {_CurrentChosenOption} to {value})");
            }
        }
    }

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static PlayCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "PlayCommand";

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;

    public override void Execute( object Sender, EventArgs E ) {
        Debug.WriteLine("Playing media...");
        CurrentChosen?.Play();
    }
}