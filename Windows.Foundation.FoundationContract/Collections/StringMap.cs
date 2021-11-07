// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.StringMap
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>An associative collection, also known as a map or a dictionary.</summary>
  [Activatable(65536, "Windows.Foundation.FoundationContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StringMap : 
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IObservableMap<string, string>
  {
    /// <summary>Creates and initializes a new instance of the StringMap.</summary>
    [MethodImpl]
    public extern StringMap();

    [MethodImpl]
    public extern string Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, string> GetView();

    [MethodImpl]
    public extern bool Insert(string key, string value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, string>> First();

	/// <summary>Occurs when the contents of the map change.</summary>
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	public extern event MapChangedEventHandler<string, string> MapChanged;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	}
}
