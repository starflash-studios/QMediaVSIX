// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.AppRestartFailureReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Describes the reasons why an app could fail a request to restart.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AppRestartFailureReason
  {
    /// <summary>A restart is already in progress.</summary>
    RestartPending,
    /// <summary>An app must be visible and in the foreground when it calls the restart API.</summary>
    NotInForeground,
    /// <summary>Could not restart for the specified user.</summary>
    InvalidUser,
    /// <summary>Unspecified failure.</summary>
    Other,
  }
}
