// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IContainerEncodingProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (ContainerEncodingProperties))]
  [Guid(2993864745, 44582, 18457, 186, 173, 173, 122, 73, 176, 168, 118)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IContainerEncodingProperties2
  {
    ContainerEncodingProperties Copy();
  }
}
