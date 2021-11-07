// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmSessionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  /// <summary>The various states of an MDM session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum MdmSessionState
  {
    /// <summary>The MDM session has not started.</summary>
    NotStarted,
    /// <summary>The MDM session is starting.</summary>
    Starting,
    /// <summary>The MDM session is connecting to the server.</summary>
    Connecting,
    /// <summary>The MDM session is communicating with the server.</summary>
    Communicating,
    /// <summary>The MDM session has an alert status available.</summary>
    AlertStatusAvailable,
    /// <summary>The MDM session is retrying.</summary>
    Retrying,
    /// <summary>The MDM session is complete.</summary>
    Completed,
  }
}
