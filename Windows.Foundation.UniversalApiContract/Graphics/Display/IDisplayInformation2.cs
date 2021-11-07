// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DisplayInformation))]
  [Guid(1305280545, 64209, 19342, 142, 223, 119, 88, 135, 184, 191, 25)]
  internal interface IDisplayInformation2 : IDisplayInformation
  {
    double RawPixelsPerViewPixel { get; }
  }
}
