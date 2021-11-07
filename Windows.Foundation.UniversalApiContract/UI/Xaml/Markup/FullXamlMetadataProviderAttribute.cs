// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.FullXamlMetadataProviderAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Indicates that the XAML metadata in a component library is complete.</summary>
  [AttributeName("fullxamlmetadataprovider")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  public sealed class FullXamlMetadataProviderAttribute : Attribute
  {
    /// <summary>Initializes a new instance of the FullXamlMetadataProviderAttribute class.</summary>
    [MethodImpl]
    public extern FullXamlMetadataProviderAttribute();
  }
}
