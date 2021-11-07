// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IEmbeddedAudioTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmbeddedAudioTrack))]
  [Guid(1441684090, 11568, 16314, 161, 144, 79, 26, 100, 84, 248, 143)]
  internal interface IEmbeddedAudioTrack
  {
    AudioEncodingProperties GetAudioEncodingProperties();
  }
}
