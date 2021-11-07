// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to show the details of an appointment.</summary>
  [Guid(962130021, 38977, 19621, 153, 155, 136, 81, 152, 185, 239, 42)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs : 
    IAppointmentsProviderActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the start date of the appointment instance for which the app should display details.</summary>
    /// <returns>The start date of the appointment instance for which the app should display details.</returns>
    IReference<DateTime> InstanceStartDate { get; }

    /// <summary>Ges the local identifier of the appointment for which the app should display details.</summary>
    /// <returns>The local identifier of the appointment for which the app should display details.</returns>
    string LocalId { get; }

    /// <summary>Gets the roaming identifier of the appointment for which the app should display details.</summary>
    /// <returns>The roaming identifier of the appointment for which the app should display details.</returns>
    string RoamingId { get; }
  }
}
