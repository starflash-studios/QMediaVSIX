﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.AppointmentsProviderReplaceAppointmentActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to replace an appointment in the user’s calendar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentsProviderReplaceAppointmentActivatedEventArgs : 
    IAppointmentsProviderReplaceAppointmentActivatedEventArgs,
    IAppointmentsProviderActivatedEventArgs,
    IActivatedEventArgs,
    IActivatedEventArgsWithUser
  {
    /// <summary>Gets the appointment that is provided to the app when the user tries to replace it.</summary>
    /// <returns>The appointment that is replaced.</returns>
    public extern ReplaceAppointmentOperation ReplaceAppointmentOperation { [MethodImpl] get; }

    /// <summary>Gets the action to be performed by the appointments provider.</summary>
    /// <returns>The action to be performed by the appointments provider.</returns>
    public extern string Verb { [MethodImpl] get; }

    /// <summary>Gets the activation type.</summary>
    /// <returns>The ActivationKind.AppointmentsProvider enumeration value.</returns>
    public extern ActivationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the execution state of the app before it was activated.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    /// <summary>Gets the splash screen object, which provides information about the transition from the splash screen to the activated app.</summary>
    /// <returns>The object that provides splash screen information.</returns>
    public extern SplashScreen SplashScreen { [MethodImpl] get; }

    /// <summary>Gets the user that the app was activated for.</summary>
    /// <returns>The user that the app was activated for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}