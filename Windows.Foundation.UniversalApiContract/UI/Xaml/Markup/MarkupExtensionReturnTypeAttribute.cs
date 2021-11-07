// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.MarkupExtensionReturnTypeAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Reports the type that a markup extension can return.</summary>
  [WebHostHidden]
  [AttributeName("markupextensionreturntype")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  public sealed class MarkupExtensionReturnTypeAttribute : Attribute
  {
    /// <summary>
    /// </summary>
    public Type ReturnType;

    /// <summary>Initializes a new instance of the MarkupExtensionReturnTypeAttribute class.</summary>
    [MethodImpl]
    public extern MarkupExtensionReturnTypeAttribute();
  }
}
