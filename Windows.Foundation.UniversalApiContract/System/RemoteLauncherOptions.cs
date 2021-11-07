// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteLauncherOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the options used to launch the default app for URI on a remote device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteLauncherOptions : IRemoteLauncherOptions
  {
    /// <summary>Creates an instance of the RemoteLauncherOptions class.</summary>
    [MethodImpl]
    public extern RemoteLauncherOptions();

    /// <summary>Specifies the URI of the web site to view if the app to handle the URI can't be launched on the remote device.</summary>
    /// <returns>The URI of a website.</returns>
    public extern Uri FallbackUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A list of package family names that should be used to launch the URI on the remote device. The first one in the list should be the preferred application to launch on the remote system (device).</summary>
    /// <returns>The list of package family names.</returns>
    public extern IVector<string> PreferredAppIds { [MethodImpl] get; }
  }
}
