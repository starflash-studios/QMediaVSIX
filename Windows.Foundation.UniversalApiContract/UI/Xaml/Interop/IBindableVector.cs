// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.IBindableVector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  /// <summary>Represents a writeable vector collection of objects that is bindable.</summary>
  [Guid(960358366, 28624, 19469, 187, 113, 71, 36, 74, 17, 62, 147)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBindableVector : IBindableIterable
  {
    /// <summary>Returns the item at the specified index in the vector.</summary>
    /// <param name="index">The zero-based index of the item in the vector to return.</param>
    /// <returns>The item at the specified index.</returns>
    object GetAt(uint index);

    /// <summary>Gets the number of items in the vector.</summary>
    /// <returns>The number of items in the vector.</returns>
    uint Size { get; }

    /// <summary>Returns an immutable view of the vector.</summary>
    /// <returns>The view of the vector.</returns>
    IBindableVectorView GetView();

    /// <summary>Returns the index of a specified item in the vector.</summary>
    /// <param name="value">The item to find in the vector.</param>
    /// <param name="index">The zero-based index of the item if found. 0 is returned if the item is not found, so be sure to check the return value.</param>
    /// <returns>**true** if the item is found; **false** if the item is not found.</returns>
    bool IndexOf(object value, out uint index);

    /// <summary>Sets the item value at the specified index of the vector.</summary>
    /// <param name="index">The zero-based index of the vector, at which to set the value.</param>
    /// <param name="value">The item value to set.</param>
    void SetAt(uint index, object value);

    /// <summary>Inserts an item into a vector at a specified index.</summary>
    /// <param name="index">The index at which to insert.</param>
    /// <param name="value">The item to insert.</param>
    void InsertAt(uint index, object value);

    /// <summary>Removes the item at the specified index in the vector.</summary>
    /// <param name="index">The zero-based index of the vector, at which to remove the item.</param>
    void RemoveAt(uint index);

    /// <summary>Appends an item to the end of the vector.</summary>
    /// <param name="value">The item to append to the vector.</param>
    void Append(object value);

    /// <summary>Removes the last item in the vector.</summary>
    void RemoveAtEnd();

    /// <summary>Removes all items from the vector.</summary>
    void Clear();
  }
}
