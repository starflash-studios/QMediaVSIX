// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentParticipantResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the response from a participant concerning an appointment invitation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AppointmentParticipantResponse
  {
    /// <summary>No response.</summary>
    None,
    /// <summary>The participant might attend the appointment.</summary>
    Tentative,
    /// <summary>The participant accepted the appointment invitation.</summary>
    Accepted,
    /// <summary>The participant declined the appointment invitation.</summary>
    Declined,
    /// <summary>The response is unknown.</summary>
    Unknown,
  }
}
