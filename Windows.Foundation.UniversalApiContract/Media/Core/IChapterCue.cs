// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IChapterCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ChapterCue))]
  [Guid(1923710977, 54154, 19466, 143, 166, 117, 205, 218, 244, 102, 76)]
  internal interface IChapterCue : IMediaCue
  {
    string Title { set; get; }
  }
}
