// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMultiSourceMediaFrameReader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MultiSourceMediaFrameReader))]
  [Guid(4015819453, 64604, 19563, 157, 129, 60, 185, 204, 99, 124, 38)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMultiSourceMediaFrameReader2
  {
    MediaFrameReaderAcquisitionMode AcquisitionMode { set; get; }
  }
}
