// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.CharacterGroupings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  /// <summary>Contains the set of character groups and the functionality to get the label for any given string.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (ICharacterGroupingsFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class CharacterGroupings : 
    ICharacterGroupings,
    IVectorView<CharacterGrouping>,
    IIterable<CharacterGrouping>
  {
    /// <summary>Create a CharacterGroupings object for the collation belonging to the given language.</summary>
    /// <param name="language">
    /// </param>
    [MethodImpl]
    public extern CharacterGroupings(string language);

    /// <summary>Create a CharacterGroupings object for the default collation.</summary>
    [MethodImpl]
    public extern CharacterGroupings();

    /// <summary>Gets the label under which the provided text falls.</summary>
    /// <param name="text">The string for which to get the label.</param>
    /// <returns>If successful, this method returns the label. Otherwise, it returns the input value.</returns>
    [MethodImpl]
    public extern string Lookup(string text);

    [MethodImpl]
    public extern CharacterGrouping GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(CharacterGrouping value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] CharacterGrouping[] items);

    [MethodImpl]
    public extern IIterator<CharacterGrouping> First();
  }
}
