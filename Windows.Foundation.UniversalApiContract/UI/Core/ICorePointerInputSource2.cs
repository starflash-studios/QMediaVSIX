// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICorePointerInputSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Defines the behavior of pointer input (for processing on a worker thread).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Guid(3607326858, 17686, 18310, 177, 229, 39, 81, 213, 99, 249, 151)]
  public interface ICorePointerInputSource2 : ICorePointerInputSource
  {
    /// <summary>Gets the DispatcherQueue associated with a platform object.</summary>
    /// <returns>The DispatcherQueue for managing prioritized tasks that execute in a serial fashion on a thread.</returns>
    DispatcherQueue DispatcherQueue { get; }
  }
}
