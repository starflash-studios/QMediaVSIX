// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.StyleTypedPropertyAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents an attribute that is applied to the class definition and determines the **TargetTypes** of the properties that are of type Style.</summary>
  [AllowMultiple]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [AttributeName("styletypedproperty")]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  [WebHostHidden]
  public sealed class StyleTypedPropertyAttribute : Attribute
  {
    /// <summary>
    /// </summary>
    public string Property;
    /// <summary>
    /// </summary>
    public Type StyleTargetType;

    /// <summary>Initializes a new instance of the StyleTypedPropertyAttribute class.</summary>
    [MethodImpl]
    public extern StyleTypedPropertyAttribute();
  }
}
