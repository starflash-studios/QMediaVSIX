// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (DisplayInformation))]
  [Guid(3675586845, 3849, 17510, 143, 243, 17, 222, 154, 60, 146, 154)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDisplayInformation3
  {
    IReference<double> DiagonalSizeInInches { get; }
  }
}
