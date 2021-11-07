// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.Direct3DMultisampleDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  /// <summary>This is a Windows Runtime equivalent of the Desktop DXGI_SAMPLE_DESC structure.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Direct3DMultisampleDescription
  {
    /// <summary>The number of multisamples per pixel.</summary>
    public int Count;
    /// <summary>The image quality level. The higher the quality, the lower the performance.</summary>
    public int Quality;
  }
}
