// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains the values that describe an app's access to use the **Remote Systems** feature.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RemoteSystemAccessStatus
  {
    /// <summary>Access is denied for an unknown reason.</summary>
    Unspecified,
    /// <summary>Access is allowed</summary>
    Allowed,
    /// <summary>Access has been denied to this particular app by this particular user.</summary>
    DeniedByUser,
    /// <summary>Access is denied to this app by the System; the app hasn't requested the proper capability.</summary>
    DeniedBySystem,
  }
}
