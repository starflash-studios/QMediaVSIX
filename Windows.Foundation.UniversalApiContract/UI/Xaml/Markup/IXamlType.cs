// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides the means to report XAML-type system specifics about XAML types. Using this interface contract, XAML parsers can load any custom types and members thereof that are defined in your app and are referenced in XAML files.</summary>
  [Guid(2032200369, 41701, 18330, 189, 80, 108, 239, 60, 11, 73, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IXamlType
  {
    /// <summary>Gets the IXamlType for the immediate base type of the XAML type. Determination of this value is based on the underlying type for core types.</summary>
    /// <returns>The IXamlType for the immediate base type of the XAML type.</returns>
    IXamlType BaseType { get; }

    /// <summary>Gets the IXamlMember information for the XAML content property of this IXamlType.</summary>
    /// <returns>IXamlMember information for the XAML content property of the IXamlType. May be null if no XAML content property exists.</returns>
    IXamlMember ContentProperty { get; }

    /// <summary>Gets the full class name of the underlying type.</summary>
    /// <returns>The full class name of the underlying type.</returns>
    string FullName { get; }

    /// <summary>Gets a value that indicates whether the IXamlType represents an array.</summary>
    /// <returns>**true** if the IXamlType represents an array; otherwise, **false**.</returns>
    bool IsArray { get; }

    /// <summary>Gets a value that indicates whether this IXamlType represents a collection.</summary>
    /// <returns>**true** if this IXamlType represents a collection; otherwise, **false**.</returns>
    bool IsCollection { get; }

    /// <summary>Gets a value that indicates whether this IXamlType represents a constructible type, as per the XAML definition.</summary>
    /// <returns>**true** if this IXamlType represents a constructible type; otherwise, **false**.</returns>
    bool IsConstructible { get; }

    /// <summary>Gets a value that indicates whether this IXamlType represents a dictionary/map.</summary>
    /// <returns>**true** if this IXamlType represents a dictionary/map; otherwise, **false**.</returns>
    bool IsDictionary { get; }

    /// <summary>Gets a value that indicates whether the IXamlType represents a markup extension.</summary>
    /// <returns>**true** if the IXamlType represents a markup extension; otherwise, **false**.</returns>
    bool IsMarkupExtension { get; }

    /// <summary>Gets a value that declares whether the type is bindable.</summary>
    /// <returns>**true** if the type is bindable, **false** if the type is not bindable.</returns>
    bool IsBindable { get; }

    /// <summary>Gets a value that provides the type information for the **Items** property of this IXamlType.</summary>
    /// <returns>The IXamlType information for the type of the items in the collection; otherwise, null if this IXamlType does not represent a collection.</returns>
    IXamlType ItemType { get; }

    /// <summary>Gets a value that provides the type information for the **Key** property of this IXamlType, if this IXamlType represents a dictionary/map.</summary>
    /// <returns>The IXamlType information for the type of the key for dictionary usage; otherwise, null if this IXamlType does not represent a dictionary/map.</returns>
    IXamlType KeyType { get; }

    /// <summary>Gets information for the backing type.</summary>
    /// <returns>The backing type as represented by the relevant type system or interop support type. This is a type reference (System.Type for Microsoft .NET, a TypeName helper struct for Visual C++ component extensions (C++/CX)).</returns>
    TypeName UnderlyingType { get; }

    /// <summary>Given a XAML type, sets its values for initialization and returns a usable instance.</summary>
    /// <returns>The usable instance.</returns>
    object ActivateInstance();

    /// <summary>Creates a type system representation based on a string. The main scenario for this usage is creating an enumeration value and mapping the appropriate enumeration.</summary>
    /// <param name="value">The string to create from.</param>
    /// <returns>The resulting type system representation.</returns>
    object CreateFromString(string value);

    /// <summary>Returns the IXamlMember information for a specific named member from this IXamlType.</summary>
    /// <param name="name">The name of the member to get (as a string).</param>
    /// <returns>The IXamlMember information for the member, if a member as specified by *name* was found; otherwise, null.</returns>
    IXamlMember GetMember(string name);

    /// <summary>Adds an item to a custom vector type.</summary>
    /// <param name="instance">The type instance to set the item to.</param>
    /// <param name="value">The value of the item to add.</param>
    void AddToVector(object instance, object value);

    /// <summary>Adds an item to a custom map type.</summary>
    /// <param name="instance">The type instance to set the map item to.</param>
    /// <param name="key">The key of the map item to add.</param>
    /// <param name="value">The value of the map item to add.</param>
    void AddToMap(object instance, object key, object value);

    /// <summary>Invokes any necessary pre-activation logic as required by the XAML schema context and its platform dependencies.</summary>
    void RunInitializer();
  }
}
