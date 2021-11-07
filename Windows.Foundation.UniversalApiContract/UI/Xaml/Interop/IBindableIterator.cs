// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableIterator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Supports bindable iteration over a collection.</summary>
  [WebHostHidden]
  [Guid(1780313095, 1901, 18930, 131, 20, 245, 44, 156, 154, 131, 49)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBindableIterator
  {
    /// <summary>Gets the current item in the collection.</summary>
    /// <returns>The current item in the collection.</returns>
    object Current { get; }

    /// <summary>Gets a value that indicates whether there is a current item or the iterator is at the end of the collection.</summary>
    /// <returns>**true** if the iterator refers to a valid item that is in the collection; otherwise, **false**.</returns>
    bool HasCurrent { get; }

    /// <summary>Moves the iterator forward to the next item and returns HasCurrent.</summary>
    /// <returns>**true** if the iterator refers to a valid item that is in the collection; otherwise, **false**.</returns>
    bool MoveNext();
  }
}
