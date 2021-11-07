// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Style
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  /// <summary>Contains property setters that can be shared between instances of a type. A Style is usually declared in a resources collection so that it can be shared and used for applying control templates and other styles.</summary>
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Setters")]
  [Activatable(typeof (IStyleFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class Style : DependencyObject, IStyle
  {
    [MethodImpl]
    public extern Style(TypeName targetType);

    /// <summary>Initializes a new instance of the Style class, with no initial TargetType and an empty Setters collection.</summary>
    [MethodImpl]
    public extern Style();

    /// <summary>Gets a value that indicates whether the style is read-only and cannot be changed.</summary>
    /// <returns>**true** if the style is read-only; otherwise, **false**.</returns>
    public extern bool IsSealed { [MethodImpl] get; }

    /// <summary>Gets a collection of Setter objects.</summary>
    /// <returns>A collection of Setter objects. The default is an empty collection.</returns>
    public extern SetterBaseCollection Setters { [MethodImpl] get; }

    /// <summary>Gets or sets the type for which the style is intended. TargetType can be used to declare an implicit style resource if there's no resource key specified.</summary>
    /// <returns>The type of object to which the style is applied. This value is usually set in XAML, not code. See Remarks.</returns>
    public extern TypeName TargetType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a defined style that is the basis of the current style.</summary>
    /// <returns>A defined style that is the basis of the current style. The default value is null.</returns>
    public extern Style BasedOn { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Locks the style so that the TargetType property or any Setter in the Setters collection cannot be changed.</summary>
    [MethodImpl]
    public extern void Seal();
  }
}
