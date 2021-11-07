// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IIterator`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Supports simple iteration over a collection.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Metadata.Guid(1786374243, 17152, 17818, 153, 102, 203, 182, 96, 150, 62, 225)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IIterator<T>
  {
    /// <summary>Gets the current item in the collection.</summary>
    /// <returns>The current item in the collection.</returns>
    T Current { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the iterator refers to a current item or is at the end of the collection.</summary>
    /// <returns>True if the iterator refers to a valid item in the collection; otherwise, false.</returns>
    bool HasCurrent { [MethodImpl] get; }

    /// <summary>Advances the iterator to the next item in the collection.</summary>
    /// <returns>True if the iterator refers to a valid item in the collection; false if the iterator passes the end of the collection.</returns>
    [MethodImpl]
    bool MoveNext();

    /// <summary>Retrieves all items in the collection.</summary>
    /// <param name="items">The items in the collection.</param>
    /// <returns>The number of items in the collection.</returns>
    [MethodImpl]
    uint GetMany([LengthIs(0), Out] T[] items);
  }
}
