// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayServicesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Guid(3693123263, 29450, 21856, 180, 97, 145, 193, 61, 105, 46, 12)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (DisplayServices))]
  internal interface IDisplayServicesStatics
  {
    DisplayId[] FindAll();
  }
}
