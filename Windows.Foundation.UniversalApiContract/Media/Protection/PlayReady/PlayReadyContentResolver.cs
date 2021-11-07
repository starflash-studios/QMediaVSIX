// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyContentResolver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Receives multiple service request objects that are necessary to enable the playback ability for a given content header.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPlayReadyContentResolver), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class PlayReadyContentResolver
  {
    /// <summary>Proactively initiates the service request chain for a given content header.</summary>
    /// <param name="contentHeader">Content header for the content the app wants to resolve all necessary service request operations.</param>
    /// <returns>The first service request operation required to resolve the content.</returns>
    [MethodImpl]
    public static extern IPlayReadyServiceRequest ServiceRequest(
      PlayReadyContentHeader contentHeader);
  }
}
