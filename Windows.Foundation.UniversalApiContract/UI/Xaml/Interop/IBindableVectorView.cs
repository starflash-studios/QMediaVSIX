// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableVectorView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Represents a read-only vector collection of objects that is bindable.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(879613671, 38766, 19395, 129, 93, 236, 226, 67, 188, 15, 51)]
  [WebHostHidden]
  public interface IBindableVectorView : IBindableIterable
  {
    /// <summary>Returns the item at the specified index in the vector.</summary>
    /// <param name="index">The zero-based index of the item in the vector to return.</param>
    /// <returns>The item at the specified index.</returns>
    object GetAt(uint index);

    /// <summary>Gets the number of items in the vector.</summary>
    /// <returns>The number of items in the vector.</returns>
    uint Size { get; }

    /// <summary>Returns the index of a specified item in the vector.</summary>
    /// <param name="value">The item to find in the vector.</param>
    /// <param name="index">The zero-based index of the item if found. 0 is returned if the item is not found, so be sure to check the return value.</param>
    /// <returns>**true** if the item is found; **false** if the item is not found.</returns>
    bool IndexOf(object value, out uint index);
  }
}
