// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.INotifyCollectionChanged
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Provides a collection-changed pattern interface for C++ bindable classes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(682715093, 6705, 18011, 155, 37, 213, 195, 174, 104, 108, 64)]
  [WebHostHidden]
  public interface INotifyCollectionChanged
  {
    /// <summary>Occurs when the collection changes.</summary>
    event NotifyCollectionChangedEventHandler CollectionChanged;
  }
}
