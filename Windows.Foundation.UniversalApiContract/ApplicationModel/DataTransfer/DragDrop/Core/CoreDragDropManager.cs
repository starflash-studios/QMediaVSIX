// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragDropManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Manages access for drag and drop within and between apps.</summary>
  [WebHostHidden]
  [Static(typeof (ICoreDragDropManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class CoreDragDropManager : ICoreDragDropManager
  {
    /// <summary>Occurs when a drag and drop target is requested.</summary>
    public extern event TypedEventHandler<CoreDragDropManager, CoreDropOperationTargetRequestedEventArgs> TargetRequested;

    /// <summary>Gets or sets whether concurrent drag and drop operations are enabled.</summary>
    /// <returns>True if concurrent drag and drop operations are enabled; otherwise, false.</returns>
    public extern bool AreConcurrentOperationsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the core drag and drop manager associated with the currently visible application window.</summary>
    /// <returns>The core drag and drop manager associated with the currently visible application window.</returns>
    [MethodImpl]
    public static extern CoreDragDropManager GetForCurrentView();
  }
}
