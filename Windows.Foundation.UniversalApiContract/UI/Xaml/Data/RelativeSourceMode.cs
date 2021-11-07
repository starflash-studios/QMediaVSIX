// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.RelativeSourceMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Defines constants that describe the location of the binding source relative to the position of the binding target.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum RelativeSourceMode
  {
    /// <summary>Don't use this value of RelativeSourceMode; always use either **Self** or **TemplatedParent**.</summary>
    None,
    /// <summary>Refers to the element to which the template (in which the data-bound element exists) is applied. This is similar to setting a TemplateBinding Markup Extension and is only applicable if the Binding is within a template.</summary>
    TemplatedParent,
    /// <summary>Refers to the element on which you are setting the binding and allows you to bind one property of that element to another property on the same element.</summary>
    Self,
  }
}
