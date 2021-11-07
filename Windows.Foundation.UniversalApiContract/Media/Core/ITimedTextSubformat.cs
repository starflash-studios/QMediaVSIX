// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSubformat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3608367151, 12897, 18210, 160, 194, 185, 55, 178, 57, 15, 20)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimedTextSubformat))]
  internal interface ITimedTextSubformat
  {
    int StartIndex { get; set; }

    int Length { get; set; }

    TimedTextStyle SubformatStyle { get; set; }
  }
}
