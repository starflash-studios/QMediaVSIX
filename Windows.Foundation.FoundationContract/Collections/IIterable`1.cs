// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IIterable`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Exposes an iterator that supports simple iteration over a collection of a specified type.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Guid(4205151722, 25108, 16919, 175, 218, 127, 70, 222, 88, 105, 179)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IIterable<T>
  {
    /// <summary>Returns an iterator for the items in the collection.</summary>
    /// <returns>The iterator.</returns>
    [MethodImpl]
    IIterator<T> First();
  }
}
