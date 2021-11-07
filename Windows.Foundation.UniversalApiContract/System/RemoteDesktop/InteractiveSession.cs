// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteDesktop.InteractiveSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteDesktop
{
  /// <summary>Provides Remote Desktop information about the current session.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInteractiveSessionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class InteractiveSession
  {
    /// <summary>Indicates whether the calling process is running in a Remote Desktop session.</summary>
    /// <returns>Contains **True** if the current process is running in a remote session or **False** otherwise.</returns>
    public static extern bool IsRemote { [MethodImpl] get; }
  }
}
