// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.Direct3DUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  /// <summary>This is a Windows Runtime equivalent of the Desktop D3D11_USAGE enumeration. Identifies expected resource use during rendering. The usage directly reflects whether a resource is accessible by the CPU and/or the graphics processing unit (GPU).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Direct3DUsage
  {
    /// <summary>A resource that requires read and write access by the GPU.</summary>
    Default,
    /// <summary>A resource that can only be read by the GPU. It cannot be written by the GPU, and cannot be accessed at all by the CPU. This type of resource must be initialized when it is created, since it cannot be changed after creation.</summary>
    Immutable,
    /// <summary>A resource that is accessible by both the GPU (read only) and the CPU (write only). A dynamic resource is a good choice for a resource that will be updated by the CPU at least once per frame.</summary>
    Dynamic,
    /// <summary>A resource that supports data transfer (copy) from the GPU to the CPU.</summary>
    Staging,
  }
}
