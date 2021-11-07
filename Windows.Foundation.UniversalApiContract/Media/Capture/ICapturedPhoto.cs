// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedPhoto
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CapturedPhoto))]
  [Guid(2966322778, 53196, 19820, 138, 209, 8, 105, 32, 138, 202, 22)]
  internal interface ICapturedPhoto
  {
    CapturedFrame Frame { get; }

    CapturedFrame Thumbnail { get; }
  }
}
