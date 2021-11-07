// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBarOverflowPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Displays the overflow content of a CommandBar.</summary>
  [WebHostHidden]
  [Composable(typeof (ICommandBarOverflowPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class CommandBarOverflowPresenter : ItemsControl, ICommandBarOverflowPresenter
  {
    /// <summary>Initializes a new instance of the CommandBarOverflowPresenter class.</summary>
    [MethodImpl]
    public extern CommandBarOverflowPresenter();
  }
}
