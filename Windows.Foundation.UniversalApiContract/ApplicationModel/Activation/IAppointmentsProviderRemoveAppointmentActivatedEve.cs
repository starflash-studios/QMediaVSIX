// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IAppointmentsProviderRemoveAppointmentActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to remove an appointment from the user’s calendar.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1964980920, 2958, 17692, 159, 21, 150, 110, 105, 155, 172, 37)]
  public interface IAppointmentsProviderRemoveAppointmentActivatedEventArgs : 
    IAppointmentsProviderActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the appointment that is provided to the app when the user tries to remove it.</summary>
    /// <returns>The appointment that is removed.</returns>
    RemoveAppointmentOperation RemoveAppointmentOperation { get; }
  }
}
