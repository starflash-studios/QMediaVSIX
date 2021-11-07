// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialAppState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>The state of the application on the remote device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DialAppState
  {
    /// <summary>The state cannot be determined.</summary>
    Unknown,
    /// <summary>The app is stopped on the remote device.</summary>
    Stopped,
    /// <summary>The app is running on the remote device.</summary>
    Running,
    /// <summary>An error occurred while attempting to retrieve the state.</summary>
    NetworkFailure,
  }
}
