// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlMember
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Provides the means to report XAML-type system specifics about XAML members. Using this interface contract, XAML parsers can load any custom types and members thereof that are defined in your app and are referenced in XAML files.</summary>
  [Guid(3309434252, 17321, 16918, 183, 24, 224, 177, 27, 20, 233, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IXamlMember
  {
    /// <summary>Gets a value that indicates whether the XAML member is an attachable member.</summary>
    /// <returns>**true** if the XAML member is an attachable member; otherwise, **false**.</returns>
    bool IsAttachable { get; }

    /// <summary>Gets a value that indicates whether the XAML member is implemented as a dependency property.</summary>
    /// <returns>**true** if the XAML member is implemented as a dependency property; otherwise, **false**.</returns>
    bool IsDependencyProperty { get; }

    /// <summary>Gets whether the XAML member is read-only in its backing implementation.</summary>
    /// <returns>**true** if the backing member is read-only; otherwise, **false**.</returns>
    bool IsReadOnly { get; }

    /// <summary>Gets the XamlName name string that declares the XAML member.</summary>
    /// <returns>The XamlName name string that declares the XAML member.</returns>
    string Name { get; }

    /// <summary>Gets the IXamlType of the type where the member can exist.</summary>
    /// <returns>The IXamlType of the type where the member can exist.</returns>
    IXamlType TargetType { get; }

    /// <summary>Gets the IXamlType of the type that is used by the member.</summary>
    /// <returns>The IXamlType of the type that is used by the member.</returns>
    IXamlType Type { get; }

    /// <summary>Provides a get-value utility for this IXamlMember.</summary>
    /// <param name="instance">The object instance to get the member value from.</param>
    /// <returns>The member value.</returns>
    object GetValue(object instance);

    /// <summary>Provides a set-value utility for this IXamlMember.</summary>
    /// <param name="instance">The object instance to set the member value on.</param>
    /// <param name="value">The member value to set.</param>
    void SetValue(object instance, object value);
  }
}
