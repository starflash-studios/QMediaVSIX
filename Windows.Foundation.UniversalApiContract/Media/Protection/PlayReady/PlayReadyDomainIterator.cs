// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyDomainIterator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides for iteration of the PlayReadyDomain class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyDomainIterator : IIterator<IPlayReadyDomain>
  {
    /// <summary>Gets the current item in the PlayReady domain collection.</summary>
    /// <returns>The current item in the PlayReady domain collection.</returns>
    public extern IPlayReadyDomain Current { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is a current item or the iterator is at the end of the PlayReady domain collection.</summary>
    /// <returns>**true** if the iterator refers to a valid item that is in the collection or **false** if the iterator is at the end of the collection.</returns>
    public extern bool HasCurrent { [MethodImpl] get; }

    /// <summary>Advances the enumerator to the next item in the collection.</summary>
    /// <returns>**true** if the iterator refers to a valid item that is in the collection or **false** if the iterator is at the end of the collection.</returns>
    [MethodImpl]
    public extern bool MoveNext();

    /// <summary>Retrieves all items in the PlayReady domain collection.</summary>
    /// <param name="items">The items in the collection.</param>
    /// <returns>The number of items in the collection.</returns>
    [MethodImpl]
    public extern uint GetMany([Out] IPlayReadyDomain[] items);
  }
}
