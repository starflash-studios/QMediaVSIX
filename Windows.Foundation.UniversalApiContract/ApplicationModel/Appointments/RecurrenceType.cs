// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.RecurrenceType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  /// <summary>Specifies the recurrence type of an appointment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RecurrenceType
  {
    /// <summary>The appointment is the master appointment for a recurring appointment.</summary>
    Master,
    /// <summary>The appointment is an instance of a recurring appointment.</summary>
    Instance,
    /// <summary>The appointment is an exceptional instance of a recurring appointment.</summary>
    ExceptionInstance,
  }
}
