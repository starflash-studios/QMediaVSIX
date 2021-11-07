// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.DropTargetPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IDropTargetProvider.</summary>
  [WebHostHidden]
  [Static(typeof (IDropTargetPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DropTargetPatternIdentifiers : IDropTargetPatternIdentifiers
  {
    /// <summary>Gets the identifier for the DropEffect automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty DropTargetEffectProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DropEffects automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty DropTargetEffectsProperty { [MethodImpl] get; }
  }
}
