// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IDetectedFace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2181092436, 26300, 13535, 148, 16, 232, 148, 0, 25, 84, 20)]
  [ExclusiveTo(typeof (DetectedFace))]
  internal interface IDetectedFace
  {
    BitmapBounds FaceBox { get; }
  }
}
