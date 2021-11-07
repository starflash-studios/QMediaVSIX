// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingSubtypesStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(2703567219, 43396, 22802, 147, 187, 84, 231, 229, 105, 224, 83)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (MediaEncodingSubtypes))]
  internal interface IMediaEncodingSubtypesStatics6
  {
    string Pgs { get; }

    string Srt { get; }

    string Ssa { get; }

    string VobSub { get; }
  }
}
