﻿// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.PropertySet
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents a property set, which is a set of PropertyValue objects with string keys.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.FoundationContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PropertySet : 
    IPropertySet,
    IObservableMap<string, object>,
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    /// <summary>Creates and initializes a new instance of the property set.</summary>
    [MethodImpl]
    public extern PropertySet();

	/// <summary>Occurs when the observable map has changed.</summary>
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	public extern event MapChangedEventHandler<string, object> MapChanged;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

	[MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, object> GetView();

    [MethodImpl]
    public extern bool Insert(string key, object value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();
  }
}