// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IAppointmentsProviderReplaceAppointmentActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated to replace an appointment in the user’s calendar.</summary>
  [Guid(357677012, 43393, 16487, 138, 98, 5, 36, 228, 173, 225, 33)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAppointmentsProviderReplaceAppointmentActivatedEventArgs : 
    IAppointmentsProviderActivatedEventArgs,
    IActivatedEventArgs
  {
    /// <summary>Gets the appointment that is provided to the app when the user tries to replace it.</summary>
    /// <returns>The appointment that is replaced.</returns>
    ReplaceAppointmentOperation ReplaceAppointmentOperation { get; }
  }
}
