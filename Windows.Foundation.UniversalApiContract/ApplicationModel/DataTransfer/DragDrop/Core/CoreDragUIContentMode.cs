// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragUIContentMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Represents modes for overriding the drag UI. Use this to specify whether the operation should wait for content load before starting, or run in parallel.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum CoreDragUIContentMode : uint
  {
    /// <summary>Specifies content will be provided synchronously.</summary>
    Auto = 0,
    /// <summary>Specifies content will be provided with an asynchronous task.</summary>
    Deferred = 1,
  }
}
