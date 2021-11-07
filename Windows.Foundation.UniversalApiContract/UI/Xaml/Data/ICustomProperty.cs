// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICustomProperty
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Implements custom property definition support for data binding sources that are implemented using COM.</summary>
  [Guid(819630784, 9192, 17056, 174, 124, 115, 74, 14, 93, 39, 130)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICustomProperty
  {
    /// <summary>Gets the underlying type of the custom property.</summary>
    /// <returns>The underlying type, with relevant information as the values of the TypeName structure. TypeName provides the infrastructure such that property backing does not have to resemble common language runtime (CLR) and **System.Type** definitions.</returns>
    TypeName Type { get; }

    /// <summary>Gets the path-relevant name of the property.</summary>
    /// <returns>The name of the property as it would be specified in a binding expression.</returns>
    string Name { get; }

    /// <summary>Gets the value of the custom property from a particular instance.</summary>
    /// <param name="target">The owning instance.</param>
    /// <returns>The retrieved value.</returns>
    object GetValue(object target);

    /// <summary>Sets the custom property value on a specified instance.</summary>
    /// <param name="target">The owner instance.</param>
    /// <param name="value">The value to set.</param>
    void SetValue(object target, object value);

    /// <summary>Gets the value at an index location, for cases where the custom property has indexer support.</summary>
    /// <param name="target">The owning instance.</param>
    /// <param name="index">The index to get.</param>
    /// <returns>The retrieved value at the index.</returns>
    object GetIndexedValue(object target, object index);

    /// <summary>Sets the value at an index location, for cases where the custom property has indexer support.</summary>
    /// <param name="target">The owner instance.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="index">The index location to set to.</param>
    void SetIndexedValue(object target, object value, object index);

    /// <summary>Gets a value that determines whether the custom property supports write access.</summary>
    /// <returns>**true** if the value can be written to through a data source relationship in a two-way binding. **false** if the property cannot be written to.</returns>
    bool CanWrite { get; }

    /// <summary>Gets a value that determines whether the custom property supports read access.</summary>
    /// <returns>**true** if the property value can be read as a data source. **false** if the property cannot be a data source value.</returns>
    bool CanRead { get; }
  }
}
