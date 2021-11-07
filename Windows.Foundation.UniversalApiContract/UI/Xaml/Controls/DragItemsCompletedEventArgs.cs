// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs
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
  /// <summary>Provides event data for the DragItemsCompleted event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DragItemsCompletedEventArgs : IDragItemsCompletedEventArgs
  {
    /// <summary>Gets the loosely typed collection of objects that are selected for the item drag action.</summary>
    /// <returns>A loosely typed collection of objects.</returns>
    public extern IVectorView<object> Items { [MethodImpl] get; }

    /// <summary>Gets a value that indicates what operation was performed on the dragged data, and whether it was successful.</summary>
    /// <returns>A value of the enumeration that indicates what operation was performed on the dragged data.</returns>
    public extern DataPackageOperation DropResult { [MethodImpl] get; }
  }
}
