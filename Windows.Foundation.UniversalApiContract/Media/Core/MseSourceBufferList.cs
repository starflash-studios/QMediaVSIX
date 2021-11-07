// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseSourceBufferList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a list of media source extensions (MSE) source buffers.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MseSourceBufferList : IMseSourceBufferList
  {
    /// <summary>Occurs when a MseSourceBuffer object is added.</summary>
    public extern event TypedEventHandler<MseSourceBufferList, object> SourceBufferAdded;

    /// <summary>Occurs when a MseSourceBuffer object is removed.</summary>
    public extern event TypedEventHandler<MseSourceBufferList, object> SourceBufferRemoved;

    /// <summary>Gets the list of MseSourceBuffer objects.</summary>
    /// <returns>The list of MseSourceBuffer.</returns>
    public extern IVectorView<MseSourceBuffer> Buffers { [MethodImpl] get; }
  }
}
