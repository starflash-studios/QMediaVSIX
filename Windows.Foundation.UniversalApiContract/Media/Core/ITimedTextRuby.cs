// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextRuby
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(271801385, 23356, 22163, 153, 89, 208, 90, 11, 210, 70, 40)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (TimedTextRuby))]
  internal interface ITimedTextRuby
  {
    string Text { get; set; }

    TimedTextRubyPosition Position { get; set; }

    TimedTextRubyAlign Align { get; set; }

    TimedTextRubyReserve Reserve { get; set; }
  }
}
