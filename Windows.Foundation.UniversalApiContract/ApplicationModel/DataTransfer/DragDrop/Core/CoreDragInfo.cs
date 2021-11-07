// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Gets information about an item being dragged.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CoreDragInfo : ICoreDragInfo, ICoreDragInfo2
  {
    /// <summary>Gets the DataPackageView for the item being dragged.</summary>
    /// <returns>The DataPackageView for the item being dragged.</returns>
    public extern DataPackageView Data { [MethodImpl] get; }

    /// <summary>Gets the modifiers for the item being dragged.</summary>
    /// <returns>The modifiers for the item being dragged.</returns>
    public extern DragDropModifiers Modifiers { [MethodImpl] get; }

    /// <summary>Gets the position of the item being dragged.</summary>
    /// <returns>The position of the item being dragged.</returns>
    public extern Point Position { [MethodImpl] get; }

    /// <summary>Gets the allowed DataPackageOperations (none, move, copy, and/or link) for the drag and drop operation.</summary>
    /// <returns>The allowed operations.</returns>
    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; }
  }
}
