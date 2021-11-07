// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ILowLightFusionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (LowLightFusionResult))]
  [Guid(2028846645, 10144, 17120, 156, 211, 115, 141, 32, 137, 222, 156)]
  internal interface ILowLightFusionResult
  {
    SoftwareBitmap Frame { get; }
  }
}
