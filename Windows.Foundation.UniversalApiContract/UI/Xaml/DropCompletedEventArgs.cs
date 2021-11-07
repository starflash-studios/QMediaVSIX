// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DropCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides event data for the DropCompleted event.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DropCompletedEventArgs : RoutedEventArgs, IDropCompletedEventArgs
  {
    /// <summary>Gets a value that indicates the type of drag-and-drop operation, and whether the operation was successful.</summary>
    /// <returns>An enumeration value that indicates the type of drag-and-drop operation, and whether the operation was successful.</returns>
    public extern DataPackageOperation DropResult { [MethodImpl] get; }
  }
}
