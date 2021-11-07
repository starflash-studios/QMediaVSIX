// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMultiSourceMediaFrameReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MultiSourceMediaFrameReference))]
  [Guid(563497754, 32738, 17622, 146, 229, 41, 142, 109, 40, 16, 233)]
  internal interface IMultiSourceMediaFrameReference : IClosable
  {
    MediaFrameReference TryGetFrameReferenceBySourceId(string sourceId);
  }
}
