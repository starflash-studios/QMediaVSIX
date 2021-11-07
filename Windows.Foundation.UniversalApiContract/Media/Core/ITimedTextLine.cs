// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextLine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedTextLine))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2542632162, 29448, 19558, 190, 80, 101, 119, 114, 137, 245, 223)]
  internal interface ITimedTextLine
  {
    string Text { get; set; }

    IVector<TimedTextSubformat> Subformats { get; }
  }
}
