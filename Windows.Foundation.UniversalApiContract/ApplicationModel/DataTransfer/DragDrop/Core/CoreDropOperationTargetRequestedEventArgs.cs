// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDropOperationTargetRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Provides the ability to set the target of a drag and drop operation when a target is requested.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  public sealed class CoreDropOperationTargetRequestedEventArgs : 
    ICoreDropOperationTargetRequestedEventArgs
  {
    /// <summary>Sets the target of the drag and drop operation.</summary>
    /// <param name="target">The target of the drag and drop operation.</param>
    [MethodImpl]
    public extern void SetTarget(ICoreDropOperationTarget target);
  }
}
