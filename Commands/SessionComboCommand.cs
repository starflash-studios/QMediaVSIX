using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Core.MediaSource.Software;

namespace QMediaVSIX.Commands;

/// <summary>
/// Command handler
/// </summary>
internal sealed class SessionComboCommand : SimpleCommand<SessionComboCommand> {

    //https://web.archive.org/web/20081120072249/https://dotneteers.net/blogs/divedeeper/archive/2008/07/14/LearnVSXNowPart25.aspx

    /// <summary>
    /// Command ID.
    /// </summary>
    public const int CommandId = 5000;

    public const int GetListCommandId = 5001;

    /// <summary>
    /// Command menu group (command set GUID).
    /// </summary>
    public static readonly Guid CommandSet = new Guid("a36c982e-236d-489b-8703-7e1fc268d77c");

    /// <summary>
    /// Initialises a new instance of the <see cref="SessionComboCommand"/> class.
    /// Adds our command handlers for menu (commands must exist in the command table file)
    /// </summary>
    /// <param name="Package">Owner package, not null.</param>
    /// <param name="CommandService">Command service to add command to, not null.</param>
    public SessionComboCommand( AsyncPackage Package, OleMenuCommandService CommandService ) : base(Package, CommandService) { }

    public override void CtoAddToMenu( AsyncPackage Package, OleMenuCommandService CommandService ) {
        //base.CtoAddToMenu(Package, CommandService);

        Choices = MediaSessionManager.Sessions.Values.Select(NormaliseName).ToArray();
        MediaSessionManager.SessionConnected += MediaSessionManager_SessionConnected;
        _CurrentValue = MediaSessionManager.Current is { } S ? NormaliseName(S) : string.Empty;
        //Choices = 

        //Add main dropdown control
        CommandID MenuCommandID = new CommandID(CommandSet, CommandId);
        OleMenuCommand DropdownCommand = new OleMenuCommand(OnSessionDropdownCombo, MenuCommandID) {
            ParametersDescription = "$"
        };
        CommandService.AddCommand(DropdownCommand);

        //Add "GetList" command
        CommandID GetListCommandID = new CommandID(CommandSet, GetListCommandId);
        MenuCommand GetListCommand = new OleMenuCommand(OnSessionDropdownComboGetList, GetListCommandID);
        CommandService.AddCommand(GetListCommand);
    }

    void MediaSessionManager_SessionConnected( MediaSession Sender, Guid E ) {
        Debug.WriteLine("Session connected.");
        int L = Choices.Length;
        string[] NewChoices = new string[L + 1];
        for ( int I = 0; I < L; I++ ) {
            Debug.WriteLine($"{I}] {Choices[I]}");
            NewChoices[I] = Choices[I];
        }
        Debug.WriteLine($"{L}] {Sender}");
        NewChoices[L] = NormaliseName(Sender);
        //ChangeChoices(Choices);
        Choices = NewChoices;
    }

    void OnSessionDropdownCombo(object Sender, EventArgs E ) {
        if ( E == EventArgs.Empty || E is not OleMenuCmdEventArgs ME ) {
            throw new ArgumentException(nameof(E), $"Event arguments is not of expected type {nameof(OleMenuCmdEventArgs)}, or is empty. (Actual passed argument type is {E.GetType().GetTypeName()})");
        }

        string? NewChoice = ME.InValue as string;
        IntPtr ValOut = ME.OutValue;
        //Invalid scenario: ValOut != IntPtr.Zero && NewChoice != null
        if ( ValOut != IntPtr.Zero ) {
            Marshal.GetNativeVariantForObject(_CurrentValue, ValOut);
        } else if ( NewChoice is not null ) {
            if ( ValidateInput(NewChoice, out MediaSession Session) ) {
                ChangeSession(Session);
                //CurrentValue
            } else {
                throw new ArgumentException(nameof(NewChoice));
            }
        }
    }

    //internal void ChangeChoices(IEnumerable<string?> NewChoices) => NewChoices.UpTo(10).ToArray().CopyTo(Choices, 0);

    //public List<string> Choices = new List<string> { "ChoiceOne", "ChoiceTwo", "ChoiceThree" };
    public string[] Choices = { "ChoiceOne", "ChoiceTwo", "ChoiceThree" };
    //Perhaps 'Choices =' assignments breaks the IntPtr, and hence the UI never updates with new choices. Try a list (without dynamic sessions first), then if that works, use a list instead with dynamic sessions.

    void OnSessionDropdownComboGetList( object Sender, EventArgs E ) {
        if ( E == EventArgs.Empty || E is not OleMenuCmdEventArgs ME ) {
            throw new ArgumentException(nameof(E), $"Event arguments is not of expected type {nameof(OleMenuCmdEventArgs)}, or is empty. (Actual passed argument type is {E.GetType().GetTypeName()})");
        }

        //Debug.WriteLine($"InValue: {ME.InValue} ({ME.InValue?.GetType().GetTypeName()}), OutValue: {ME.OutValue} ({ME.OutValue.GetType().GetTypeName()})");
        Marshal.GetNativeVariantForObject(Choices, ME.OutValue);
    }

    public bool ValidateInput( string Input, out MediaSession Found ) {
        // ReSharper disable once LoopCanBePartlyConvertedToQuery
        foreach ( MediaSession Session in MediaSessionManager.Sessions.Values) {
            if ( NormaliseName(Session).Equals(Input, StringComparison.InvariantCultureIgnoreCase) ) {
                Found = Session;
                return true;
            }
        }
        Found = null!;
        return false;
    }

    string _CurrentValue = string.Empty;
    public string CurrentValue {
        get => _CurrentValue;
        set => RaiseAndSetIfChanged(ref _CurrentValue, value);
    }

    internal static string NormaliseName( MediaSession Session ) => Session.Session.SourceAppUserModelId.TrimEnd(".exe").ToLowerInvariant();

    public void ChangeSession( MediaSession Session ) {
        Debug.WriteLine($"Changing to {Session} due to user input.");
        SessionCommandManager.Active = Session;
        _CurrentValue = NormaliseName(Session);
        //CurrentValue = Session
    }
    //public string CurrentValue;

    /// <summary>
    /// Gets the instance of the command.
    /// </summary>
    public new static SessionComboCommand? Instance { get; } = null;

    /// <inheritdoc />
    public override string Title => "SessionComboCommand";

    /// <inheritdoc />
    protected override int SelfCommandId => CommandId;

    /// <inheritdoc />
    protected override Guid SelfCommandSet => CommandSet;
}