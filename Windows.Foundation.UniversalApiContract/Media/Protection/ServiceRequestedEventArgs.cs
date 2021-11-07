// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ServiceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Protection
{
  /// <summary>Contains event data for a MediaProtectionManager object when a service is requested.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ServiceRequestedEventArgs : 
    IServiceRequestedEventArgs,
    IServiceRequestedEventArgs2
  {
    /// <summary>Contains the service request.</summary>
    /// <returns>Contains the service request.</returns>
    public extern IMediaProtectionServiceRequest Request { [MethodImpl] get; }

    /// <summary>Returns an indication of the completion of the service request.</summary>
    /// <returns>An object that contains an indication of the completion of the service request.</returns>
    public extern MediaProtectionServiceCompletion Completion { [MethodImpl] get; }

    /// <summary>Gets the MediaPlaybackItem associated with the service request.</summary>
    /// <returns>The MediaPlaybackItem associated with the service request.</returns>
    public extern MediaPlaybackItem MediaPlaybackItem { [MethodImpl] get; }
  }
}
