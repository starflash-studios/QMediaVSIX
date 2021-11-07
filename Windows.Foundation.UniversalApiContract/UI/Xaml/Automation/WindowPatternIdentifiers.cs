// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.WindowPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IWindowProvider.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IWindowPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WindowPatternIdentifiers : IWindowPatternIdentifiers
  {
    /// <summary>Identifies the Maximizable automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty CanMaximizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Minimizable automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty CanMinimizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsModal automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsModalProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTopmost automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsTopmostProperty { [MethodImpl] get; }

    /// <summary>Identifies the InteractionState automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty WindowInteractionStateProperty { [MethodImpl] get; }

    /// <summary>Identifies the VisualState automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty WindowVisualStateProperty { [MethodImpl] get; }
  }
}
