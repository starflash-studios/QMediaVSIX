// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.DevicePairingActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information when an app is activated as a result of a device pairing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DevicePairingActivatedEventArgs : 
    IDevicePairingActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the DeviceInformation object for the device object that is being paired.</summary>
    /// <returns>The information of the device object.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user the app was activated for.</summary>
    /// <returns>The user the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
