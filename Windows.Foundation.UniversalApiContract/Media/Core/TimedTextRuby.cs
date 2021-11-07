// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextRuby
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  public sealed class TimedTextRuby : ITimedTextRuby
  {
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextRubyPosition Position { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextRubyAlign Align { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextRubyReserve Reserve { [MethodImpl] get; [MethodImpl] set; }
  }
}
