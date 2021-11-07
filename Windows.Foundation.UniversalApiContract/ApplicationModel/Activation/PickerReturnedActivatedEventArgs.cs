// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.PickerReturnedActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data for the Activated event when it occurs after a picker returns.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PickerReturnedActivatedEventArgs : 
    IPickerReturnedActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets an identifier indicating the picker operation that was performed prior to the activation.</summary>
    /// <returns>An application-defined identifier indicating the picker operation that was performed prior to the activation.</returns>
    public extern string PickerOperationId { [MethodImpl] get; }

    /// <summary>Gets the reason that this app is being activated.</summary>
    /// <returns>The reason that this app is being activated.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before this activation.</summary>
    /// <returns>The execution state of the app before this activation.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object that provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The splash screen object.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }
  }
}
