// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IPropertySet
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents a collection of key-value pairs, correlating several other collection interfaces.</summary>
  [HasVariant]
  [Guid(2319707551, 62694, 17441, 172, 249, 29, 171, 41, 134, 130, 12)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IPropertySet : 
    IObservableMap<string, object>,
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
  }
}
