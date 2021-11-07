// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents a group of DisplayPath objects that are logically cloned together.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayView : IDisplayView
  {
    /// <summary>Gets the set of paths making up this DisplayView.</summary>
    /// <returns>A collection containing the paths making up this DisplayView.</returns>
    public extern IVectorView<DisplayPath> Paths { [MethodImpl] get; }

    /// <summary>The logical content resolution of this group of cloned DisplayPath objects. For a DisplayView in hardware clone, this will be the same value as each path's SourceResolution property.</summary>
    /// <returns>
    /// </returns>
    public extern IReference<SizeInt32> ContentResolution { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets a path in this view to be the "primary clone path" in the view, which causes clone-unaware apps to see the refresh rate and target properties of this path by default.</summary>
    /// <param name="path">A path that is already present in this DisplayView.</param>
    [MethodImpl]
    public extern void SetPrimaryPath(DisplayPath path);

    /// <summary>Reserved for future use.</summary>
    /// <returns>
    /// </returns>
    public extern IMap<Guid, object> Properties { [MethodImpl] get; }
  }
}
