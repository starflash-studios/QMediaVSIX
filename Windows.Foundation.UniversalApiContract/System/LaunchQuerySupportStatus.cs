// Decompiled with JetBrains decompiler
// Type: Windows.System.LaunchQuerySupportStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies whether an app is available that supports activation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LaunchQuerySupportStatus
  {
    /// <summary>An app that handles the activation is available and may be activated.</summary>
    Available,
    /// <summary>No app is installed to handle the activation.</summary>
    AppNotInstalled,
    /// <summary>An app that handles the activation is installed but not available because it is being updated by the store or it was installed on a removable device that is not available.</summary>
    AppUnavailable,
    /// <summary>The app does not handle the activation.</summary>
    NotSupported,
    /// <summary>An unknown error was encountered while determining whether an app supports the activation.</summary>
    Unknown,
  }
}
