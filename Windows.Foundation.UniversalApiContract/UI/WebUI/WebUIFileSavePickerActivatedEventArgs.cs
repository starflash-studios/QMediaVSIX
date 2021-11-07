// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.WebUIFileSavePickerActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
using Windows.System;

namespace Windows.UI.WebUI
{
  /// <summary>Provides information about an activated event that fires when the user saves a file through the file picker and selects the app as the location.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebUIFileSavePickerActivatedEventArgs : 
    IFileSavePickerActivatedEventArgs,
    IActivatedEventArgs,
    IFileSavePickerActivatedEventArgs2,
    IActivatedEventArgsDeferral,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the letterbox UI of the file picker that is displayed when the user saves a file and selects the app as the save location.</summary>
    /// <returns>The letterbox UI of the file picker that is displayed when the user saves a file and uses the app as the location.</returns>
    public extern FileSavePickerUI FileSavePickerUI { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The activationKind.fileSavePicker enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the family name of the caller's package.</summary>
    /// <returns>The family name of the caller's package.</returns>
    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the ID of the enterprise that owns the file.</summary>
    /// <returns>The ID of the enterprise that owns the file.</returns>
    public extern string EnterpriseId { [MethodImpl] get; }

    /// <summary>Gets the app activated operation.</summary>
    /// <returns>The activation operation.</returns>
    public extern ActivatedOperation ActivatedOperation { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
