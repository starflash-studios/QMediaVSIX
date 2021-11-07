// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.ExtendedExecutionForegroundReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  /// <summary>Describes the reason for the extended execution request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ExtendedExecutionForegroundReason
  {
    /// <summary>No reason specified.</summary>
    Unspecified,
    /// <summary>To save data.</summary>
    SavingData,
    /// <summary>To play audio.</summary>
    BackgroundAudio,
    /// <summary>To perform any task that requires extended execution time.</summary>
    Unconstrained,
  }
}
