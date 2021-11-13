using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.Collections;
using QMediaVSIX.Core.MediaSource.Software;

using Windows.Media.Control;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
[InstanceProvider(nameof(Instance), nameof(InitializeAsync))]
internal sealed class PlayCommand : INotifyPropertyChange {
    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 6000;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <summary>
    /// VS Package that provides this command, not null.
    /// </summary>
    readonly AsyncPackage _Package;

    public readonly FauxFirstList<(string Name, MediaSession Session)> Sessions;

    /// <summary>
    /// Initialises a new instance of the <see cref="PlayCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public PlayCommand( AsyncPackage Package, IMenuCommandService CommandService ) {
        _Package = Package;
        //this.CommandService = CommandService;

        CommandID DynamicItemRootID = new CommandID(new Guid(QMediaVSIXPackage.guidQMediaVSIXPackageToolbarItemCmdSet), (int)QMediaVSIXPackage.cmdidPlayCommand);
        PlayItemMenuCommand DMC = new PlayItemMenuCommand(DynamicItemRootID, IsValidDynamicItem, OnInvokedDynamicItem, OnBeforeQueryStatusDynamicItem);
        CommandService.AddCommand(DMC);

        Sessions = new FauxFirstList<(string, MediaSession)>(("none", null!), MediaSessionManager.Sessions.Values.Select(Ms => (Ms.ToString(), Ms)));
        MediaSessionManager.SessionConnected += (S, _) => {
            Sessions.Add((S.ToString(), S));
        };
        MediaSessionManager.SessionDisconnected += S => {
            Sessions.RemoveAt(Sessions.FindIndex(Tp => Tp.Session == S));
        };
        CurrentChosenOption = MediaSessionManager.Current switch {
            { } C => MediaSessionManager.Sessions.TryGetIndexOf(C, out int I) ? (uint)I + 1u : 0u,
            _     => 0u
        };
    }

    void OnInvokedDynamicItem( object Sender, EventArgs E ) {
        PlayItemMenuCommand DMC = (PlayItemMenuCommand)Sender;
        Debug.WriteLine($"INVOKED!! {DMC.Text} ({DMC.Checked})");
        if ( DMC.Checked ) { return; }

        if ( DMC.Text == "none" ) {
            CurrentChosenOption = 0;
            SessionCommandManager.SetActiveFromCommand(null);
            return;
        }

        int In = Sessions.FindIndex(Tp => Tp.Name == DMC.Text);
        switch (In) {
            case > 0:
                CurrentChosenOption = (uint)In;
                SessionCommandManager.SetActiveFromCommand(Sessions[In].Session);
                break;
            //case 0:
            //case <= 0:
            default:
                CurrentChosenOption = 0;
                SessionCommandManager.SetActiveFromCommand(null);
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
                //Debug.WriteLine("<CurrentOpt");
                Delta--;
            }
            DMC.Text = Sessions[Delta].Name;
            DMC.Checked = false;
        }
        //int DisplayIndex = DMC.MatchedCommandId == 0 ? 0 : DMC.MatchedCommandId - (int)QMediaVSIXPackage.cmdidPlayCommand;
        //if (DMC.MatchedCommandId == 0 ) { return; }
        //bool IsRoot = DMC.MatchedCommandId == 0;
        //int IndexForDisplay = IsRoot ? 1 : DMC.MatchedCommandId - (int)QMediaVSIXPackage.cmdidPlayCommand + 1;
        //DMC.Text = ValidOptions[DisplayIndex];
        //DMC.DynamicItemMatchVerifier += 
        //Do query stuff here (check DMC.MatchedCommandId, and if wanted, set Checked to true)

        //DMC.Checked = DMC.Text == ValidOptions[CurrentChosenOption];
        DMC.MatchedCommandId = 0;
    }

    DateTime? _LastExecuteTime;
    static readonly TimeSpan _Cooldown = TimeSpan.FromMilliseconds(300); //Prevents button bouncing

    bool IsValidDynamicItem( int CmdID ) {
        ThreadHelper.ThrowIfNotOnUIThread();
        if (CmdID == QMediaVSIXPackage.cmdidPlayCommand - 1 ) {
            DateTime Now = DateTime.Now;
            if ( _LastExecuteTime is { } LET ) {
                //Debug.WriteLine($"Last executed @ {LET} ({(Now - LET).TotalSeconds} seconds ago)");
                if ( Now - LET >= _Cooldown ) {
                    //Debug.WriteLine($"At least {_Cooldown.TotalMilliseconds} ms has passed, executing...");
                    _LastExecuteTime = Now;
                    Execute(this, EventArgs.Empty);
                }
            } else {
                //Debug.WriteLine("First execution ever. Ignore this (startup)");
                _LastExecuteTime = Now;
                //Execute(this, EventArgs.Empty);
            }
            return false;
        }
        bool CheckA = CmdID >= QMediaVSIXPackage.cmdidPlayCommand;
        bool CheckB = CmdID -  QMediaVSIXPackage.cmdidPlayCommand < MediaSessionManager.Sessions.Count + 1; //+1 for 'none' option
        return CheckA && CheckB;
        //Up to 100 items can be defined.
    }

    //public 

    //public List<string> ValidOptions = new List<string> { "ChoiceA", "ChoiceB", "ChoiceC", "ChoiceD" };

    uint _CurrentChosenOption;
    public uint CurrentChosenOption {
        get => _CurrentChosenOption;
        set { 
            if ( value != _CurrentChosenOption ) {
                RaisePropertyChanging();
                _CurrentChosenOption = value;
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
            }
        }
    }

    public MediaSession? CurrentChosen => CurrentChosenOption < 0 ? null : Sessions[(int)CurrentChosenOption].Session;

    public void ChangeChosenOption( MediaSession? Session ) =>
        CurrentChosenOption = Session switch {
            { } S when MediaSessionManager.Sessions.GetIndexOf(S) is var In => (uint)In,
            _                                                               => 0
        };

    // ReSharper disable once UnassignedGetOnlyAutoProperty
    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public static PlayCommand? Instance { get; }

    /// <summary>
    /// Initialises the singleton instance of the command.
    /// </summary>
    public static async Task<PlayCommand> InitializeAsync() {
        AsyncPackage Package = QMediaVSIXPackage.Instance;
        
        //Debug.WriteLine("Switching main...");
        await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(Package.DisposalToken);

        //Debug.WriteLine("Retrieving service...");
        OleMenuCommandService CommandService = await Package.GetServiceAsync<IMenuCommandService, OleMenuCommandService>() ?? throw new ArgumentNullException(nameof(CommandService), "No CommandService could be created at this time.");

        return new PlayCommand(Package, CommandService);
    }


    /// <summary>
    /// Gets the service provider from the owner package.
    /// </summary>
    IAsyncServiceProvider ServiceProvider => _Package;

    /// <summary>
    /// This function is the callback used to execute the command when the menu item is clicked.
    /// See the constructor to see how the menu item is associated with this function using
    /// OleMenuCommandService service and MenuCommand class.
    /// </summary>
    /// <param name="Sender">Event sender.</param>
    /// <param name="E">Event args.</param>
    public void Execute( object Sender, EventArgs E ) {
        Debug.WriteLine("Playing media...");
        CurrentChosen?.Play();
    }

    /// <summary>
    /// Sets the command to be enabled, returning <see langword="true"/> if successful.
    /// </summary>
    /// <param name="MakeEnabled">Whether to make the command enabled or disabled. Command is enabled if <see langword="true"/>.</param>
    /// <returns><see langword="true"/> if the change was successful.</returns>
    public bool SetCommandEnabled( bool MakeEnabled = true ) => ChangeEnableable(MakeEnabled);

    /// <summary>
    /// Sets the command to be disabled, returning <see langword="true"/> if successful.
    /// </summary>
    /// <param name="MakeDisabled">Whether to make the command disabled or enabled. Command is disabled if <see langword="true"/>.</param>
    /// <returns><see langword="true"/> if the change was successful.</returns>
    public bool SetCommandDisabled( bool MakeDisabled = true ) => ChangeEnableable(!MakeDisabled);

    internal bool ChangeEnableable( bool EnableCmd ) {
        OleMenuCommandService Mcs = _Package.GetService<IMenuCommandService, OleMenuCommandService>();
        CommandID NewCmdID = new CommandID(CommandSet, CommandId);
        MenuCommand? MC = Mcs.FindCommand(NewCmdID);
        if ( MC is not null ) {
            MC.Enabled = EnableCmd;
            return true;
        }
        Debug.WriteLine($"MenuCommand was unable to be found for {CommandSet} {CommandId} == {NewCmdID}");
        return false;
    }

    /// <inheritdoc />
    public event PropertyChangingEventHandler? PropertyChanging = delegate { };

    /// <inheritdoc />
    public event PropertyChangedEventHandler? PropertyChanged = delegate { };

    /// <inheritdoc />
    public void OnPropertyChanging( object? Sender, [CallerMemberName] string? PropertyName = null ) => PropertyChanging?.Invoke(Sender, new PropertyChangingEventArgs(PropertyName));

    /// <inheritdoc />
    public void OnPropertyChanged( object? Sender, [CallerMemberName] string? PropertyName = null ) => PropertyChanged?.Invoke(Sender, new PropertyChangedEventArgs(PropertyName));

    internal void RaisePropertyChanging( [CallerMemberName] string? PropertyName = null ) => OnPropertyChanging(this, PropertyName);

    internal void RaisePropertyChanged( [CallerMemberName] string? PropertyName = null ) => OnPropertyChanged(this, PropertyName);
}