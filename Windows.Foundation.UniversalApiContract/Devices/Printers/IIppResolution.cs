// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppResolution
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (IppResolution))]
  [Guid(3410575238, 27635, 22261, 134, 206, 38, 61, 8, 174, 173, 99)]
  internal interface IIppResolution
  {
    int Width { get; }

    int Height { get; }

    IppResolutionUnit Unit { get; }
  }
}
