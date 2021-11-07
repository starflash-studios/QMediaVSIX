// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemStatusType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains the values that describe a remote system's status type. This is a simplification of the RemoteSystemStatus enumeration and is used to construct a RemoteSystemStatusTypeFilter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RemoteSystemStatusType
  {
    /// <summary>The remote system can have any availability status and be discoverable.</summary>
    Any,
    /// <summary>The remote system must have a Status property value of **Available** in order to be discoverable.</summary>
    Available,
  }
}
