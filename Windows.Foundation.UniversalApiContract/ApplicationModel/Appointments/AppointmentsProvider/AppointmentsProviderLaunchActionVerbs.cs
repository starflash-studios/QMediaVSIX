// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentsProvider.AppointmentsProviderLaunchActionVerbs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.AppointmentsProvider
{
  /// <summary>Represents the object associated with retrieving the operation of the appointments provider.</summary>
  [Static(typeof (IAppointmentsProviderLaunchActionVerbsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppointmentsProviderLaunchActionVerbsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class AppointmentsProviderLaunchActionVerbs
  {
    /// <summary>Gets the show-appointment-details action that the appointments provider performs.</summary>
    /// <returns>The show-appointment-details action</returns>
    public static extern string ShowAppointmentDetails { [MethodImpl] get; }

    /// <summary>Gets the add-appointment action that the appointments provider performs.</summary>
    /// <returns>The add-appointment action</returns>
    public static extern string AddAppointment { [MethodImpl] get; }

    /// <summary>Gets the replace-appointment action that the appointments provider performs.</summary>
    /// <returns>The replace-appointment action</returns>
    public static extern string ReplaceAppointment { [MethodImpl] get; }

    /// <summary>Gets the remove-appointment action that the appointments provider performs.</summary>
    /// <returns>The remove-appointment action</returns>
    public static extern string RemoveAppointment { [MethodImpl] get; }

    /// <summary>Gets the show-time-frame action of an appointment that the appointments provider performs.</summary>
    /// <returns>The show-time-frame action of an appointment</returns>
    public static extern string ShowTimeFrame { [MethodImpl] get; }
  }
}
