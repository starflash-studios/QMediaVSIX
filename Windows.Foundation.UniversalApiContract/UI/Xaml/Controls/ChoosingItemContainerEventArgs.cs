// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the ListViewBase.ChoosingItemContainer event.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChoosingItemContainerEventArgs : IChoosingItemContainerEventArgs
  {
    /// <summary>Initializes a new instance of the ChoosingItemContainerEventArgs class.</summary>
    [MethodImpl]
    public extern ChoosingItemContainerEventArgs();

    /// <summary>Gets the index in the ItemsSource of the data item for which a container is being selected.</summary>
    /// <returns>The index in the ItemsSource of the data item for which a container is being selected.</returns>
    public extern int ItemIndex { [MethodImpl] get; }

    /// <summary>Gets the data item associated with this ItemContainer.</summary>
    /// <returns>The data item associated with this ItemContainer.</returns>
    public extern object Item { [MethodImpl] get; }

    /// <summary>Gets or sets the UI container that will be used to display the current data item.</summary>
    /// <returns>The UI container that will be used to display the current data item.</returns>
    public extern SelectorItem ItemContainer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the container is ready for use.</summary>
    /// <returns>**true** if the container is ready for use; otherwise, **false**.</returns>
    public extern bool IsContainerPrepared { [MethodImpl] get; [MethodImpl] set; }
  }
}
