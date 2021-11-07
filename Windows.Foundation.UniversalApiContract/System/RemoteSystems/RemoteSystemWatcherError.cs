// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemWatcherError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values that describe a watcher error, which may stop discovery.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum RemoteSystemWatcherError
  {
    /// <summary>Discovery stopped for an unknown reason.</summary>
    Unknown,
    /// <summary>Discovery of cloud remote systems failed because Internet connection was lost or is unavailable.</summary>
    InternetNotAvailable,
    /// <summary>Discovery of cloud remote systems for a web account failed because authentication of that web account failed.</summary>
    AuthenticationError,
  }
}
