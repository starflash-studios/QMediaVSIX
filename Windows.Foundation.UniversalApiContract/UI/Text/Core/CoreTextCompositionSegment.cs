// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextCompositionSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Represents a segment in a composition string. See Remarks for an illustration.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreTextCompositionSegment : ICoreTextCompositionSegment
  {
    /// <summary>Gets a string that represents the state of the user input after IME-processing but before final conversion.</summary>
    /// <returns>A string that represents the pre-conversion string.</returns>
    public extern string PreconversionString { [MethodImpl] get; }

    /// <summary>Gets an object that represents the range that defines this composition segment.</summary>
    /// <returns>An object that represents the range that defines this composition segment.</returns>
    public extern CoreTextRange Range { [MethodImpl] get; }
  }
}
