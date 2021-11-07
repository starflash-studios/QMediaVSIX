// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the ListViewBase.ChoosingGroupHeaderContainer event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ChoosingGroupHeaderContainerEventArgs : IChoosingGroupHeaderContainerEventArgs
  {
    /// <summary>Initializes a new instance of the ChoosingGroupHeaderContainerEventArgs class.</summary>
    [MethodImpl]
    public extern ChoosingGroupHeaderContainerEventArgs();

    /// <summary>Gets or sets the UI container that will be used to display the current data group.</summary>
    /// <returns>The UI container that will be used to display the current data group.</returns>
    public extern ListViewBaseHeaderItem GroupHeaderContainer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the index in the ItemsSource of the data group for which a container is being selected.</summary>
    /// <returns>The index in the ItemsSource of the data group for which a container is being selected.</returns>
    public extern int GroupIndex { [MethodImpl] get; }

    /// <summary>Gets the data group associated with this GroupHeaderContainer.</summary>
    /// <returns>The data group associated with this GroupHeaderContainer.</returns>
    public extern object Group { [MethodImpl] get; }
  }
}
