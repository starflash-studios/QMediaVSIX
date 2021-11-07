// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.ICharacterGrouping
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [ExclusiveTo(typeof (CharacterGrouping))]
  [Guid(4209467835, 32861, 19376, 149, 187, 193, 247, 195, 232, 235, 142)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICharacterGrouping
  {
    string First { get; }

    string Label { get; }
  }
}
