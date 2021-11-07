// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.AppointmentsProviderShowAppointmentDetailsActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to show the details of an appointment.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppointmentsProviderShowAppointmentDetailsActivatedEventArgs : 
    IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs,
    IAppointmentsProviderActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the start date of the appointment instance for which the app should display details.</summary>
    /// <returns>The start date of the appointment instance for which the app should display details.</returns>
    public extern IReference<DateTime> InstanceStartDate { [MethodImpl] get; }

    /// <summary>Gets the local identifier of the appointment for which the app should display details.</summary>
    /// <returns>The local identifier of the appointment for which the app should display details.</returns>
    public extern string LocalId { [MethodImpl] get; }

    /// <summary>Gets the roaming identifier of the appointment for which the app should display details.</summary>
    /// <returns>The roaming identifier of the appointment for which the app should display details.</returns>
    public extern string RoamingId { [MethodImpl] get; }

    /// <summary>Gets the action to be performed by the appointments provider.</summary>
    /// <returns>The action to be performed by the appointments provider.</returns>
    public extern string Verb { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.AppointmentsProvider enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>The execution state of the app before it was activated.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object, which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
