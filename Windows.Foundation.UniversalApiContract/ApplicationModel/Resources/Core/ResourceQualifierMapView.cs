// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceQualifierMapView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>An unchangeable view into a map of ResourceQualifier objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResourceQualifierMapView : 
    IMapView<string, string>,
    IIterable<IKeyValuePair<string, string>>
  {
    [MethodImpl]
    public extern string Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, string> first,
      out IMapView<string, string> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, string>> First();
  }
}
