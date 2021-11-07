// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextLine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a line of text that is displayed with a TimedTextCue.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class TimedTextLine : ITimedTextLine
  {
    /// <summary>Initializes a new instance of the TimedTextLine class.</summary>
    [MethodImpl]
    public extern TimedTextLine();

    /// <summary>Gets or sets the text content of the TimedTextLine.</summary>
    /// <returns>The text content of the TimedTextLine.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of TimedTextSubformat objects that provide formatting for substrings within the TimedTextLine.</summary>
    /// <returns>A list of TimedTextSubformat objects that provide formatting for substrings within the timed text line.</returns>
    public extern IVector<TimedTextSubformat> Subformats { [MethodImpl] get; }
  }
}
