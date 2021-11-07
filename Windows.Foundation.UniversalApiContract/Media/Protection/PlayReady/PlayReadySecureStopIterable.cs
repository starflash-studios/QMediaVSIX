// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadySecureStopIterable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Enumerates PlayReady secure stop service requests.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPlayReadySecureStopIterableFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadySecureStopIterable : IIterable<IPlayReadySecureStopServiceRequest>
  {
    /// <summary>Initializes a new instance of the PlayReadySecureStopIterable class.</summary>
    /// <param name="publisherCertBytes">The raw binary body of the publisher certificate.</param>
    [MethodImpl]
    public extern PlayReadySecureStopIterable([Range(0, 2147483647)] byte[] publisherCertBytes);

    [MethodImpl]
    public extern IIterator<IPlayReadySecureStopServiceRequest> First();
  }
}
