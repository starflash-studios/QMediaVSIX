// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIFileActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Provides data when an app is activated because it is the app associated with a file.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUIFileActivatedEventArgs : 
    IFileActivatedEventArgs,
    IActivatedEventArgs,
    IApplicationViewActivatedEventArgs,
    IActivatedEventArgsDeferral,
    IFileActivatedEventArgsWithNeighboringFiles,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the files for which the app was activated.</summary>
    /// <returns>The StorageFile objects representing the files being passed to the app.</returns>
    public extern IVectorView<IStorageItem> Files { [MethodImpl] get; }

    /// <summary>Gets the action associated with the activated file.</summary>
    /// <returns>The action.</returns>
    public extern string Verb { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the identifier for the currently shown app view.</summary>
    /// <returns>The identifier for the currently shown app view.</returns>
    public extern int CurrentlyShownApplicationViewId { [MethodImpl] get; }

    /// <summary>Gets the app activation operation.</summary>
    /// <returns>The activation operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the neighboring files of the files for which the app was activated.</summary>
    /// <returns>The StorageFile objects that represent the neighboring files of the files being passed to the app.</returns>
    public extern StorageFileQueryResult NeighboringFilesQuery { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
