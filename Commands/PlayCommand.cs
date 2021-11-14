using System.ComponentModel.Design;
using System.Linq;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

using Windows.Media.Control;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class PlayCommand : SimpleCommand<PlayCommand> {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 6000;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    //DTE2 _Dte;
    //int _RootItemID = 0;

    public readonly FauxFirstList<(string Name, MediaSession Session)> Sessions;

    /// <summary>
    /// Initialises a new instance of the <see cref="PlayCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public PlayCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) {
        Sessions = new FauxFirstList<(string, MediaSession)>(("none", null!), MediaSessionManager.Sessions.Values.Select(Ms => (Ms.ToString(), Ms)));

        MediaSessionManager.SessionConnected += (S, _) => {
            Sessions.Add((S.ToString(), S));
        };

        MediaSessionManager.SessionDisconnected += S => {
            Sessions.RemoveAt(Sessions.FindIndex(Tp => Tp.Session == S));
        };

        CurrentChosenOption = MediaSessionManager.Current switch { { } C => MediaSessionManager.Sessions.TryGetIndexOf(C, out int I) ? (uint)I + 1u : 0u,
            _ => 0u
        };
        CurrentChosenOption = 0u;
    }

    public override void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) {
        //base.CtoAddToMenu(Package, CommandService);
        CommandID DynamicItemRootID = new CommandID(new Guid(QMediaVSIXPackage.guidQMediaVSIXPackageToolbarItemCmdSet), (int)QMediaVSIXPackage.cmdidPlayCommand);
        PlayItemMenuCommand DMC = new PlayItemMenuCommand(DynamicItemRootID, IsValidDynamicItem, OnInvokedDynamicItem, OnBeforeQueryStatusDynamicItem);
        CommandService.AddCommand(DMC);
    }

    void OnInvokedDynamicItem( object Sender, EventArgs E ) {
        PlayItemMenuCommand DMC = (PlayItemMenuCommand)Sender;
        Debug.WriteLine($"INVOKED!! {DMC.Text} ({DMC.Checked})");
        if ( DMC.Checked ) { return; }

        if ( DMC.Text == "none" ) {
            Debug.WriteLine("Setting active as null.");
            CurrentChosenOption = 0;
            SessionCommandManager.SetActiveFromCommand(null);
            return;
        }

        int In = Sessions.FindIndex(Tp => Tp.Name == DMC.Text);
        // ReSharper disable once ConvertSwitchStatementToSwitchExpression
        switch (In) {
            case > 0:
                CurrentChosenOption = (uint)In;
                //SessionCommandManager.SetActiveFromCommand(Sessions[In].Session);
                break;
            //case 0:
            //case <= 0:
            default:
                CurrentChosenOption = 0;
                //SessionCommandManager.SetActiveFromCommand(null);
                break;
        }
    }

    void OnBeforeQueryStatusDynamicItem( object Sender, EventArgs E ) {
        PlayItemMenuCommand DMC = (PlayItemMenuCommand)Sender;
        DMC.Enabled = true;
        DMC.Visible = true;

        bool IsRoot = DMC.MatchedCommandId == 0;
        //Debug.WriteLine($"Checking for {DMC.MatchedCommandId}");
        if ( IsRoot ) {
            //Debug.WriteLine(0);
            DMC.Text = Sessions[(int)CurrentChosenOption].Name;
            DMC.Checked = true;
        } else {
            int Delta = DMC.MatchedCommandId - (int)QMediaVSIXPackage.cmdidPlayCommand;
            //Debug.WriteLine(Delta);
            if ( Delta <= CurrentChosenOption ) {
                Delta--;
            }
            DMC.Text = Sessions[Delta].Name;
            DMC.Checked = false;
        }

        DMC.MatchedCommandId = 0;
    }

    static bool IsValidDynamicItem( int CmdID ) {
        ThreadHelper.ThrowIfNotOnUIThread();
        bool CheckA = CmdID >= QMediaVSIXPackage.cmdidPlayCommand;
        bool CheckB = CmdID -  QMediaVSIXPackage.cmdidPlayCommand < MediaSessionManager.Sessions.Count + 1; //+1 for 'none' option
        return CheckA && CheckB;
        //Up to 100 items can be defined. No additional checks are required though, as Visual Studio will never call this function at a delta value greater than 100 anyways.
    }

    uint _CurrentChosenOption;
    public uint CurrentChosenOption {
        get => _CurrentChosenOption;
        set { 
            if ( value != _CurrentChosenOption ) {
                Debug.WriteLine($"Changed to {value}");
                RaisePropertyChanging();
                _CurrentChosenOption = value;
                SessionCommandManager.SetActiveFromCommand(Sessions[(int)value].Session);
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

    public MediaSession? CurrentChosen => CurrentChosenOption < 0 ? null : Sessions[(int)CurrentChosenOption].Session;

    public void ChangeChosenOption( MediaSession? Session ) =>
        CurrentChosenOption = Session switch {
            { } S when Sessions.FindIndex(T => T.Session == S) is var In => (uint)In,
            _                                                            => 0u
        };

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