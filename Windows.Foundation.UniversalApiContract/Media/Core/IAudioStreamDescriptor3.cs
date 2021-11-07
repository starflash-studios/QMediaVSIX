// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptor3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1294077345, 36483, 17647, 137, 115, 47, 99, 233, 147, 243, 107)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  internal interface IAudioStreamDescriptor3
  {
    AudioStreamDescriptor Copy();
  }
}
