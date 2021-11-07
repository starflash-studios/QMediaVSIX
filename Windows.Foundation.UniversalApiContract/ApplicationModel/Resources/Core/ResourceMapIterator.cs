﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceMapIterator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Supports iteration over a ResourceMap.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResourceMapIterator : IIterator<IKeyValuePair<string, NamedResource>>
  {
    /// <summary>Gets the current item in the ResourceMap.</summary>
    /// <returns>The key and NamedResource key-value pair for the current item.</returns>
    public extern IKeyValuePair<string, NamedResource> Current { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether there is a current item, or whether the iterator is at the end of the ResourceMap.</summary>
    /// <returns>**TRUE** if the iterator refers to a valid item that is in the map, and otherwise **FALSE**.</returns>
    public extern bool HasCurrent { [MethodImpl] get; }

    /// <summary>Moves the iterator forward to the next item and returns HasCurrent.</summary>
    /// <returns>**TRUE** if the iterator refers to a valid item that is in the map, and otherwise **FALSE**.</returns>
    [MethodImpl]
    public extern bool MoveNext();

    [MethodImpl]
    public extern uint GetMany([Out] IKeyValuePair<string, NamedResource>[] items);
  }
}