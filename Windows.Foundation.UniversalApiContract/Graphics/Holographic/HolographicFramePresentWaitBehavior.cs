// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFramePresentWaitBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Specifies whether a Present call should wait for the frame to finish or returns control to the thread immediately.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum HolographicFramePresentWaitBehavior
  {
    /// <summary>Don't return control to the thread until the current frame is finished.</summary>
    WaitForFrameToFinish,
    /// <summary>Return control to the thread immediately.</summary>
    DoNotWaitForFrameToFinish,
  }
}
