// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Core.CompositorController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Core
{
  /// <summary>Represents a compositor on which intended composition changes must be explicitly committed.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositorController : ICompositorController, IClosable
  {
    /// <summary>Initializes a new instance of the CompositorController class.</summary>
    [MethodImpl]
    public extern CompositorController();

    /// <summary>Gets the compositor associated with this composition controller.</summary>
    /// <returns>The compositor associated with this composition controller.</returns>
    public extern Compositor Compositor { [MethodImpl] get; }

    /// <summary>Calls commit on the compositor associated with this CompositorController.</summary>
    [MethodImpl]
    public extern void Commit();

    /// <summary>Ensures the previous commit was completed.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction EnsurePreviousCommitCompletedAsync();

    /// <summary>Occurs when the framework needs to call Commit in order for changes to Composition objects to be reflected onscreen.</summary>
    public extern event TypedEventHandler<CompositorController, object> CommitNeeded;

    [MethodImpl]
    public extern void Close();
  }
}
