// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.ContentPropertyAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Indicates which property of a type is the XAML content property. A XAML processor uses this information when processing XAML child elements of XAML representations of the attributed type.</summary>
  [WebHostHidden]
  [AttributeName("contentproperty")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  public sealed class ContentPropertyAttribute : Attribute
  {
    /// <summary>
    /// </summary>
    public string Name;

    /// <summary>Initializes a new instance of the ContentPropertyAttribute class.</summary>
    [MethodImpl]
    public extern ContentPropertyAttribute();
  }
}
