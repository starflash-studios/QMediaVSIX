// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.WwwFormUrlDecoder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Parses a URL query string, and exposes the results as a read-only vector (list) of name-value pairs from the query string.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IWwwFormUrlDecoderRuntimeClassFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WwwFormUrlDecoder : 
    IWwwFormUrlDecoderRuntimeClass,
    IVectorView<IWwwFormUrlDecoderEntry>,
    IIterable<IWwwFormUrlDecoderEntry>
  {
    /// <summary>Creates and initializes a new instance of the WwwFormUrlDecoder class.</summary>
    /// <param name="query">The URL to parse.</param>
    [MethodImpl]
    public extern WwwFormUrlDecoder(string query);

    /// <summary>Gets the first name-value pair that has the specified name, as obtained from the constructing Uniform Resource Identifier (URI) query string.</summary>
    /// <param name="name">The name of the value to get.</param>
    /// <returns>The first value in list order that corresponds with *name*.</returns>
    [MethodImpl]
    public extern string GetFirstValueByName(string name);

    [MethodImpl]
    public extern IIterator<IWwwFormUrlDecoderEntry> First();

    [MethodImpl]
    public extern IWwwFormUrlDecoderEntry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(IWwwFormUrlDecoderEntry value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IWwwFormUrlDecoderEntry[] items);
  }
}
