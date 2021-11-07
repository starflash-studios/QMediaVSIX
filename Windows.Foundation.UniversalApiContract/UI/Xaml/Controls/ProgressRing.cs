// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ProgressRing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that indicates that an operation is ongoing. The typical visual appearance is a ring-shaped "spinner" that cycles an animation as progress continues.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IProgressRingStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ProgressRing : Control, IProgressRing
  {
    /// <summary>Initializes a new instance of the ProgressRing class.</summary>
    [MethodImpl]
    public extern ProgressRing();

    /// <summary>Gets or sets a value that indicates whether the ProgressRing is showing progress.</summary>
    /// <returns>**True** if the ProgressRing is showing progress; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsActive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a ProgressRing control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern ProgressRingTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Identifies the IsActive dependency property.</summary>
    /// <returns>The identifier for the IsActive dependency property.</returns>
    public static extern DependencyProperty IsActiveProperty { [MethodImpl] get; }
  }
}
