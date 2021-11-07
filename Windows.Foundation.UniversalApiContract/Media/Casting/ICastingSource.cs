// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ExclusiveTo(typeof (CastingSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4096387698, 13415, 18406, 160, 39, 82, 41, 35, 233, 215, 39)]
  internal interface ICastingSource
  {
    Uri PreferredSourceUri { get; set; }
  }
}
