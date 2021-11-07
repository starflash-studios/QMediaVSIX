// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1250348702, 19633, 17280, 142, 12, 131, 80, 75, 127, 91, 243)]
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  internal interface IAudioStreamDescriptorFactory
  {
    AudioStreamDescriptor Create(AudioEncodingProperties encodingProperties);
  }
}
