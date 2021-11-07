// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SelectionPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by ISelectionProvider.</summary>
  [Static(typeof (ISelectionPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SelectionPatternIdentifiers : ISelectionPatternIdentifiers
  {
    /// <summary>Identifies the CanSelectMultiple automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty CanSelectMultipleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSelectionRequired automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsSelectionRequiredProperty { [MethodImpl] get; }

    /// <summary>Identifies the property that gets the selected items in a container.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty SelectionProperty { [MethodImpl] get; }
  }
}
