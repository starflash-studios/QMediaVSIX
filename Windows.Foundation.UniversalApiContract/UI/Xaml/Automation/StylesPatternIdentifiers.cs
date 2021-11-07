// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.StylesPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IStylesProvider.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IStylesPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class StylesPatternIdentifiers : IStylesPatternIdentifiers
  {
    /// <summary>Identifies the ExtendedProperties automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ExtendedPropertiesProperty { [MethodImpl] get; }

    /// <summary>Identifies the FillColor automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FillColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the FillPatternColor automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FillPatternColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the FillPatternStyle automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FillPatternStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Shape automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ShapeProperty { [MethodImpl] get; }

    /// <summary>Identifies the StyleId automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty StyleIdProperty { [MethodImpl] get; }

    /// <summary>Identifies the StyleName automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty StyleNameProperty { [MethodImpl] get; }
  }
}
