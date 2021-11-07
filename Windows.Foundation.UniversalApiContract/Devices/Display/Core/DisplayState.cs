// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents a slice in time of display pipeline state for a subset of the system's display targets. If IsReadOnly is `false`, then this object can be modified by connecting targets that are owned by the caller's DisplayManager, or by modifying path properties. Modifying a **DisplayState** object, or its child objects, does not directly modify the system's display state until you call TryApply.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayState : IDisplayState
  {
    /// <summary>Gets a value indicating whether this DisplayState and its child views and paths can be modified.</summary>
    /// <returns>`true` if this DisplayState and its child views and paths cannot be modified, otherwise `false`.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the system display state has changed since this DisplayState was created.</summary>
    /// <returns>`true` if the system display state has changed since this DisplayState was created, otherwise `false`.</returns>
    public extern bool IsStale { [MethodImpl] get; }

    /// <summary>Returns the set of DisplayTarget objects used to create this DisplayState object.</summary>
    /// <returns>
    /// </returns>
    public extern IVectorView<DisplayTarget> Targets { [MethodImpl] get; }

    /// <summary>Gets a collection containing the views of the DisplayState.</summary>
    /// <returns>An IVectorView of DisplayView objects.</returns>
    public extern IVectorView<DisplayView> Views { [MethodImpl] get; }

    /// <summary>Reserved for future use.</summary>
    /// <returns>
    /// </returns>
    public extern IMap<Guid, object> Properties { [MethodImpl] get; }

    /// <summary>
    /// </summary>
    /// <param name="target">
    /// </param>
    /// <returns>
    /// </returns>
    [Overload("ConnectTarget")]
    [DefaultOverload]
    [MethodImpl]
    public extern DisplayPath ConnectTarget(DisplayTarget target);

    /// <summary>Connects the specified target to an existing logical clone group and returns the resulting path.</summary>
    /// <param name="target">
    /// </param>
    /// <param name="view">
    /// </param>
    /// <returns>
    /// </returns>
    [Overload("ConnectTargetToView")]
    [MethodImpl]
    public extern DisplayPath ConnectTarget(DisplayTarget target, DisplayView view);

    /// <summary>
    /// </summary>
    /// <param name="target">
    /// </param>
    /// <param name="view">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool CanConnectTargetToView(DisplayTarget target, DisplayView view);

    /// <summary>
    /// </summary>
    /// <param name="target">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern DisplayView GetViewForTarget(DisplayTarget target);

    /// <summary>
    /// </summary>
    /// <param name="target">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern DisplayPath GetPathForTarget(DisplayTarget target);

    /// <summary>
    /// </summary>
    /// <param name="target">
    /// </param>
    [MethodImpl]
    public extern void DisconnectTarget(DisplayTarget target);

    /// <summary>Attempts to "functionalize" this DisplayState by trying to evaluate the best modes on all paths given all specified DisplayPath properties as constraints. This method then (optionally, see **Remarks**) updates all **DisplayPath** and DisplayView properties with the results of the functionalization. In particular, all **DisplayPath** and **DisplayView** properties set to null will have their values computed and set.</summary>
    /// <param name="options">The DisplayStateFunctionalizeOptions to use.</param>
    /// <returns>A DisplayStateOperationResult value detailing the success or failure of the operation.</returns>
    [MethodImpl]
    public extern DisplayStateOperationResult TryFunctionalize(
      DisplayStateFunctionalizeOptions options);

    /// <summary>Attempts to atomically apply this DisplayState to the relevant hardware. Implicitly, this involves "functionalizing" all paths to determine the best modes matching all DisplayPath and DisplayView properties.</summary>
    /// <param name="options">The DisplayStateApplyOptions to use.</param>
    /// <returns>A DisplayStateOperationResult value detailing the success or failure of the operation.</returns>
    [MethodImpl]
    public extern DisplayStateOperationResult TryApply(
      DisplayStateApplyOptions options);

    /// <summary>Creates a copy of this **DisplayState** object, including copies of all views and paths.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern DisplayState Clone();
  }
}
