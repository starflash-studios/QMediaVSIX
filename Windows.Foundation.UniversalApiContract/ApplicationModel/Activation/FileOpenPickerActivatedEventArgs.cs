// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an activated event that fires when the user tries to pick files or folders that are provided by the app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileOpenPickerActivatedEventArgs : 
    IFileOpenPickerActivatedEventArgs,
    IActivatedEventArgs,
    IFileOpenPickerActivatedEventArgs2,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the letterbox UI of the file picker that is displayed when the user wants to pick files or folders that are provided by the app.</summary>
    /// <returns>The letterbox UI of the file picker that is displayed when the user wants to pick files or folders that are provided by the app.</returns>
    public extern FileOpenPickerUI FileOpenPickerUI { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.FileOpenPicker enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets a SplashScreen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>The package family name of the app that launched your app.</summary>
    /// <returns>The caller's package family name.</returns>
    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
