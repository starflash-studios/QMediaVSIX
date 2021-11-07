// Decompiled with JetBrains decompiler
// Type: Windows.UI.IColorHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI
{
  [ExclusiveTo(typeof (ColorHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2231688170, 64362, 16708, 166, 194, 51, 73, 156, 146, 132, 245)]
  internal interface IColorHelperStatics
  {
    Color FromArgb(byte a, byte r, byte g, byte b);
  }
}
