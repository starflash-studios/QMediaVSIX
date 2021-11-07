// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceCandidateVectorView
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
  /// <summary>Represents a collection of ResourceCandidate objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceCandidateVectorView : 
    IVectorView<ResourceCandidate>,
    IIterable<ResourceCandidate>
  {
    [MethodImpl]
    public extern ResourceCandidate GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(ResourceCandidate value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] ResourceCandidate[] items);

    [MethodImpl]
    public extern IIterator<ResourceCandidate> First();
  }
}
