// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TemplateVisualStateAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies that a control can be in a certain state and that a VisualState is expected in the control's ControlTemplate.</summary>
  [AttributeName("templatevisualstate")]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.RuntimeClass)]
  [WebHostHidden]
  [AllowMultiple]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TemplateVisualStateAttribute : Attribute
  {
    /// <summary>
    /// </summary>
    public string Name;
    /// <summary>
    /// </summary>
    public string GroupName;

    /// <summary>Initializes a new instance of the TemplateVisualStateAttribute class.</summary>
    [MethodImpl]
    public extern TemplateVisualStateAttribute();
  }
}
