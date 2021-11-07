// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DragItemsStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the DragItemsStarting event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DragItemsStartingEventArgs : IDragItemsStartingEventArgs
  {
    /// <summary>Initializes a new instance of the DragItemsStartingEventArgs class.</summary>
    [MethodImpl]
    public extern DragItemsStartingEventArgs();

    /// <summary>Gets or sets a value that indicates whether the item drag action should be canceled.</summary>
    /// <returns>**True** to cancel the item drag action; otherwise, **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the loosely typed collection of objects that are selected for the item drag action.</summary>
    /// <returns>A loosely typed collection of objects.</returns>
    public extern IVector<object> Items { [MethodImpl] get; }

    /// <summary>Gets the data payload associated with an items drag action.</summary>
    /// <returns>The data payload.</returns>
    public extern DataPackage Data { [MethodImpl] get; }
  }
}
