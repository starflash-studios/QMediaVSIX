// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextSubformat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Defines a TimedTextStyle for a substring in a TimedTextLine. of the cue, which defines the style of the rendered text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class TimedTextSubformat : ITimedTextSubformat
  {
    /// <summary>Initializes a new instance of the TimedTextSubformat class.</summary>
    [MethodImpl]
    public extern TimedTextSubformat();

    /// <summary>Gets or sets the staring index of the substring to which the SubformatStyle applies.</summary>
    /// <returns>The starting index of the substring to which the formatting style applies.</returns>
    public extern int StartIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the length of the substring to which the SubformatStyle applies.</summary>
    /// <returns>The length of the substring to which the formatting style applies.</returns>
    public extern int Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the TimedTextStyle object that conveys the formatting of a substring in a TimedTextLine.</summary>
    /// <returns>The object that conveys the formatting of a substring in a TimedTextLine.</returns>
    public extern TimedTextStyle SubformatStyle { [MethodImpl] get; [MethodImpl] set; }
  }
}
