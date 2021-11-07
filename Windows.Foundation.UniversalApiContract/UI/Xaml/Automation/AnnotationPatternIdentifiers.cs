// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AnnotationPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IAnnotationProvider.</summary>
  [Static(typeof (IAnnotationPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AnnotationPatternIdentifiers : IAnnotationPatternIdentifiers
  {
    /// <summary>Gets the identifier for the AnnotationTypeId automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty AnnotationTypeIdProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the AnnotationTypeName automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty AnnotationTypeNameProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Author automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty AuthorProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DateTime automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty DateTimeProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Target automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty TargetProperty { [MethodImpl] get; }
  }
}
