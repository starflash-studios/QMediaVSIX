// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICustomPropertyProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides lookup service for ICustomProperty support. This interface is implemented by objects so that their custom defined properties can be used as run-time binding sources.</summary>
  [Guid(2089965397, 15944, 17076, 134, 119, 118, 55, 34, 103, 3, 63)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICustomPropertyProvider
  {
    /// <summary>Gets a custom property's ICustomProperty support object by specifying a property name.</summary>
    /// <param name="name">The name of the property to get the support object for.</param>
    /// <returns>The returned support object for the custom property, or **nullptr**.</returns>
    ICustomProperty GetCustomProperty(string name);

    ICustomProperty GetIndexedProperty(string name, TypeName type);

    /// <summary>Provides support for "GetStringFromObject" and/or "ToString" logic on the assumption that the implementation supports System.Object. This logic might be accessed by features or services such as generating UI Automation values based on data content.</summary>
    /// <returns>The provided string.</returns>
    string GetStringRepresentation();

    /// <summary>Gets the underlying type of the custom property.</summary>
    /// <returns>The underlying type, with relevant information as the values of the TypeName structure. TypeName provides the infrastructure such that property backing does not have to take a dependency on the common language runtime (CLR) and **System.Type**.</returns>
    TypeName Type { get; }
  }
}
