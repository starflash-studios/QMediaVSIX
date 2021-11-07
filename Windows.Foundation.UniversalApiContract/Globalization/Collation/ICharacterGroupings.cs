// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.ICharacterGroupings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CharacterGroupings))]
  [Guid(3100772981, 54479, 16469, 128, 229, 206, 22, 156, 34, 100, 150)]
  internal interface ICharacterGroupings : 
    IVectorView<CharacterGrouping>,
    IIterable<CharacterGrouping>
  {
    string Lookup(string text);
  }
}
