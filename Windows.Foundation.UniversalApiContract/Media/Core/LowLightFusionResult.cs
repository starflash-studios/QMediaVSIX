// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.LowLightFusionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  /// <summary>Represents the result of a low-light fusion operation initiated with a call to **FuseAsync**.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class LowLightFusionResult : ILowLightFusionResult, IClosable
  {
    /// <summary>Gets the image containing the processed result of the low-light fusion operation.</summary>
    /// <returns>The image containing the processed result of the low-light fusion operation.</returns>
    public extern SoftwareBitmap Frame { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
