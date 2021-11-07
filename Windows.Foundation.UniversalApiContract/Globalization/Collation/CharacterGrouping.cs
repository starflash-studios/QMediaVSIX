// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.CharacterGrouping
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  /// <summary>A container for character group information. Characters are grouped in an index that enables an application to determine where the grouping boundaries are.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CharacterGrouping : ICharacterGrouping
  {
    /// <summary>Gets the first item that appears in the grouping under this index.</summary>
    /// <returns>The string that defines the start of the group that has the associated label. The start of the next group implicitly determines its end.</returns>
    public extern string First { [MethodImpl] get; }

    /// <summary>Gets the label that is associated with this index.</summary>
    /// <returns>The string to use as the label for all strings of this group. This string may be empty, in which case the label is considered to be "other".</returns>
    public extern string Label { [MethodImpl] get; }
  }
}
