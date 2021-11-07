// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ValuePatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IValueProvider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IValuePatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ValuePatternIdentifiers : IValuePatternIdentifiers
  {
    /// <summary>Identifies the IsReadOnly property.</summary>
    /// <returns>The automation property reference for the IsReadOnly property.</returns>
    public static extern AutomationProperty IsReadOnlyProperty { [MethodImpl] get; }

    /// <summary>Identifies the Value automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ValueProperty { [MethodImpl] get; }
  }
}
