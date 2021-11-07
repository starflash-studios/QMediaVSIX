// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemPlatform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values that describe the operating system platforms that a remote system could be running.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum RemoteSystemPlatform
  {
    /// <summary>The OS platform is unknown.</summary>
    Unknown,
    /// <summary>The device is running Windows.</summary>
    Windows,
    /// <summary>The device is running Android.</summary>
    Android,
    /// <summary>The device is running iOS.</summary>
    Ios,
    /// <summary>The device is running Linux.</summary>
    Linux,
  }
}
