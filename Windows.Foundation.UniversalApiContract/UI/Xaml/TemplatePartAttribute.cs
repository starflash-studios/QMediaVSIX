// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TemplatePartAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents an attribute that is applied to the class definition to identify the types of the named parts that are used for templating.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [AttributeName("templatepart")]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  [WebHostHidden]
  [AllowMultiple]
  public sealed class TemplatePartAttribute : Attribute
  {
    /// <summary>
    /// </summary>
    public string Name;
    /// <summary>
    /// </summary>
    public Type Type;

    /// <summary>Initializes a new instance of the TemplatePartAttribute class.</summary>
    [MethodImpl]
    public extern TemplatePartAttribute();
  }
}
