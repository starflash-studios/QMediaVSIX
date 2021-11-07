// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplaySource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Storage.Streams;

namespace Windows.Devices.Display.Core
{
  /// <summary>Provides ownership of a source, allowing the owner to present frames.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplaySource : IDisplaySource, IDisplaySource2
  {
    /// <summary>Gets the adapter ID associated with this DisplaySource.</summary>
    /// <returns>A DisplayAdapterId containing the adapter ID associated with this source.</returns>
    public extern DisplayAdapterId AdapterId { [MethodImpl] get; }

    /// <summary>Gets an adapter-relative identifier for this source.</summary>
    /// <returns>An adapter-relative identifier for this source.</returns>
    public extern uint SourceId { [MethodImpl] get; }

    /// <summary>Retrieves dynamic metadata from the source.</summary>
    /// <param name="Key">
    /// </param>
    /// <returns>An IBuffer.</returns>
    [MethodImpl]
    public extern IBuffer GetMetadata(Guid Key);

    public extern DisplaySourceStatus Status { [MethodImpl] get; }

    public extern event TypedEventHandler<DisplaySource, object> StatusChanged;
  }
}
