// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSamplePropertySet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Contains properties for the MediaStreamSample.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [HasVariant]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaStreamSamplePropertySet : 
    IMap<Guid, object>,
    IIterable<IKeyValuePair<Guid, object>>
  {
    [MethodImpl]
    public extern object Lookup(Guid key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(Guid key);

    [MethodImpl]
    public extern IMapView<Guid, object> GetView();

    [MethodImpl]
    public extern bool Insert(Guid key, object value);

    [MethodImpl]
    public extern void Remove(Guid key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<Guid, object>> First();
  }
}
