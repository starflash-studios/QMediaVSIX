// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ProgressBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that indicates the progress of an operation, where the typical visual appearance is a bar that animates a filled area as progress continues.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IProgressBarFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IProgressBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ProgressBar : RangeBase, IProgressBar
  {
    /// <summary>Initializes a new instance of the ProgressBar class.</summary>
    [MethodImpl]
    public extern ProgressBar();

    /// <summary>Gets or sets a value that indicates whether the progress bar reports generic progress with a repeating pattern or reports progress based on the Value property.</summary>
    /// <returns>**True** if the progress bar reports generic progress with a repeating pattern; **false** if the progress bar reports progress based on the Value property. The default is **false**.</returns>
    public extern bool IsIndeterminate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the progress bar should use visual states that communicate an **Error** state to the user.</summary>
    /// <returns>**True** if the progress bar should use visual states that communicate an **Error** state to the user; otherwise, **false**. The default is **false**.</returns>
    public extern bool ShowError { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the progress bar should use visual states that communicate a **Paused** state to the user.</summary>
    /// <returns>**True** if the progress bar should use visual states that communicate a **Paused** state to the user; otherwise, **false**. The default is **false**.</returns>
    public extern bool ShowPaused { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a ProgressBar control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern ProgressBarTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Identifies the IsIndeterminate dependency property.</summary>
    /// <returns>The identifier for the IsIndeterminate dependency property.</returns>
    public static extern DependencyProperty IsIndeterminateProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShowError dependency property.</summary>
    /// <returns>The identifier for the ShowError dependency property.</returns>
    public static extern DependencyProperty ShowErrorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShowPaused dependency property.</summary>
    /// <returns>The identifier for the ShowPaused dependency property.</returns>
    public static extern DependencyProperty ShowPausedProperty { [MethodImpl] get; }
  }
}
