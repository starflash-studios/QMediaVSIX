// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IIppResolutionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (IppResolution))]
  [Guid(3833709230, 9498, 21286, 177, 115, 149, 84, 62, 217, 154, 53)]
  internal interface IIppResolutionFactory
  {
    IppResolution CreateInstance(int width, int height, IppResolutionUnit unit);
  }
}
