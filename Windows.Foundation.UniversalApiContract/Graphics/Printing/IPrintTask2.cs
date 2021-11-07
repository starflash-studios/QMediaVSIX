// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTask2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintTask))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(908281975, 15955, 19869, 143, 94, 49, 106, 200, 222, 218, 225)]
  internal interface IPrintTask2
  {
    bool IsPreviewEnabled { set; get; }
  }
}
