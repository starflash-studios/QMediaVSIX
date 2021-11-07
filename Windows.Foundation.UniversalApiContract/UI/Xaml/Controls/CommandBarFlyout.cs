// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBarFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a specialized flyout that provides layout for AppBarButton and related command elements.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICommandBarFlyoutFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "PrimaryCommands")]
  public class CommandBarFlyout : FlyoutBase, ICommandBarFlyout
  {
    /// <summary>Initializes a new instance of the CommandBarFlyout class.</summary>
    [MethodImpl]
    public extern CommandBarFlyout();

    /// <summary>Gets the collection of primary command elements for the CommandBarFlyout.</summary>
    /// <returns>The collection of primary command elements for the CommandBarFlyout. The default is an empty collection.</returns>
    public extern IObservableVector<ICommandBarElement> PrimaryCommands { [MethodImpl] get; }

    /// <summary>Gets the collection of secondary command elements for the CommandBarFlyout.</summary>
    /// <returns>The collection of secondary command elements for the CommandBarFlyout. The default is an empty collection.</returns>
    public extern IObservableVector<ICommandBarElement> SecondaryCommands { [MethodImpl] get; }
  }
}
