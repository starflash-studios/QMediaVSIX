// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.RangeValuePatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IRangeValueProvider.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRangeValuePatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RangeValuePatternIdentifiers : IRangeValuePatternIdentifiers
  {
    /// <summary>Identifies the IsReadOnly automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsReadOnlyProperty { [MethodImpl] get; }

    /// <summary>Identifies the LargeChange automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty LargeChangeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Maximum automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty MaximumProperty { [MethodImpl] get; }

    /// <summary>Identifies the Minimum automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty MinimumProperty { [MethodImpl] get; }

    /// <summary>Identifies the SmallChange automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty SmallChangeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Value automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ValueProperty { [MethodImpl] get; }
  }
}
