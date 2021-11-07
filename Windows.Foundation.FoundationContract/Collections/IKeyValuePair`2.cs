// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IKeyValuePair`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents a key-value pair. This is typically used as a constraint type when you need to encapsulate two type parameters into one to satisfy the constraints of another generic interface.</summary>
  /// <typeparam name="K">
  /// </typeparam>
  /// <typeparam name="V">
  /// </typeparam>
  [Guid(45422889, 49604, 19070, 137, 64, 3, 18, 181, 193, 133, 0)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IKeyValuePair<K, V>
  {
    /// <summary>Gets the key of the key-value pair.</summary>
    /// <returns>The key.</returns>
    K Key { [MethodImpl] get; }

    /// <summary>Gets the value of the key-value pair.</summary>
    /// <returns>The value.</returns>
    V Value { [MethodImpl] get; }
  }
}
