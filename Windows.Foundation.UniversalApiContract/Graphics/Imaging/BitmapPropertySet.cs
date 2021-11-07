// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapPropertySet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Represents a property set of BitmapTypedValue objects.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BitmapPropertySet : 
    IMap<string, BitmapTypedValue>,
    IIterable<IKeyValuePair<string, BitmapTypedValue>>
  {
    /// <summary>Creates and initializes a new instance of the bitmap property set.</summary>
    [MethodImpl]
    public extern BitmapPropertySet();

    [MethodImpl]
    public extern BitmapTypedValue Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, BitmapTypedValue> GetView();

    [MethodImpl]
    public extern bool Insert(string key, BitmapTypedValue value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, BitmapTypedValue>> First();
  }
}
