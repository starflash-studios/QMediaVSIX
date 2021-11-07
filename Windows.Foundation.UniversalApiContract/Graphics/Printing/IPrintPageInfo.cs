// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintPageInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintPageInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(3712739785, 42657, 19162, 147, 14, 218, 135, 42, 79, 35, 211)]
  internal interface IPrintPageInfo
  {
    PrintMediaSize MediaSize { set; get; }

    Size PageSize { set; get; }

    uint DpiX { set; get; }

    uint DpiY { set; get; }

    PrintOrientation Orientation { set; get; }
  }
}
