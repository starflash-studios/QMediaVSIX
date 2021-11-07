// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextStyle3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedTextStyle))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(4161009979, 16025, 22878, 187, 183, 120, 162, 250, 19, 194, 112)]
  internal interface ITimedTextStyle3
  {
    TimedTextRuby Ruby { get; }

    TimedTextBouten Bouten { get; }

    bool IsTextCombined { get; set; }

    double FontAngleInDegrees { get; set; }
  }
}
