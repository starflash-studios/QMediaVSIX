// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1372036689, 15238, 18765, 179, 89, 187, 46, 167, 172, 169, 169)]
  [ExclusiveTo(typeof (TimedTextCue))]
  internal interface ITimedTextCue : IMediaCue
  {
    TimedTextRegion CueRegion { get; set; }

    TimedTextStyle CueStyle { get; set; }

    IVector<TimedTextLine> Lines { get; }
  }
}
