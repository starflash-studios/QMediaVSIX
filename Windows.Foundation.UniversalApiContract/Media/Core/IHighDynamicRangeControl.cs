// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IHighDynamicRangeControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (HighDynamicRangeControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1441900462, 55639, 19913, 157, 28, 133, 83, 168, 42, 125, 153)]
  internal interface IHighDynamicRangeControl
  {
    bool Enabled { set; get; }
  }
}
