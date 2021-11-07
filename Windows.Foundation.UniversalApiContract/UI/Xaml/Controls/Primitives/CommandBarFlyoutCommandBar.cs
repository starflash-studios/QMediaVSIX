// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.CommandBarFlyoutCommandBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a specialized command bar used in a CommandBarFlyout.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (ICommandBarFlyoutCommandBarFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public class CommandBarFlyoutCommandBar : CommandBar, ICommandBarFlyoutCommandBar
  {
    /// <summary>Initializes a new instance of the CommandBarFlyoutCommandBar class.</summary>
    [MethodImpl]
    public extern CommandBarFlyoutCommandBar();

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for a CommandBarFlyoutCommandBar control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern CommandBarFlyoutCommandBarTemplateSettings FlyoutTemplateSettings { [MethodImpl] get; }
  }
}
