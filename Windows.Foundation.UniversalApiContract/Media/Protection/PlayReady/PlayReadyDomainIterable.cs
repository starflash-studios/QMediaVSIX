// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyDomainIterable
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Exposes the PlayReady PlayReadyDomain class iterator.</summary>
  [Activatable(typeof (IPlayReadyDomainIterableFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyDomainIterable : IIterable<IPlayReadyDomain>
  {
    /// <summary>Initializes a new instance of the PlayReadyDomainIterable class using the domain account identifier.</summary>
    /// <param name="domainAccountId">The domain account identifier.</param>
    [MethodImpl]
    public extern PlayReadyDomainIterable(Guid domainAccountId);

    [MethodImpl]
    public extern IIterator<IPlayReadyDomain> First();
  }
}
