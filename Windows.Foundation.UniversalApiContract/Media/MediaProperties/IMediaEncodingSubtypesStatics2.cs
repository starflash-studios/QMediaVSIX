// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingSubtypesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaEncodingSubtypes))]
  [Guid(1266471485, 17151, 19763, 133, 49, 6, 38, 190, 228, 181, 45)]
  internal interface IMediaEncodingSubtypesStatics2
  {
    string Vp9 { get; }

    string L8 { get; }

    string L16 { get; }

    string D16 { get; }
  }
}
