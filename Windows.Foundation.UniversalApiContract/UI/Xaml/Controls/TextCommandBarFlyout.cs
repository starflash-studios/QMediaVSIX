// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextCommandBarFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a specialized command bar flyout that contains commands for editing text.</summary>
  [WebHostHidden]
  [Composable(typeof (ITextCommandBarFlyoutFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TextCommandBarFlyout : CommandBarFlyout, ITextCommandBarFlyout
  {
    /// <summary>Initializes a new instance of the TextCommandBarFlyout class.</summary>
    [MethodImpl]
    public extern TextCommandBarFlyout();
  }
}
