// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.SearchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about the activated event that fires when the user searches the app from the Search charm and the app isn't the main app on screen.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SearchActivatedEventArgs : 
    ISearchActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    ISearchActivatedEventArgsWithLinguisticDetails,
    IViewSwitcherProvider,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the text that the user wants the app to search for. The user entered this text into the search box of the search pane.</summary>
    /// <returns>The text to search for.</returns>
    public extern string QueryText { [MethodImpl] get; }

    /// <summary>Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language currently associated with the user's text input device.</summary>
    /// <returns>The Internet Engineering Task Force (IETF) BCP 47 standard language tag.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.Search enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the ApplicationExecutionState enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets a SplashScreen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets a SearchPaneQueryLinguisticDetails object that provides info about query text that the user enters through an Input Method Editor (IME).</summary>
    /// <returns>The object that provides info about query text.</returns>
    public extern SearchPaneQueryLinguisticDetails LinguisticDetails { [MethodImpl] get; }

    /// <summary>Gets the view switcher object that allows you to set the view for the application.</summary>
    /// <returns>Use the ActivationViewSwitcher to show or switch the view in response to the activation. The value will be **null** in hosted scenarios such as Share and File Picker activations.</returns>
    public extern ActivationViewSwitcher ViewSwitcher { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
