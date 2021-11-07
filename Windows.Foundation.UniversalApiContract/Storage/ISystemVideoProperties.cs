// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemVideoProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemVideoProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(541128469, 26616, 17186, 155, 128, 79, 169, 254, 251, 131, 232)]
  internal interface ISystemVideoProperties
  {
    string Director { get; }

    string FrameHeight { get; }

    string FrameWidth { get; }

    string Orientation { get; }

    string TotalBitrate { get; }
  }
}
