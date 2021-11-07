// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentDescriptionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ContentRestrictions
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RatedContentDescription))]
  [Guid(775479138, 39824, 20390, 137, 193, 75, 141, 47, 251, 53, 115)]
  internal interface IRatedContentDescriptionFactory
  {
    RatedContentDescription Create(
      string id,
      string title,
      RatedContentCategory category);
  }
}
