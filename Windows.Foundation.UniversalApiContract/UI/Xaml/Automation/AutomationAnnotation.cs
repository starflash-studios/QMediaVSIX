// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationAnnotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Represents a single UI automation annotation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutomationAnnotationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAutomationAnnotationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class AutomationAnnotation : DependencyObject, IAutomationAnnotation
  {
    /// <summary>Initializes a new instance of the  class using the supplied parameters.</summary>
    /// <param name="type">Specifies the type of the annotation.</param>
    [MethodImpl]
    public extern AutomationAnnotation(AnnotationType type);

    /// <summary>Initializes a new instance of the  class using the supplied parameters.</summary>
    /// <param name="type">Specifies the type of the annotation.</param>
    /// <param name="element">Specifies the element that implements the annotation.</param>
    [MethodImpl]
    public extern AutomationAnnotation(AnnotationType type, UIElement element);

    /// <summary>Initializes a new instance of the  class.</summary>
    [MethodImpl]
    public extern AutomationAnnotation();

    /// <summary>Gets or sets the type of the annotation.</summary>
    /// <returns>The type of the annotation.</returns>
    public extern AnnotationType Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the element that implements the annotation.</summary>
    /// <returns>The element that implements the annotation.</returns>
    public extern UIElement Element { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the identifier of the  property.</summary>
    /// <returns>The identifier of the  property.</returns>
    public static extern DependencyProperty TypeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier of the  property.</summary>
    /// <returns>The identifier of the  property.</returns>
    public static extern DependencyProperty ElementProperty { [MethodImpl] get; }
  }
}
