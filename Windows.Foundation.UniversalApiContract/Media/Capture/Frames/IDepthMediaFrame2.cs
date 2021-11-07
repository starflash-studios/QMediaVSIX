// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IDepthMediaFrame2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (DepthMediaFrame))]
  [Guid(1825195837, 50340, 16758, 176, 205, 51, 234, 227, 179, 90, 163)]
  internal interface IDepthMediaFrame2
  {
    uint MaxReliableDepth { get; }

    uint MinReliableDepth { get; }
  }
}
