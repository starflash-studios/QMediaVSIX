// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObjectCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  /// <summary>Represents an iterable collection of Pnp device objects.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PnpObjectCollection : IVectorView<PnpObject>, IIterable<PnpObject>
  {
    [MethodImpl]
    public extern PnpObject GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(PnpObject value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] PnpObject[] items);

    [MethodImpl]
    public extern IIterator<PnpObject> First();
  }
}
